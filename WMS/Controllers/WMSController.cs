using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WMS.Controllers
{
    public class WMSController : Controller
    {
        // GET: WMS
        /// <summary>
        /// 获取资产调度记录视图
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAssetAllocation()
        {
            return View();
        }
        /// <summary>
        /// 获取出库记录视图
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetDelivery()
        {
            return View();
        }
        /// <summary>
        /// 获取入库记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetInbound()
        {
            return View();
        }
        /// <summary>
        /// 获取盘点记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetMakeAnInventoryOf()
        {
            return View();
        }
    }
}