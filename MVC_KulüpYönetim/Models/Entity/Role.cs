using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_KulüpYönetim.Models.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual List<FanAndRole>FanAndRoles { get; set; }
    }
}