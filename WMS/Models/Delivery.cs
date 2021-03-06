﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Delivery//出库记录表
    {
        [Key]
        public int Id { get; set; }//出库Id
        public int Quantity { get; set; }//出库数量
        public DateTime StartTime { get; set; }//出库时间
        public int RegionListId { get; set; }//仓库位置外键
        public string Contract { get; set; }//出库清单
        public int ProductId { get; set; }//产品外键
        public string ProductName { get; set; }//产品名称
        public string Brand { get; set; }//产品品牌
        public string RegionListName { get; set; }//区名
        public string WarehouseName { get; set; }//仓库名称
        public string Location { get; set; }//仓库地址
        public string Remark { get; set; }//仓库备注
    }
}
