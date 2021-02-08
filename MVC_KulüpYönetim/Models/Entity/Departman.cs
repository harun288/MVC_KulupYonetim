using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_KulüpYönetim.Models.Entity
{
    public class Departman
    {
        public int DepartmanId { get; set; }
        public string Name { get; set; }
        public virtual List<Fan>Fans  { get; set; }
    }
}