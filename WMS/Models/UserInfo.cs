using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class UserInfo//用户信息表
    {
        [Key]
        public int Id { get; set; }//ID
        public string Name { get; set; }//用户名称
        public string Pwd { get; set; }//密码
        public int RoleId { get; set; }//角色
        public string RoleName { get; set; }//角色名称
        public string Tel { get; set; }//电话
        public string Headportrait { get; set; }//头像
        public int WarehouseId { get; set; }//仓库外键
        public string WarehouseName { get; set; }//仓库名称
    }
}
