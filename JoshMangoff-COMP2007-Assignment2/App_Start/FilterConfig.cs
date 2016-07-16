using System.Web;
using System.Web.Mvc;

namespace JoshMangoff_COMP2007_Assignment2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
