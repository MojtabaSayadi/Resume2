using Microsoft.AspNetCore.Mvc;

namespace Resume2.Areas.AdminPanel.Views.ViewComponents
{
    public class LoginStatusComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("LoginStatusDashboard"));

        }

    }
}
