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

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.SharedComponentElements
{
	public partial class @IfcMechanicalFastenerType : IIfcMechanicalFastenerType
	{

		[CrossSchemaAttribute(typeof(IIfcMechanicalFastenerType), 10)]
		Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum IIfcMechanicalFastenerType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcMechanicalFastenerTypeEnum.ANCHORBOLT:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.ANCHORBOLT;
					case IfcMechanicalFastenerTypeEnum.BOLT:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.BOLT;
					case IfcMechanicalFastenerTypeEnum.CHAIN:
						//## Handle translation of CHAIN member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						//TODO: Handle translation of CHAIN member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcMechanicalFastenerTypeEnum.COUPLER:
						//## Handle translation of COUPLER member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						//TODO: Handle translation of COUPLER member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcMechanicalFastenerTypeEnum.DOWEL:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.DOWEL;
					case IfcMechanicalFastenerTypeEnum.NAIL:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.NAIL;
					case IfcMechanicalFastenerTypeEnum.NAILPLATE:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.NAILPLATE;
					case IfcMechanicalFastenerTypeEnum.RAILFASTENING:
						//## Handle translation of RAILFASTENING member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						//TODO: Handle translation of RAILFASTENING member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcMechanicalFastenerTypeEnum.RAILJOINT:
						//## Handle translation of RAILJOINT member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						//TODO: Handle translation of RAILJOINT member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcMechanicalFastenerTypeEnum.RIVET:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.RIVET;
					case IfcMechanicalFastenerTypeEnum.ROPE:
						//## Handle translation of ROPE member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						//TODO: Handle translation of ROPE member from IfcMechanicalFastenerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcMechanicalFastenerTypeEnum.SCREW:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.SCREW;
					case IfcMechanicalFastenerTypeEnum.SHEARCONNECTOR:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.SHEARCONNECTOR;
					case IfcMechanicalFastenerTypeEnum.STAPLE:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.STAPLE;
					case IfcMechanicalFastenerTypeEnum.STUDSHEARCONNECTOR:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.STUDSHEARCONNECTOR;
					case IfcMechanicalFastenerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.USERDEFINED;
					case IfcMechanicalFastenerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.ANCHORBOLT:
						PredefinedType = IfcMechanicalFastenerTypeEnum.ANCHORBOLT;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.BOLT:
						PredefinedType = IfcMechanicalFastenerTypeEnum.BOLT;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.DOWEL:
						PredefinedType = IfcMechanicalFastenerTypeEnum.DOWEL;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.NAIL:
						PredefinedType = IfcMechanicalFastenerTypeEnum.NAIL;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.NAILPLATE:
						PredefinedType = IfcMechanicalFastenerTypeEnum.NAILPLATE;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.RIVET:
						PredefinedType = IfcMechanicalFastenerTypeEnum.RIVET;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.SCREW:
						PredefinedType = IfcMechanicalFastenerTypeEnum.SCREW;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.SHEARCONNECTOR:
						PredefinedType = IfcMechanicalFastenerTypeEnum.SHEARCONNECTOR;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.STAPLE:
						PredefinedType = IfcMechanicalFastenerTypeEnum.STAPLE;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.STUDSHEARCONNECTOR:
						PredefinedType = IfcMechanicalFastenerTypeEnum.STUDSHEARCONNECTOR;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.USERDEFINED:
						PredefinedType = IfcMechanicalFastenerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum.NOTDEFINED:
						PredefinedType = IfcMechanicalFastenerTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMechanicalFastenerType), 11)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMechanicalFastenerType.NominalDiameter 
		{ 
			get
			{
				if (!NominalDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter.Value);
			} 
			set
			{
				NominalDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMechanicalFastenerType), 12)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMechanicalFastenerType.NominalLength 
		{ 
			get
			{
				if (!NominalLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalLength.Value);
			} 
			set
			{
				NominalLength = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}