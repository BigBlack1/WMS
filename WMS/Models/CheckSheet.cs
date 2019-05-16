using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
   public class CheckSheet//盘点信息表
    {
        [Key]
        public int Id { get; set; }//盘点信息ID
        public int MakeAnInventoryOfId { get; set; }//盘点记录Id
        public int ProductId { get; set; }//产品外键
        public int InNum { get; set; }//产品入库数量
        public int OutNum { get; set; }//产品出口数量
        public int ProductNum { get; set; }//现有库存

        public string InventoryName { get; set; }//盘点名称
        public DateTime InventoryTime { get; set; }//盘点时间
        public string ProductName { get; set; }//产品名称
    }
}