using Orchard;
using Orchard.Data.Migration;
using Orchard.Environment;
using Orchard.Environment.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kendo.Web
{
    [OrchardFeature("PD.Kendo")]
    public class Migrations : DataMigrationImpl
    {
        private readonly Work<WorkContext> workContext;

        public Migrations(Work<WorkContext> workContext)
        {
            this.workContext = workContext;
        }

        public int Create()
        {
            schemaBuilder.CreateTable(tableRecord.Name, table =>
                table
                    .ContentPartRecord()
                    .Column<string>("DefaultTheme"));

            var part = value.CurrentSite.As<KendoSiteSettingsPart>();
            part.DefaultTheme = "Default";

            return 1;
        }


    }
}