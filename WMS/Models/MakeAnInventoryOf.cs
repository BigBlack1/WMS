using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class MakeAnInventoryOf//盘点记录
    {
        [Key]
        public int Id { get; set; }//记录Id
        public string InventoryName { get; set; }//盘点名称
        public DateTime InventoryTime { get; set; }//盘点时间
        public int WarehouseId { get; set; }//盘点仓库
        public string Status { get; set; }//盘点结果
        public string Remark { get; set; }//备注
        public string WarehouseName { get; set; }//仓库名称
    }
}