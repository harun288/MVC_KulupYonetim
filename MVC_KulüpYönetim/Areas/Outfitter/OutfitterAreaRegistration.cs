using System.Web.Mvc;

namespace MVC_KulüpYönetim.Areas.Outfitter
{
    public class OutfitterAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Outfitter";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Outfitter_default",
                "Outfitter/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}