using System;
using PD.Kendo.Models;
using Orchard;
using Orchard.ContentManagement;
using PD.Kendo.Models;

namespace PD.Kendo.Services.Site
{
    public class KendoSiteSettingsService : IKendoSiteSettingsService 
    {
        private readonly IOrchardServices services;

        public KendoSiteSettingsService(IOrchardServices services) 
        {
            this.services = services;
        }

        /// <summary>
        /// Sites the culture.
        /// </summary>
        /// <returns></returns>
        public string SiteCulture()
        {
            return this.services.WorkContext.CurrentCulture;
        }

        public string SiteTheme()
        {
            var site = this.services.WorkContext.CurrentSite;
            if (!site.Has<KendoSiteSettingsPart>()) 
            {
                return "kendo.default";
            }

            var settings = site.As<KendoSiteSettingsPart>();

            return settings.DefaultTheme;
        }
    }
}