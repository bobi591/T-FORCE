using System;
using System.Collections.Generic;
using System.Linq;
using T_FORCE.Models;
using T_FORCE.UI;

namespace T_FORCE.Repositories
{
    /// <summary>
    /// The main <c>ProjectRepository</c> class.
    /// Contains methods for database related queries related to the Project object.
    /// </summary>
    public class ProjectRepository
    {

        private static IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        /// <summary>
        /// Get project by name.
        /// </summary>
        public Project GetProjectByName(string projectName)
        {
            return appDbContext.Projects.Where(project => project.Name == projectName).FirstOrDefault();
        }

        /// <summary>
        /// Get project by Id.
        /// </summary>
        public Project GetProjectById(string projectId)
        {
            return appDbContext.Projects.Where(project => project.Id == Convert.ToInt32(projectId)).FirstOrDefault();
        }

        /// <summary>
        /// Get project by code.
        /// </summary>
        public Project GetProjectByCode(string projectCode)
        {
            return appDbContext.Projects.Where(project => project.Code == projectCode).FirstOrDefault();
        }

        /// <summary>
        /// Saves the project into the database. Returns viewbag message.
        /// </summary>
        public async System.Threading.Tasks.Task<string> SaveProject(Project project)
        {
            string viewbagMessage;

            if (IsUnique(project, out viewbagMessage))
            {
                await appDbContext.AddAsync(project);
                await appDbContext.SaveChangesAsync();
                return viewbagMessage;
            }
            else
            {
                return viewbagMessage;
            }
        }

        /// <summary>
        /// Updates the project in the database.
        /// </summary>
        public async System.Threading.Tasks.Task UpdateProject(Project project)
        {
            appDbContext.Update(project);
            await appDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all the projects.
        /// </summary>
        public List<Project> GetAllProjects()
        {
            return appDbContext.Projects.ToList();
        }

        /// <summary>
        /// Checks if the project name and code are unique.
        /// </summary>
        private bool IsUnique(Project project, out string viewBagMessage)
        {
            int nameEncounter = appDbContext.Projects.Where(p => p.Name == project.Name).Count();
            int codeEncounter = appDbContext.Projects.Where(p => p.Code == project.Code).Count();

            if(nameEncounter>0 || codeEncounter > 0)
            {
                viewBagMessage = PredefinedViewBag.ProjectNotUnqiue;
                return false;
            }
            else
            {
                viewBagMessage = PredefinedViewBag.ProjectCreated;
                return true;
            }
        }
    }
}
