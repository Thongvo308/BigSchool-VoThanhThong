using System.Web;
using System.Web.Mvc;

namespace LapBigSchool_VoThanhThong
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
