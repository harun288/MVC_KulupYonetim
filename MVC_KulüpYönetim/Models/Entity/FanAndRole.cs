using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_KulüpYönetim.Models.Entity
{
    public class FanAndRole
    {
        public int FanId { get; set; }
        public int RoleId { get; set; }
        public virtual Fan Fan { get; set; }
        public virtual Role Role { get; set; }
    }
}