using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class RegionList//仓库位置
    {
        [Key]
        public int Id { get; set; }//分区
        public string RegionListName { get; set; }//区名
        public int WarehouseId { get; set; }//仓库外键
        public string WarehouseName { get; set; }//仓库名称
    }
}
