using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ProductType//产品类别表
    {
        [Key]
        public int Id { get; set; }//产品类别
        public int ProductTypeName { get; set; }//产品类别名
    }
}
