namespace SAM.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        AuthenticationResult IAuthenticationService.Login(string email, string password)
        {
            return new AuthenticationResult
            (
                Guid.NewGuid(),
                "John",
                "Doe",
                email,
                "token"
            );
        }

        AuthenticationResult IAuthenticationService.Register(string firstName, string lastName, string email, string password)
        {
            return new AuthenticationResult
            (
                Guid.NewGuid(),
                firstName,
                lastName,
                email,
                "token"
            );
        }
    }
}