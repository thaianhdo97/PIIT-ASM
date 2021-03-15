using System.Web;
using System.Web.Mvc;

namespace DoThaiAnh_PIIT_ASM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
