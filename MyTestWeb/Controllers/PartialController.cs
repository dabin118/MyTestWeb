using MyTestWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTestWeb.Controllers
{
    public class PartialController : Controller
    {
        //部分页面示例首页
        public ActionResult Index()
        {
            return View();
        }

        #region 指定部分页面示例
        public ActionResult _Partial()
        {
            ViewBag.PartialMessage = "_Partial";

            return PartialView();
        }

        public ActionResult _RenderPartial()
        {
            ViewBag.RenderPartiaMessage = "直接将MVC用户控件嵌入到界面上";

            return PartialView();
        }

        //在控制器中的某个方法只能让Html.RenderAction()调用时，可以在方法上添加特性[ChildActionOnly]，其它的地方无法访问。
        [ChildActionOnly]
        public ActionResult _RenderAction()
        {
            ViewBag.RenderActionMessage = "直接重新执行一次Controller → Model → View的顺序，然后把产生的页面带回到原来的View中再回传";

            return PartialView();
        }

        public ActionResult _Action()
        {

            PartialActionModel model = new PartialActionModel();

            model.Title = "Action中传递的ViewModel值";
            return PartialView(model);
        }

        #endregion
    }
}