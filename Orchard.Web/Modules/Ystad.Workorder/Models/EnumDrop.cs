

namespace Ystad.Workorder.Models
{
 
public enum PartsEnum
{
			None = 0,
		Maintenance = 1 << 0,
		EnviromentControl = 1 << 1,

}
public enum PriorityEnum
{
			Naahh = 0,
		Warning = 1,
		Danger = 2,

}
public enum ProtocolEnum
{
			prot1 = 10,
		prot2 = 20,
		prot3 = 30,

}
}
