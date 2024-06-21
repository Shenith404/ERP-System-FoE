﻿using MudBlazorUI.Auth.Services;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using MudBlazorUI.Auth.DTOs;
using MudBlazorUI.Auth.Services;

namespace MudBlazorUI.Auth.Handler
{
    public class JwtAuthenticationHandler : DelegatingHandler
    {
        private readonly IJwtAuthenticationService _jwtAuthenticationService;
        private readonly ILogger<JwtAuthenticationHandler> _logger;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly SemaphoreSlim _refreshLock = new SemaphoreSlim(2, 2);

        public JwtAuthenticationHandler(IJwtAuthenticationService jwtAuthenticationService,
            ILogger<JwtAuthenticationHandler> logger,
            AuthenticationStateProvider authenticationStateProvider)
        {
            _jwtAuthenticationService = jwtAuthenticationService;
            _logger = logger;
            _authenticationStateProvider = authenticationStateProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Retrieve JWT token
            var jwt = await _jwtAuthenticationService.GetJwtAsync();
           

            // Set Authorization header if JWT token is not empty or null
            if (!string.IsNullOrEmpty(jwt))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
            }

            // Call the base SendAsync method to continue processing the request pipeline
            var response = await base.SendAsync(request, cancellationToken);

            if (!string.IsNullOrEmpty(jwt) && response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
              
                try
                {
                    Console.WriteLine("refresh started  1");
                    // Attempt to refresh the token
                    var refreshSucceeded = await _jwtAuthenticationService.Refresh();
                  

                    if (refreshSucceeded==true)
                    {
                        jwt = await _jwtAuthenticationService.GetJwtAsync();
                        _logger.LogInformation("JWT token refreshed: {jwt}", jwt);

                        // Set Authorization header if JWT token is not empty or null
                        if (!string.IsNullOrEmpty(jwt))
                        {
                            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

                            // Retry the request with the refreshed token
                            response = await base.SendAsync(request, cancellationToken);
                        }
                    }
                    else
                    {
                        Console.WriteLine("refresh fail 2");

                        // Notify authentication state provider of logout
                        (_authenticationStateProvider as CustomAuthenticationStateProvider)?.NotifyUserLogout();
                        await _jwtAuthenticationService.LogoutAcync();
                        return null;
                    }
                }
                finally
                {
                    _refreshLock.Release();
                }
            }

            return response;
        }
    }
}
