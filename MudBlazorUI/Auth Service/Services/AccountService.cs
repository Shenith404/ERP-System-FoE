﻿using MudBlazorUI.Auth_Service.DTOs.Request;
using MudBlazorUI.Core.DTOs.Request;
using MudBlazorUI.Core.DTOs.Response;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MudBlazorUI.Auth.Services
{
    public class AccountService : IAccountService
    {

        private readonly IHttpClientFactory _factory;

        public AccountService(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<bool> ForgotPassword(string email)
        {
            var result = await _factory.CreateClient("ServerApi").PostAsJsonAsync("ApiGateWay/Auth-api/Account/ForgotPassword-Verification-Sender", email);
           
            if (result.IsSuccessStatusCode) {
                return true;

            }
            else
            {
                return false ;
            }
        }

        public async Task<UserModelResponseDTO?> GetUserDetaiils() {

            var result = await _factory.CreateClient("ServerApi").GetAsync("ApiGateWay/Auth-api/Account/Get-User-Details");
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();

                var response = JsonConvert.DeserializeObject<UserModelResponseDTO>(content);
                return response;

            }

            else return null;
        }


        public async Task<string?> Resend2FACode(string email)
        {
            var result = await _factory.CreateClient("ServerApi").PostAsJsonAsync("ApiGateWay/Auth-api/Account/Resend-2FAVerificationCode", email);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();

                var response = JsonConvert.DeserializeObject<AuthenticationResponseDTO>(content);
                return response!.Message;
                
            }

            else return null;
        }

        public async Task<HttpResponseMessage> ChangePassword(ChangePasswordRequestDTO changePassword)
        {
            var result = await _factory.CreateClient("ServerApi").PostAsJsonAsync("ApiGateWay/Auth-api/Account/ChangePassword", changePassword);
             
                return result;

           
        } 
        
        public async Task<HttpResponseMessage> Enable2FA(TFAEnableRequestDTO tFAEnableRequestDTO)
        {
            var result = await _factory.CreateClient("ServerApi").PostAsJsonAsync("ApiGateWay/Auth-api/Account/Enable-2FA", tFAEnableRequestDTO);
             
                return result;
           
        }
        
        public async Task<string?> GetProfileImage(string fileName)
        {
            var result = await _factory.CreateClient("ServerApi").PostAsJsonAsync("ApiGateWay/Auth-api/Image/image", fileName);
            if (result.IsSuccessStatusCode)
            {

                var imageBytes = await result.Content.ReadAsByteArrayAsync();
                var base64Image = Convert.ToBase64String(imageBytes);
                return $"data:image/{Path.GetExtension(fileName).TrimStart('.')};base64,{base64Image}";
            }
            else return null;


        }   
        public async Task<HttpResponseMessage> UploadProfileImage(MultipartFormDataContent content )
        {

              
            var result = await _factory.CreateClient("ServerApi").PostAsync("ApiGateWay/Auth-api/Image/upload-image", content);
           
            return result;


        }





    }
}
