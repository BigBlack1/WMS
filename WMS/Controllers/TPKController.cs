﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WMS.Models;
namespace WMS.Controllers
{
    public class TPKController : Controller
    {
        // GET: TPK
        public ActionResult GetWareHouseMvc()//获取仓库
        {
           
            return View();

        }
      
        public ActionResult GetProductMvc()//获取产品
        {
            return View();
        }
        public ActionResult Map(string name)//地图
        {
            Session["GetMap"] = name;
            return View();
        }
       public ActionResult GetRegionListViewMvc()//区分表
        {
            return View();
        }



    }
}