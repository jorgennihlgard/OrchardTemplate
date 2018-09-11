using Orchard;

namespace PD.Kendo.Services.Site
{
    public interface IKendoSiteSettingsService : IDependency
    {
        string SiteTheme();
        string SiteCulture();
    }
}