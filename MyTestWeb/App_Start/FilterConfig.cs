using System.Web;
using System.Web.Mvc;

namespace MyTestWeb
{
    /// <summary>
    /// 注册全局MVC过滤器
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
