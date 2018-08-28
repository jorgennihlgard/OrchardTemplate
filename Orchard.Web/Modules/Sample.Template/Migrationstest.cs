using Newtonsoft.Json.Linq;
using Orchard.Core.Settings.Metadata;
using Orchard.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using System;

using System.IO;
using Newtonsoft.Json;

namespace Sample.Template
{
    //public class Migrationstest : DataMigrationImpl
    //{
    //    JObject jsonFile = JObject.Parse(File.ReadAllText("C:/Users/sattline/Desktop/Template Project/OrchardTemplate/Orchard-dev/src/Orchard.Web/Modules/Sample.Template/Migrationfile.json"));
        
    //    public int Create()
    //    {
    //        ContentDefinitionManager.AlterTypeDefinition(jsonFile["ContentTypeName"].ToString(), builder =>
           
    //         builder
            
    //         .WithPart(jsonFile["WithPart"][0].ToString())
    //        .WithPart(jsonFile["WithPart"][1].ToString())
    //        .WithPart(jsonFile["WithPart"][2].ToString()));
            
    //        return 1;
    //    }
    //}
}