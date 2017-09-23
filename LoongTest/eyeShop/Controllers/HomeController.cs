using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eyeShop.Controllers
{
    public class HomeController : Controller
    {
        eyeshopEntities context = new eyeshopEntities();
        //
        // GET: /Home/

        public ActionResult Index(string serch, int? page)
        {
            int count = (from h in context.H1065 select h).ToList().Count;
            int pageIndex = page ?? 1;
            int pageSize = 30;
            var query = (from h in context.H1065 select h).ToList().OrderBy(m => m.Item_No).Skip(pageIndex * pageSize).Take(pageSize);
            if (serch != null)
            {
                query = (from h in context.H1065 select h).Where(m => m.Item_Descc.IndexOf(serch) > 0).ToList().OrderBy(m => m.Item_No).Skip(pageIndex * pageSize).Take(pageSize);
                count = (from h in context.H1065 select h).Where(m => m.Item_Descc.IndexOf(serch) > 0).ToList().Count;
            }
            //int totalPage = (count + pageSize - 1) / pageSize;
            int totalPage = count / pageSize;
            ViewData["count"] = count;
            ViewData["pageIndex"] = pageIndex;
            ViewData["pageSize"] = pageSize;
            ViewData["totalPage"] = totalPage;
            return View(query);
        }
        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ActionResult Login(string username, string password)
        {
            var query = from h in context.H1196 where h.User_name == username && password == h.PassWord select h;
            Session["username"] = username;
            if (query.Count() > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        #endregion

        #region 注销
        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
        #endregion

        public ActionResult Details(string itemNo)
        {
            //var query = (from s in context.H1066 join f in context.H1065 on s.Item_No equals f.Item_No join fr in context.H1040 on s.Item_No equals fr.Item_No where s.Item_No == itemNo select new { Item_No = s.Item_No, spec2 = s.SPEC2, spec18 = s.SPEC18, spec50 = s.SPEC50, fr.Qty, f.OurModel }).FirstOrDefault();
            var query = (from s in context.H1066 where s.Item_No==itemNo select s).FirstOrDefault();
            int qty = (int)(from fr in context.H1040 where fr.Item_No == itemNo select fr.Qty).FirstOrDefault();
            if (qty==0)
            {
                ViewData["qty"] = "暂时缺货";
            }
            else
            {
                ViewData["qty"] = qty;

            }
            var ourModel = (from f in context.H1065 where f.Item_No == itemNo select f.OurModel).FirstOrDefault();
            ViewData["ourModel"] = ourModel;
            return View(query);
        }
    }
}
