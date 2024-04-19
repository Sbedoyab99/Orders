using Microsoft.AspNetCore.Components;
using Orders.Frontend.Services;

namespace Orders.Frontend.Pages.Auth
{
    public partial class LogOut
    {
        [Inject] private ILogInService LogInService { get; set; } = null!;
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        protected override async Task OnInitializedAsync()
        {
            await LogInService.LogoutAsync();
            NavigationManager.NavigateTo("/");  
        }
    }
}