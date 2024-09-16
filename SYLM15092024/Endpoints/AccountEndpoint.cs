using SYLM15092024.Auth;

namespace SYLM15092024.Endpoints
{
    public static class AccountEndpoint
    {
        public static void AddAccountEndpoint(this WebApplication app)
        {
            app.MapPost("/account/login", (string login, string password, IJwtAuthenticationService authService) =>
            {
                if (login == "admin" && password == "12345")
                {
                    var token = authService.Authenticate(login);

                    return Results.Ok(token);
                }
                else
                {
                    return Results.Unauthorized();
                }
            });
        }
    }
}


