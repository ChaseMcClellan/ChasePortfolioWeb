using Microsoft.AspNetCore.Mvc;

namespace ChasePortfolioWeb.Pages.Components.SkillsChart
{
    public class SkillsChartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
