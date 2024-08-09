using Microsoft.AspNetCore.Mvc;

namespace ChasePortfolioWeb.Pages.Components.ProjectShowcase
{
    public class SkillsChartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
