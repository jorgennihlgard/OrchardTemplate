

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
            ContentDefinitionManager.AlterTypeDefinition("CoffeCup", builder =>
             builder
									
			.WithPart("CommonPart")
			
            						
			.WithPart("TitlePart")
			
            						
			.WithPart("AutoRoutePart")
			
            						
			.WithPart("BodyPart")
			
            
		.Creatable()
		.Draftable()
		.Listable()
	);
            

	SchemaBuilder.CreateTable("TableName", table =>
    table
		
		.Column<int>("Id")	.Column<int>("YearReleased")	.Column<string>("TagLine")	.Column<string>("Keywords"));




            return 1;
	
        }
    }
}