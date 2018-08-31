

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
public int UpdateFrom1(){


	
		
							
						
							
						
							
						
							
						SchemaBuilder.AlterTable("KaffeKoppPartRecord", table =>
	table.AddColumn<string>("NewProp1"));
									
							
						SchemaBuilder.AlterTable("KaffeKoppPartRecord", table =>
	table.AddColumn<string>("NewProp2"));
									
							
						
							
						
							
				           
            return 2;
	
			}
public int UpdateFrom2(){


	
		
							
						
							
						
							
						
							
						
							
						
							
						SchemaBuilder.AlterTable("KaffeKoppPartRecord", table =>
	table.AddColumn<string>("NewProp3"));
									
							
						SchemaBuilder.AlterTable("KaffeKoppPartRecord", table =>
	table.AddColumn<string>("NewProp4"));
									
							
				           
            return 3;
	
			}
		}
}
       
