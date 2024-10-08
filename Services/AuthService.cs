﻿using AchieveClubFrontend.Data;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Threading.Tasks;


namespace AchieveClubFrontend.Services;

public class AuthService(HttpClient client)
{
    private HttpClient _httpClient = client;

    public async Task<LoginResponse> LoginAsync(LoginData loginData)
    {
        var response = await _httpClient.PostAsJsonAsync("/api/auth/login?api-version=1.1", loginData);
        if (response.IsSuccessStatusCode)
        {
            response.EnsureSuccessStatusCode();
            var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
            return loginResponse;
        }
        else
        {
            var errorResponse = new LoginResponse { Message = "Неправильный пароль или email, повторите вход." };
            return errorResponse;
        }
    }
}
