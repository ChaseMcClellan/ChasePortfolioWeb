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
                Title = "Random Sound Discord Bot",
                Description = "Produced a simple soundboard bot using Discord’s development tools. Used C# programming and Discord API. " +
                "Includes simple command triggers and basic discord bot functions.",
                ImageUrl = "https://static-00.iconduck.com/assets.00/discord-icon-2048x2048-o5mluhz2.png",
                ProjectUrl = "https://github.com/ChaseMcClellan/DiscordSoundBot"
            },
            new Project
            {
                Title = "ASP.Net Full Stack Website",
                Description = "Engineered a full stack application using ASP.Net framework. Designed a relational database hosted on Azure. Implemented features such as login, administrative roles, and shopping cart.\r\n",
                ImageUrl = "https://devblogs.microsoft.com/aspnet/wp-content/uploads/sites/16/2019/04/BrandBlazor_nohalo_1000x.png",
                ProjectUrl = "https://github.com/ChaseMcClellan/ChaseWebsite.git"
            },
            new Project
            {
                Title = "ASP.Net CORE Personal Portfolio",
                Description = "Engineered a portfolio application using ASP.Net framework. Using MVC logic, a fully interactive website for the user \r\n",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/1024px-.NET_Core_Logo.svg.png",
                ProjectUrl = ""
            }
        };
        }
    }
}
