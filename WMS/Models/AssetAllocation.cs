using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class AssetAllocation//资产调度表
    {
        [Key]
        public int Id { get; set; }//调度记录Id
        public int Shipments { get; set; }//发货仓A
        public int Consignee { get; set; }//收获仓B
        public int ProductId { get; set; }//产品外键
        public int Shipping { get; set; }//运输数量
        public DateTime StartTime { get; set; }//开始时间
        public DateTime EndTime { get; set; }//结束时间
        public string Receipt { get; set; }//收据

        public string ProductName { get; set; }//产品名称
        public string WarehouseName1 { get; set; }//仓库名称
        public string WarehouseName2{ get; set; }//仓库名称
    }
}