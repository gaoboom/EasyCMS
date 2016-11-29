﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.ViewModels;
using BasicModel;
using BLL;
using BLL.UserBLL;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(VmUserLogin u)
        {
            if (ModelState.IsValid)
            {
                BasicModel.User userLogin = new BasicModel.User();
                UserCommonFunc ucf = new UserCommonFunc();
                
                userLogin.Account = u.Account;
                userLogin.Password = u.Password;

                Response r= ucf.UserLogin(userLogin);

                if(r.Code==1)//验证成功
                {
                    Session["User"] = r.ResObj;
                    return RedirectToAction("Index", "Home");
                }
                else//验证失败
                {
                    ModelState.AddModelError("Password", r.Message);
                    return View(u);
                }
            }
            else
            {
                return View(u);
            }
        }
    }
}