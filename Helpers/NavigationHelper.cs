using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IBBPortal.Helpers
{
    public static class NavigationHelper
    {
        public static string ProjectEdit => "Project/Edit";

        public static string ProjectFeasibility => "ProjectFeasibility/Form";

        public static string ProjectPerson => "ProjectPerson/Index";

        public static string ProjectRelation => "ProjectRelation/Index";

        public static string ProjectField => "ProjectField/Edit";

        public static string ProjectMap => "ProjectMap/ProjectDetail";

        public static string ProjectSubfunctionFeature => "ProjectSubfunctionFeature/Index";

        public static string ProjectPhase => "ProjectPhase/Index";
        
        public static string ProjectBidding => "ProjectBidding/Index";
        
        public static string File => "File/Index";

        public static string ProjectEditNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectEdit, mod);

        public static string ProjectFeasibilityNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectFeasibility, mod);

        public static string ProjectPersonNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectPerson, mod);

        public static string ProjectRelationNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectRelation, mod);

        public static string ProjectFieldNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectField, mod);

        public static string ProjectMapNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectMap, mod);

        public static string ProjectSubfunctionFeatureNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectSubfunctionFeature, mod);

        public static string ProjectPhaseNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectPhase, mod);
        
        public static string ProjectBiddingNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, ProjectBidding, mod);
        
        public static string FileNavClass(ViewContext viewContext, string mod = "default") => PageNavClass(viewContext, File, mod);

        private static string PageNavClass(ViewContext viewContext, string page, string mod)
        {
            var activePage = viewContext.RouteData.Values["Controller"].ToString() + "/" + viewContext.RouteData.Values["Action"].ToString()
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            if (mod == "default") return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
            else return !string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "d-none d-xl-block" : null;
        }
    }
}
