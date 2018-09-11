using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;
using System;

namespace PD.Kendo.Models
{
    public class KendoSiteSettingsPart : ContentPart
    {
        /// <summary>
        /// Gets or sets the default theme.
        /// </summary>
        /// <value>The default theme.</value>

        public string DefaultTheme
        {
            get { return this.Retrieve(x => x.DefaultTheme); }
            set { this.Store(x => x.DefaultTheme, value); }
        }

        public string Culture
        {
            get { return this.Retrieve(x => x.Culture, defaultValue: ""); }
            set { this.Store(x => x.Culture, value); }
        }
    }
}

