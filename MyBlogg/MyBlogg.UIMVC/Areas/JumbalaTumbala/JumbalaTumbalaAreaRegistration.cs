using System.Web.Mvc;

namespace MyBlogg.UIMVC.Areas.JumbalaTumbala
{
    public class JumbalaTumbalaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "JumbalaTumbala";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "JumbalaTumbala_default",
                "JumbalaTumbala/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
