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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcCovering : IIfcCovering
	{

		[CrossSchemaAttribute(typeof(IIfcCovering), 9)]
		Ifc4.Interfaces.IfcCoveringTypeEnum? IIfcCovering.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCoveringTypeEnum.CEILING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.CEILING;
					case IfcCoveringTypeEnum.CLADDING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.CLADDING;
					case IfcCoveringTypeEnum.COPING:
						//## Handle translation of COPING member from IfcCoveringTypeEnum in property PredefinedType
						//TODO: Handle translation of COPING member from IfcCoveringTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCoveringTypeEnum.FLOORING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.FLOORING;
					case IfcCoveringTypeEnum.INSULATION:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.INSULATION;
					case IfcCoveringTypeEnum.MEMBRANE:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.MEMBRANE;
					case IfcCoveringTypeEnum.MOLDING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.MOLDING;
					case IfcCoveringTypeEnum.ROOFING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.ROOFING;
					case IfcCoveringTypeEnum.SKIRTINGBOARD:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.SKIRTINGBOARD;
					case IfcCoveringTypeEnum.SLEEVING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.SLEEVING;
					case IfcCoveringTypeEnum.TOPPING:
						//## Handle translation of TOPPING member from IfcCoveringTypeEnum in property PredefinedType
						//TODO: Handle translation of TOPPING member from IfcCoveringTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCoveringTypeEnum.WRAPPING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.WRAPPING;
					case IfcCoveringTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCoveringTypeEnum.USERDEFINED;
					case IfcCoveringTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcCoveringTypeEnum.CEILING:
						PredefinedType = IfcCoveringTypeEnum.CEILING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.FLOORING:
						PredefinedType = IfcCoveringTypeEnum.FLOORING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.CLADDING:
						PredefinedType = IfcCoveringTypeEnum.CLADDING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.ROOFING:
						PredefinedType = IfcCoveringTypeEnum.ROOFING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.MOLDING:
						PredefinedType = IfcCoveringTypeEnum.MOLDING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.SKIRTINGBOARD:
						PredefinedType = IfcCoveringTypeEnum.SKIRTINGBOARD;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.INSULATION:
						PredefinedType = IfcCoveringTypeEnum.INSULATION;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.MEMBRANE:
						PredefinedType = IfcCoveringTypeEnum.MEMBRANE;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.SLEEVING:
						PredefinedType = IfcCoveringTypeEnum.SLEEVING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.WRAPPING:
						PredefinedType = IfcCoveringTypeEnum.WRAPPING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.USERDEFINED:
						PredefinedType = IfcCoveringTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.NOTDEFINED:
						PredefinedType = IfcCoveringTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IEnumerable<IIfcRelCoversSpaces> IIfcCovering.CoversSpaces 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelCoversSpaces>(e => e.RelatedCoverings != null &&  e.RelatedCoverings.Contains(this), "RelatedCoverings", this);
			} 
		}
		IEnumerable<IIfcRelCoversBldgElements> IIfcCovering.CoversElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelCoversBldgElements>(e => e.RelatedCoverings != null &&  e.RelatedCoverings.Contains(this), "RelatedCoverings", this);
			} 
		}
	//## Custom code
	//##
	}
}