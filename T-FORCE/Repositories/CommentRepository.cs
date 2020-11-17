using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_FORCE.Models;

namespace T_FORCE.Repositories
{
    public class CommentRepository
    {
        private static readonly IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private readonly AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        /// <summary>
        /// Retrieves the comment by Id.
        /// </summary>
        public Comment GetCommentById(string commentId)
        {
            Comment comment = appDbContext.Comments.Where(comm => comm.Id == int.Parse(commentId)).First();
            return comment;
        }

        /// <summary>
        /// Retrieves comments created from a User.
        /// </summary>
        public List<Comment> GetCommentsCreatedBy(string userId)
        {
            List<Comment> comments = appDbContext.Comments.Where(comm => comm.UserId == int.Parse(userId)).ToList();
            return comments;
        }

        /// <summary>
        /// Retrieves comments for a Task.
        /// </summary>
        public List<Comment> GetCommentsForTask(string taskId)
        {
            List<Comment> comments = appDbContext.Comments.Where(comm => comm.TaskId == int.Parse(taskId)).ToList();
            return comments;
        }

        /// <summary>
        /// Save the passed Comment object into the database.
        /// </summary>
        public async System.Threading.Tasks.Task SaveComment(Comment comment)
        {
            await appDbContext.AddAsync(comment);
            await appDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Update the passed Comment object into the database. The method sets the Last Modified DateTime automatically.
        /// </summary>
        public async System.Threading.Tasks.Task UpdateComment(Comment comment)
        {
            comment.LastModified = DateTime.UtcNow;
            appDbContext.Update(comment);
            await appDbContext.SaveChangesAsync();
        }
    }
}
