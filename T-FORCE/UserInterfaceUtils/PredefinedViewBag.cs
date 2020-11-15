using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_FORCE.UserInterfaceUtils
{
    public static class PredefinedViewBag
    {
        public const string BadLoginAttempt = "Incorrect password!";
        public const string NoSuchUserFound = "No such user found!";
        public const string UserIsBlocked = "The user is blocked!";
        public const string LoginSuccess = "Login success!";
        public const string UsernameNotUnique = "The username is already in use!";
        public const string EmailNotUnique = "The email is already in use!";
        public const string BadEmailFormat = "The provided email is invalid!";
        public const string RegisterSuccess = "Register success!";
        public const string AssignedTasks = "Assigned Tasks";
        public const string CreatedTasks = "CreatedTasks";
        public const string ProjectNotUnqiue = "The project name or code is already in use!";
        public const string ProjectCreated = "The project was created successfully!";
    }
}
