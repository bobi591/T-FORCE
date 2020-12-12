using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_FORCE.Models;
using T_FORCE.Repositories;

namespace T_FORCE.Processes
{
    //This class includes checkers for object uniqueness. 
    //Prior saving a new object to the database, the methods below are checking if the indexing object attributes are unique!
    public static class ObjectUniquenessCheck
    {
        public static bool ProjectIsUnique(Project project)
        {
            ProjectRepository projectRepository = new ProjectRepository();

            bool isUnique = true;

            if (projectRepository.GetProjectByCode(project.Code) != null)
            {
                isUnique = false;
            }
            else if (projectRepository.GetProjectByName(project.Name) != null)
            {
                isUnique = false;
            }

            return isUnique;  

        }
    }
}
