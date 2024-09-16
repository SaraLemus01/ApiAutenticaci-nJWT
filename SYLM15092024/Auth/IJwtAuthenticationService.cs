namespace SYLM15092024.Auth
{
    public interface IJwtAuthenticationService
    {
        //Metodo para autenticar al usuario y generar un token JWT
        string Authenticate(string userName);
    }
}
