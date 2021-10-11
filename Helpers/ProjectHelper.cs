using IBBPortal.Data;
using System;

namespace IBBPortal.Helpers
{
    public static class ProjectHelper
    {
        public static void UpdatedProject(int id, ApplicationDbContext _context)
        {
            var currentProject = _context.Project.Find(id);
            currentProject.UpdateDate = DateTime.Now;

            try
            {
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
