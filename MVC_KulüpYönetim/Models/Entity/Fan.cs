using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_KulüpYönetim.Models.Entity
{
    public class Fan
    {
        public int Id { get; set; }
        public string FanName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int DepartmanId { get; set; }
        public virtual Departman Departman { get; set; }
        public virtual List<FanAndRole>FanAndRoles { get; set; }

    }
}