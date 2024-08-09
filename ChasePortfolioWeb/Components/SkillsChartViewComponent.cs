using Microsoft.AspNetCore.Mvc;

namespace ChasePortfolioWeb.Components
{
    public class SkillsChartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
