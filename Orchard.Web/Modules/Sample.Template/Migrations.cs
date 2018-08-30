

using Orchard.Core.Settings.Metadata;
using Orchard.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using System;

namespace Sample.Template 
{
    public class Migrations : DataMigrationImpl
    {
                
		

        public int Create()
        {
            ContentDefinitionManager.AlterTypeDefinition("KaffeKopp", builder =>
             builder
									
			.WithPart("CommonPart")
			
            						
			.WithPart("TitlePart")
			
            						
			.WithPart("AutoRoutePart")
			
            						
			.WithPart("BodyPart")
			
            
		.Creatable()
		.Draftable()
		.Listable()
	);
            

	SchemaBuilder.CreateTable("KaffeKoppPartRecord", table =>
    table.ContentPartRecord()
		
		.Column<int>("Deciliter")
		.Column<string>("Handtag")
		.Column<string>("Färg")
		.Column<string>("Namn")
);

ContentDefinitionManager.AlterTypeDefinition("KaffeKopp", builder =>
builder.WithPart("KaffeKoppPart"));
            return 1;
	
        }

    }
}
