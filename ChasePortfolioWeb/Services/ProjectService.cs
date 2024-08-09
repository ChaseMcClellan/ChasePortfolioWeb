using ChasePortfolioWeb.Models;

namespace ChasePortfolioWeb.Services
{
    public class ProjectService
    {
        public List<Project> GetProjects()
        {
            return new List<Project>
        {
            new Project
            {
                Title = "Project 1",
                Description = "Description for Project 1",
                ImageUrl = "/images/project1.jpg",
                ProjectUrl = "https://github.com/yourusername/project1"
            },
            // Add more projects as needed
        };
        }
    }
}
