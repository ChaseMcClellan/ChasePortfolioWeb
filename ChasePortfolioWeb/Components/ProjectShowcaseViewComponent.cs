using ChasePortfolioWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChasePortfolioWeb.Components
{
    public class ProjectShowcaseViewComponent : ViewComponent
    {
        private readonly ProjectService _projectService;

        public ProjectShowcaseViewComponent(ProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var projects = _projectService.GetProjects();
            return View(projects);
        }
    }

}
