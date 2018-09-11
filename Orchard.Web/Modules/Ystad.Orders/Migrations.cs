


using Orchard.Core.Settings.Metadata;
using Orchard.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using System;

namespace Ystad.Orders
{
    public class Migrations : DataMigrationImpl
    {
        
        
	
		
	

public int Create()
        {
            ContentDefinitionManager.AlterTypeDefinition("Order", builder =>
             builder
									
			.WithPart("CommonPart")
			
            						
			.WithPart("TitlePart")
			
            						
			.WithPart("AutoRoutePart")
			
            						
			.WithPart("BodyPart")
			
            
		.Creatable()
		.Draftable()
		.Listable()
	);
            

	SchemaBuilder.CreateTable("OrderPartRecord", table =>
    table.ContentPartRecord()
		
								.Column<string>("Equipment")
								.Column<string>("Location")
								.Column<string>("Department")
								.Column<string>("MaintenanceGroup")
								.Column<string>("MaintenanceType")
								.Column<string>("Customer")
								.Column<string>("CustomerTelephone")
								.Column<string>("CustomerContactPerson")
																);

ContentDefinitionManager.AlterTypeDefinition("Order", builder =>
builder.WithPart("OrderPart"));
            return 1;
	
        }
public int UpdateFrom1(){


	
		
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						SchemaBuilder.AlterTable("OrderPartRecord", table =>
	table.AddColumn<string>("RegisteredBy"));
									
							
						SchemaBuilder.AlterTable("OrderPartRecord", table =>
	table.AddColumn<string>("PerformedBy"));
									
							
						SchemaBuilder.AlterTable("OrderPartRecord", table =>
	table.AddColumn<string>("Priority"));
									
							
						SchemaBuilder.AlterTable("OrderPartRecord", table =>
	table.AddColumn<string>("Protocol"));
									
							
				           
            return 2;
	
			}
public int UpdateFrom2(){


	
		
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
				           
            return 3;
	
			}
		}
}
       
