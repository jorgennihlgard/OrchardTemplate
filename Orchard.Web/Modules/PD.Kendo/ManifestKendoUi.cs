using System;
using System.Collections.Generic;
using System.Linq;
using PD.Kendo;
using Orchard.UI.Resources;
using PD.Kendo.Services.Site;

namespace PD.Kendo
{
    public class ManifestKendoUi : IResourceManifestProvider
    {
        private readonly IKendoSiteSettingsService kendoThemeService;

        public ManifestKendoUi(IKendoSiteSettingsService kendoThemeService) 
        {
            this.kendoThemeService = kendoThemeService;
        }

        /// <summary>
        /// Scripts: 
        /// kendo.web; kendo.data; kendo.mobile; kendo.aspnetmvc;
        /// 
        /// Styles:
        /// kendo.default; kendo.black; kendo.blueopal; kendo.metro; kendo.silver; kendo.moonlight; kendo.metroBlack; kendo.bootstrap;
        /// Custom Styles:
        /// Add kendo theme to the module / orchard theme folder as: {version}/custom/ - its already defined and expected. Script name needs to be the same as folder name ie {kendo.custom.min.css}
        /// 
        /// Cultures:
        /// kendo.culture.en-AU; kendo.culture.en-GB; kendo.culture.de-De
        /// </summary>
        /// <param name="builder"></param>
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            string currentVerison = "2018.1.221";

            string[] versions = new[] 
            {
                "2018.1.221",
                //for now on i will be including the two most recent public versions. Adding any previous versions (or internal builds) should be easy if needed. 
                "2016.3.1028",
                //removed to save some space for module upload
                //copy back the folders if needed 
            };

            this.DefineScripts(manifest, keyPrefix, currentVerison, versions);
            this.DefineStyles(manifest, keyPrefix, currentVerison, versions);

            //only needed if you are using Kendo's MVC Extensions.
            this.DefineAspNetMvc(manifest, keyPrefix, currentVerison, versions);
        }

        /// <summary>
        /// Defines the scripts.
        /// </summary>
        /// <param name="manifest">The manifest.</param>
        /// <param name="key">The key.</param>
        /// <param name="currentVersion">The current version.</param>
        /// <param name="previousVersions">The previous versions.</param>
        public void DefineScripts(ResourceManifest manifest, string key, string currentVersion, params string[] previousVersions)
        {
            var versions = previousVersions.Concat(new[] { currentVersion });
            string webKey = string.Format("{0}.{1}", key, "web");
            string webOnlyKey = string.Format("{0}.{1}", key, "web.only");

            //string all = string.Format("{0}.{1}", key, "all");
            string webData = string.Format("{0}.{1}", key, "webdata");
            string dataVizKey = string.Format("{0}.{1}", key, "data");
            string mobileKey = string.Format("{0}.{1}", key, "mobile");
            string timezonesKey = string.Format("{0}.{1}", key, "timezones");
            string aspnetmvcKey = string.Format("{0}.{1}", key, "aspnetmvc");

            string allKey = string.Format("{0}.{1}", key, "all");

            //string orchard = string.Format("{0}.{1}", key, "orchard");

            foreach (var ver in versions)
            {

                manifest.DefineScript("kendo.angular")
                    .SetUrl(VersionPath(ver, "angular.min.js"))
                    .SetVersion(ver);

                manifest.DefineScript("kendo.jquery")
                    .SetUrl(VersionPath(ver, "jquery.min.js"))
                    .SetVersion(ver);

                manifest.DefineScript("kendo.jszip")
                    .SetUrl(VersionPath(ver, "jszip.min.js"))
                    .SetVersion(ver);

                //manifest.DefineScript("kendo.all")
                //    .SetUrl(VersionPath(ver, "kendo.all.js"))
                //    .SetVersion(ver);

                manifest.DefineScript("kendo.web")
                    .SetUrl(VersionPath(ver, "kendo.web.min.js"))
                    .SetVersion(ver);

                manifest.DefineScript(webOnlyKey)
                    .SetDependencies("jQuery")
                    .SetUrl(VersionPath(ver, "kendo.web.min.js"))
                    .SetAttribute("kendo-version", ver)
                    //.SetCdn("http://cdn.kendostatic.com/2012.2.913/js/kendo.web.min.js")
                    .SetVersion(ver);

                manifest.DefineScript(webKey)
                    .SetDependencies("jQuery", webOnlyKey)
                    .SetUrl("custom/OrchardMvc.min.js", "custom/OrchardMvc.js")
                    .SetVersion(ver);
                
                
                manifest.DefineScript(dataVizKey)
                    .SetUrl(VersionPath(ver, "kendo.dataviz.min.js"))
                    .SetVersion(ver);

                manifest.DefineScript(mobileKey)
                    .SetDependencies("jQuery")
                    .SetUrl(VersionPath(ver, "kendo.mobile.min.js"))
                    .SetVersion(ver);

                manifest.DefineScript(webData)
                    .SetUrl(VersionPath(ver, "kendo.webdata.min.js")).SetAttribute("kendo-version", ver)
                    .SetDependencies("jQuery")
                    .SetVersion(ver);

                manifest.DefineScript(timezonesKey)
                    .SetUrl(VersionPath(ver, "kendo.timezones.min.js"))
                    .SetVersion(ver);

                manifest.DefineScript(aspnetmvcKey)
                    .SetUrl(VersionPath(ver, "kendo.aspnetmvc.min.js"))
                    .SetVersion(ver);

                manifest.DefineScript(allKey)
                    .SetUrl(VersionPath(ver, "kendo.all.min.js"))
                    .SetVersion(ver);


                this.DefineCultureSet(manifest, ver);
            }

            //manifest.DefineScript("kendo.datasource")
            //    .SetDependencies("kendo.web")
            //    .SetUrl("custom/datasource.js");
        }

        public void DefineCultureSet(ResourceManifest manifest, string version)
        {
            string cultureKey = string.Format(KeyFormat, "kendo.culture", "site");
            string messagesKey = string.Format(KeyFormat, "kendo.messages", "site");

            string siteCultureFilePath = string.Format("cultures/kendo.culture.{0}.min.js", this.kendoThemeService.SiteCulture());
            string siteMessagesFilePath = string.Format("messages/kendo.messages.{0}.min.js", this.kendoThemeService.SiteCulture());

            manifest.DefineScript(cultureKey)
                .SetUrl(VersionPath(version, siteCultureFilePath))
                .SetDependencies(keyPrefix)
                .SetVersion(version);

            manifest.DefineScript(messagesKey)
             .SetUrl(VersionPath(version, siteMessagesFilePath))
             .SetDependencies(keyPrefix)
             .SetVersion(version);

            foreach (var culture in cultureSets) 
            {
                string key = string.Format(KeyFormat, "kendo.culture", culture);
                string filePath = string.Format("cultures/{0}.min.js", key);

                manifest.DefineScript(key)
                    .SetUrl(VersionPath(version, filePath))
                    .SetDependencies(keyPrefix)
                    .SetVersion(version);
            }

            foreach (var culture in cultureSets)
            {
                string key = string.Format(KeyFormat, "kendo.messages", culture);
                string filePath = string.Format("messages/{0}.min.js", key);

                manifest.DefineScript(key)
                    .SetUrl(VersionPath(version, filePath))
                    .SetDependencies(keyPrefix)
                    .SetVersion(version);
            }

        }

        /// <summary>
        /// Defines the styles.
        /// </summary>
        /// <param name="manifest">The manifest.</param>
        /// <param name="key">The key.</param>
        /// <param name="currentVersion">The current version.</param>
        /// <param name="previousVersions">The previous versions.</param>
        public void DefineStyles(ResourceManifest manifest, string key, string currentVersion, params string[] previousVersions) 
        {
            var versions = new List<string>(previousVersions) { currentVersion };

            Func<string, string, string> format = (a,b) => {
                return string.Format(KeyFormat, a, b);
            };

            string commonDependency = format(key, "common");
            string siteTheme = kendoThemeService.SiteTheme();
            string siteThemePath = string.Format("kendo.{0}.min.css", string.IsNullOrWhiteSpace(siteTheme) ? "default" : siteTheme);

            foreach (var version in versions) 
            {
                manifest.DefineStyle("jQueryTimeEntry").SetUrl("jquery.timeentry.css").SetVersion("2.0.1");

                manifest
                    .DefineStyle(format(key, "commonmaterial"))
                    .SetUrl(VersionPath(version, "kendo.common-material.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "material"))
                    .SetUrl(VersionPath(version, "kendo.material.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "commonbootstrap"))
                    .SetUrl(VersionPath(version, "kendo.common-bootstrap.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "common"))
                    .SetUrl(VersionPath(version, "kendo.common.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "default"))
                    .SetUrl(VersionPath(version, "kendo.default.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "defaultmobile"))
                    .SetUrl(VersionPath(version, "kendo.default.mobile.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "web"))
                    .SetUrl(VersionPath(version, "kendo.web.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "mobileall"))
                    .SetUrl(VersionPath(version, "kendo.mobile.all.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "dataviz"))
                    .SetUrl(VersionPath(version, "kendo.dataviz.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "bootstrap"))
                    .SetUrl(VersionPath(version, "kendo.bootstrap.min.css"))
                    .SetVersion(version);

                manifest
                    .DefineStyle(format(key, "datavizbootstrap"))
                    .SetUrl(VersionPath(version, "kendo.dataviz.bootstrap.min.css"))
                    .SetVersion(version);

                foreach (var themeName in Definitions.Themes) 
                {
                    manifest
                    .DefineStyle(format(key, themeName))
                    .SetDependencies(commonDependency)
                    .SetUrl(VersionPath(version, string.Format("kendo.{0}.min.css", themeName)))
                    .SetVersion(version);
                }

                manifest
                    .DefineStyle(format(key, "site"))
                    .SetDependencies(commonDependency)
                    .SetUrl(VersionPath(version, siteThemePath))
                    .SetVersion(version);
                    //.SetDependencies(kendoThemeService.SiteTheme())
            }
        }

        public void DefineAspNetMvc(ResourceManifest manifest, string kety, string currentVersion, params string[] previousVersions) 
        {
            var versions = new List<string>(previousVersions) { currentVersion };

            foreach(var version in versions)
            {
                manifest.DefineScript("kendo.aspnetmvc")
                    .SetUrl(VersionPath(version, "kendo.aspnetmvc.min.js"))
                    .SetDependencies(keyPrefix);
            }
        }

        /// <summary>
        /// Add new cultures here. 
        /// </summary>
        private static readonly string[] cultureSets = new string[]
        {
            "en-AU",
            "en-GB",
            "de-De",
            "sv-SE"
        };

        private static readonly string keyPrefix = "kendo";
        private static string VersionPath(string version, string file)
        {
            return string.Format("{0}/{1}", version, file);
        }

        /// <summary>
        /// Gets the key format.
        /// </summary>
        /// <value>The key format.</value>
        private static string KeyFormat
        {
            get
            {
                return "{0}.{1}";
            }
        }


    }
}
