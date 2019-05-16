using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Product//产品表
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }//产品名称
        public string Brand { get; set; }//产品品牌
        public int Quantity { get; set; }//产品数量
        public int ProductTypeId { get; set; }//产品类别
        public int RegionListId { get; set; }//仓库编号
        public string Photo { get; set; } //图片
        public string RegionListName { get; set; } //分区名称
        public string WarehouseName { get; set; }//仓库名称
        public string Location { get; set; }//仓库地址
        public string Remark { get; set; }//仓库备注
        public int ProductTypeName { get; set; }//产品类别名
    }
}