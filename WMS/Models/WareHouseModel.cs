using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMS.Models
{
    public class WareHouseModel
    {
        public class WareHouse//仓库表
        {
          
            public int Id { get; set; }//仓库外键
            public string WarehouseName { get; set; }//仓库名称
            public string Capacity { get; set; }//仓库容量
            public DateTime Establish { get; set; }//建库时间
            public string Location { get; set; }//仓库地址
            public string Remark { get; set; }//仓库备注
        }
    }
}