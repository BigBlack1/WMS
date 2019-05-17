using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using Newtonsoft.Json;
using System.IO;

namespace WMS.Controllers
{
    public class YYLController : Controller
    {
        // GET: YYL
        public ActionResult RuKu()
        {
            return View();
        }
        public ActionResult ChuKu()
        {
            return View();
        }
        public ActionResult AddRuKu()
        {
            return View();
        }
        public FileResult ExportStu2()
        {
            
            string json = HttpClientr.Apiresult("get", "GetRu");
            List<dynamic> list = JsonConvert.DeserializeObject<List<dynamic>>(json);
            
            //string schoolname = "401";
            //创建Excel文件的对象
           
            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            //添加一个sheet
            NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("Sheet1");
            //获取list数据
            //List<TB_STUDENTINFOModel> listRainInfo = m_BLL.GetSchoolListAATQ(schoolname);
            //给sheet1添加第一行的头部标题
            NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("产品编号");
            row1.CreateCell(1).SetCellValue("产品名称");
            row1.CreateCell(2).SetCellValue("产品品牌");
            row1.CreateCell(3).SetCellValue("数量");
            row1.CreateCell(4).SetCellValue("产品分类");
            row1.CreateCell(5).SetCellValue("入库仓库");
            row1.CreateCell(6).SetCellValue("入库时间");
            //将数据逐步写入sheet1各个行
            for (int i = 0; i < list.Count; i++)
            {
                NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                rowtemp.CreateCell(0).SetCellValue(list[i].Id.ToString());
                rowtemp.CreateCell(1).SetCellValue(list[i].ProductName.ToString());
                rowtemp.CreateCell(2).SetCellValue(list[i].Brand.ToString());
                rowtemp.CreateCell(3).SetCellValue(list[i].Quantity.ToString());
                rowtemp.CreateCell(4).SetCellValue(list[i].ProductTypeName.ToString());
                rowtemp.CreateCell(5).SetCellValue(list[i].WarehouseName.ToString());
                rowtemp.CreateCell(6).SetCellValue(list[i].StartTime.ToString());
            }
            // 写入到客户端 
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            ms.Seek(0, SeekOrigin.Begin);
            return File(ms, "application/vnd.ms-excel", "入库数据.xls");
        }
        public FileResult ExportStu1()
        {

            string json = HttpClientr.Apiresult("get", "GetChu");
            List<dynamic> list = JsonConvert.DeserializeObject<List<dynamic>>(json);

            //string schoolname = "401";
            //创建Excel文件的对象

            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            //添加一个sheet
            NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("Sheet1");
            //获取list数据
            //List<TB_STUDENTINFOModel> listRainInfo = m_BLL.GetSchoolListAATQ(schoolname);
            //给sheet1添加第一行的头部标题
            NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("产品编号");
            row1.CreateCell(1).SetCellValue("产品名称");
            row1.CreateCell(2).SetCellValue("产品品牌");
            row1.CreateCell(3).SetCellValue("数量");
            row1.CreateCell(4).SetCellValue("产品分类");
            row1.CreateCell(5).SetCellValue("出库仓库");
            row1.CreateCell(6).SetCellValue("出库时间");
            //将数据逐步写入sheet1各个行
            for (int i = 0; i < list.Count; i++)
            {
                NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                rowtemp.CreateCell(0).SetCellValue(list[i].Id.ToString());
                rowtemp.CreateCell(1).SetCellValue(list[i].ProductName.ToString());
                rowtemp.CreateCell(2).SetCellValue(list[i].Brand.ToString());
                rowtemp.CreateCell(3).SetCellValue(list[i].Quantity.ToString());
                rowtemp.CreateCell(4).SetCellValue(list[i].ProductTypeName.ToString());
                rowtemp.CreateCell(5).SetCellValue(list[i].WarehouseName.ToString());
                rowtemp.CreateCell(6).SetCellValue(list[i].StartTime.ToString());
            }
            // 写入到客户端 
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            ms.Seek(0, SeekOrigin.Begin);
            return File(ms, "application/vnd.ms-excel", "入库数据.xls");
        }






    }
}