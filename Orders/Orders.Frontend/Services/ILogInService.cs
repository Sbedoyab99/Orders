namespace Orders.Frontend.Services
{
    public interface ILogInService
    {
        Task LoginAsync(string token);

        Task LogoutAsync();
    }
}