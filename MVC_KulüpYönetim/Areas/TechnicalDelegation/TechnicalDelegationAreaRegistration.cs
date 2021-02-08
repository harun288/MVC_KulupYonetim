using System.Web.Mvc;

namespace MVC_KulüpYönetim.Areas.TechnicalDelegation
{
    public class TechnicalDelegationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TechnicalDelegation";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TechnicalDelegation_default",
                "TechnicalDelegation/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}