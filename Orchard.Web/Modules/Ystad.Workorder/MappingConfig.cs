using AutoMapper;
using Ystad.Workorder.Models;
using Ystad.Workorder.Services;
using Ystad.Workorder.ViewModels;

namespace Ystad.Workorder
{
    internal class MappingConfig {

        private readonly IWorkOrderService _workorderservice;

        public MappingConfig(
            IWorkOrderService workorderservice
        )
        {
            _workorderservice = workorderservice;
        }


        public void RegisterMaps() {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<WorkOrderPart, WorkOrderPartsViewModel>()
                    .ForMember(dest => dest.Part,
                        opt => opt.ResolveUsing(Mapper.Map<WorkOrderPart>))
                    .ForMember(dest => dest.MaintenanceGroups,
                        opt => opt.ResolveUsing(s => _workorderservice.GetMaintenanceGroups()))
                    .ForMember(dest => dest.Priorities,
                        opt => opt.ResolveUsing(s => _workorderservice.GetPriorities()))
                    .ForMember(dest => dest.Protocols,
                        opt => opt.ResolveUsing(s => _workorderservice.GetProtocols()));
            });
        }
    }
}

//Model: new <#=jsonFile["ViewModelName"]#>
//{
//<#=jsonFile["ViewModelProperties"]["Name"]#> = part,
//<#for(int i = 0; i < jsonFile["TableColumn"].Count(); i++){#>
//<#if((bool)jsonFile["TableColumn"][i]["Enum"] == true){#>
//<#=jsonFile["TableColumn"][i]["ViewModelName"]#> = <#=jsonFile["EnumInterface"]["PrivateFieldName"]#>.<#=jsonFile["TableColumn"][i]["InterfaceMethod"]#>(),<#}}#>
//},


//*************************
// Mapper.Initialize(cfg => {
//     cfg.CreateMap<OrderPart, OrderPartsViewModel>()
//         .ForMember(dest => dest.Part,
//             opt => opt.ResolveUsing(Mapper.Map<OrderPart>))
//                                        .ForMember(dest => dest.MaintenanceGroups,
//opt => opt.ResolveUsing(s => _orderservice.GetMaintenanceGroups())).ForMember(dest => dest.Priorities,
//opt => opt.ResolveUsing(s => _orderservice.GetPriorities())).ForMember(dest => dest.Protocols,
//opt => opt.ResolveUsing(s => _orderservice.GetProtocols()));
// });
//***********
//OrderPartsViewModel model = Mapper.Map<OrderPart, OrderPartsViewModel>(part);


//********** template******
//Mapper.Initialize(cfg => {
//                cfg.CreateMap<<#=jsonFile["TableName"]#>, <#=jsonFile["ViewModelName"]#>>()
//                    .ForMember(dest => dest.Part,
//                        opt => opt.ResolveUsing(Mapper.Map<<#=jsonFile["TableName"]#>>))
//		<#for(int i = 0; i < jsonFile["TableColumn"].Count(); i++){#>
//		<#if((bool)jsonFile["TableColumn"][i]["Enum"]==true){#>
//           .ForMember(dest => dest.<#=jsonFile["TableColumn"][i]["ViewModelName"]#>,
//           opt => opt.ResolveUsing(s => <#=jsonFile["EnumInterface"]["PrivateFieldName"]#>.<#=jsonFile["TableColumn"][i]["InterfaceMethod"]#>()))<#}}#>;
//            });   

            //<#=jsonFile["ViewModelName"]#> model = Mapper.Map<<#=jsonFile["TableName"]#>, <#=jsonFile["ViewModelName"]#>>(part);
            //Model: model,