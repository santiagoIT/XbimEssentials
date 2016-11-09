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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcCooledBeamType : IIfcCooledBeamType
	{

		[CrossSchemaAttribute(typeof(IIfcCooledBeamType), 10)]
		Ifc4.Interfaces.IfcCooledBeamTypeEnum IIfcCooledBeamType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCooledBeamTypeEnum.ACTIVE:
						return Ifc4.Interfaces.IfcCooledBeamTypeEnum.ACTIVE;
					case IfcCooledBeamTypeEnum.PASSIVE:
						return Ifc4.Interfaces.IfcCooledBeamTypeEnum.PASSIVE;
					case IfcCooledBeamTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCooledBeamTypeEnum.USERDEFINED;
					case IfcCooledBeamTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCooledBeamTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcCooledBeamTypeEnum.ACTIVE:
						PredefinedType = IfcCooledBeamTypeEnum.ACTIVE;
						return;
					case Ifc4.Interfaces.IfcCooledBeamTypeEnum.PASSIVE:
						PredefinedType = IfcCooledBeamTypeEnum.PASSIVE;
						return;
					case Ifc4.Interfaces.IfcCooledBeamTypeEnum.USERDEFINED:
						PredefinedType = IfcCooledBeamTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCooledBeamTypeEnum.NOTDEFINED:
						PredefinedType = IfcCooledBeamTypeEnum.NOTDEFINED;
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