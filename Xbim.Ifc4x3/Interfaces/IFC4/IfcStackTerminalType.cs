// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.PlumbingFireProtectionDomain
{
	public partial class @IfcStackTerminalType : IIfcStackTerminalType
	{

		[CrossSchemaAttribute(typeof(IIfcStackTerminalType), 10)]
		Ifc4.Interfaces.IfcStackTerminalTypeEnum IIfcStackTerminalType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcStackTerminalTypeEnum.BIRDCAGE:
						return Ifc4.Interfaces.IfcStackTerminalTypeEnum.BIRDCAGE;
					case IfcStackTerminalTypeEnum.COWL:
						return Ifc4.Interfaces.IfcStackTerminalTypeEnum.COWL;
					case IfcStackTerminalTypeEnum.RAINWATERHOPPER:
						return Ifc4.Interfaces.IfcStackTerminalTypeEnum.RAINWATERHOPPER;
					case IfcStackTerminalTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcStackTerminalTypeEnum.USERDEFINED;
					case IfcStackTerminalTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStackTerminalTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcStackTerminalTypeEnum.BIRDCAGE:
						PredefinedType = IfcStackTerminalTypeEnum.BIRDCAGE;
						return;
					case Ifc4.Interfaces.IfcStackTerminalTypeEnum.COWL:
						PredefinedType = IfcStackTerminalTypeEnum.COWL;
						return;
					case Ifc4.Interfaces.IfcStackTerminalTypeEnum.RAINWATERHOPPER:
						PredefinedType = IfcStackTerminalTypeEnum.RAINWATERHOPPER;
						return;
					case Ifc4.Interfaces.IfcStackTerminalTypeEnum.USERDEFINED:
						PredefinedType = IfcStackTerminalTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcStackTerminalTypeEnum.NOTDEFINED:
						PredefinedType = IfcStackTerminalTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}