

using Orchard.Core.Settings.Metadata;
using Orchard.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using System;
using System.Data;
using Orchard.Indexing;
using Orchard.Logging;
using Ystad.Workorder.Models;

namespace Ystad.Workorder
{
    public class Migrations : DataMigrationImpl
    {
                

	

public int Create()
        {
            ContentDefinitionManager.AlterTypeDefinition("WorkOrder", builder =>
             builder
									
			.WithPart("CommonPart")
			
            						
			.WithPart("TitlePart")
			
            						
			.WithPart("AutoRoutePart")
			
            						
			.WithPart("BodyPart")
			
            
		.Creatable()
		.Draftable()
		.Listable()
	);
            

	SchemaBuilder.CreateTable("WorkOrderPartRecord", table =>
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

ContentDefinitionManager.AlterTypeDefinition("WorkOrder", builder =>
builder.WithPart("WorkOrderPart"));
            return 1;
	
        }
public int UpdateFrom1(){


	
		
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						SchemaBuilder.AlterTable("WorkOrderPartRecord", table =>
	table.AddColumn<string>("RegisteredBy"));
									
							
						SchemaBuilder.AlterTable("WorkOrderPartRecord", table =>
	table.AddColumn<string>("PerformedBy"));
									
							
						
							
						
							
						
							
				           
            return 2;
	
			}
public int UpdateFrom2(){


	
		
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						SchemaBuilder.AlterTable("WorkOrderPartRecord", table =>
	table.AddColumn<string>("Priority"));
									
							
						SchemaBuilder.AlterTable("WorkOrderPartRecord", table =>
	table.AddColumn<string>("Protocol"));
									
							
						
							
				           
            return 3;
	
			}
public int UpdateFrom3(){


	
		
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						
							
						SchemaBuilder.AlterTable("WorkOrderPartRecord", table =>
	table.AddColumn<PartsEnum>("MainParts"));
									
							
				           
            return 4;
	
			}
		}
}
       
