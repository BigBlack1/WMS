using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class PeopleRole//角色表
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }//角色名称
    }
}
