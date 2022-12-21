using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjectTeam.Web.Common
{
    public static class AppExtension
    {
        public static string GetCurrentActionName(this ViewContext viewContext)
        {
            return viewContext.RouteData.Values["action"].ToString();
        }
        public static string GetCurrentControllerName(this ViewContext viewContext)
        {
            return viewContext.RouteData.Values["controller"].ToString();
        }
    }
}
