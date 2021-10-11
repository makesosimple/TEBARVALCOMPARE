using IBBPortal.Data;
using IBBPortal.Static;
using System;

namespace IBBPortal.Helpers
{
    static class ProjectFieldHelper
    {
        public static void Create<TEntity>(

            this TEntity entity,
            ApplicationDbContext context,
            TEntity viewModel,
            int projectID,
            string currentUserID)

            where TEntity : class, TProjectField, new()
        {
            TEntity creationModel = new TEntity();
            creationModel = viewModel;

            creationModel.CreationDate = DateTime.Now;
            creationModel.ProjectID = projectID;
            creationModel.UserID = currentUserID;

            context.Add(creationModel);
        }
    }
}
