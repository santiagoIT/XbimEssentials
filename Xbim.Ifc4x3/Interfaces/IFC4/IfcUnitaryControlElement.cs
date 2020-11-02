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
namespace Xbim.Ifc4x3.BuildingControlsDomain
{
	public partial class @IfcUnitaryControlElement : IIfcUnitaryControlElement
	{

		[CrossSchemaAttribute(typeof(IIfcUnitaryControlElement), 9)]
		Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum? IIfcUnitaryControlElement.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcUnitaryControlElementTypeEnum.ALARMPANEL:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.ALARMPANEL;
					case IfcUnitaryControlElementTypeEnum.CONTROLPANEL:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.CONTROLPANEL;
					case IfcUnitaryControlElementTypeEnum.GASDETECTIONPANEL:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.GASDETECTIONPANEL;
					case IfcUnitaryControlElementTypeEnum.INDICATORPANEL:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.INDICATORPANEL;
					case IfcUnitaryControlElementTypeEnum.MIMICPANEL:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.MIMICPANEL;
					case IfcUnitaryControlElementTypeEnum.HUMIDISTAT:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.HUMIDISTAT;
					case IfcUnitaryControlElementTypeEnum.THERMOSTAT:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.THERMOSTAT;
					case IfcUnitaryControlElementTypeEnum.WEATHERSTATION:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.WEATHERSTATION;
					case IfcUnitaryControlElementTypeEnum.COMBINED:
						//## Handle translation of COMBINED member from IfcUnitaryControlElementTypeEnum in property PredefinedType
						//TODO: Handle translation of COMBINED member from IfcUnitaryControlElementTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcUnitaryControlElementTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.USERDEFINED;
					case IfcUnitaryControlElementTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
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
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.ALARMPANEL:
						PredefinedType = IfcUnitaryControlElementTypeEnum.ALARMPANEL;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.CONTROLPANEL:
						PredefinedType = IfcUnitaryControlElementTypeEnum.CONTROLPANEL;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.GASDETECTIONPANEL:
						PredefinedType = IfcUnitaryControlElementTypeEnum.GASDETECTIONPANEL;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.INDICATORPANEL:
						PredefinedType = IfcUnitaryControlElementTypeEnum.INDICATORPANEL;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.MIMICPANEL:
						PredefinedType = IfcUnitaryControlElementTypeEnum.MIMICPANEL;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.HUMIDISTAT:
						PredefinedType = IfcUnitaryControlElementTypeEnum.HUMIDISTAT;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.THERMOSTAT:
						PredefinedType = IfcUnitaryControlElementTypeEnum.THERMOSTAT;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.WEATHERSTATION:
						PredefinedType = IfcUnitaryControlElementTypeEnum.WEATHERSTATION;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.USERDEFINED:
						PredefinedType = IfcUnitaryControlElementTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcUnitaryControlElementTypeEnum.NOTDEFINED:
						PredefinedType = IfcUnitaryControlElementTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
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