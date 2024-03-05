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
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcGrid : IIfcGrid
	{

		[CrossSchemaAttribute(typeof(IIfcGrid), 8)]
		IItemSet<IIfcGridAxis> IIfcGrid.UAxes 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<GeometricConstraintResource.IfcGridAxis, IIfcGridAxis>(UAxes);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcGrid), 9)]
		IItemSet<IIfcGridAxis> IIfcGrid.VAxes 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<GeometricConstraintResource.IfcGridAxis, IIfcGridAxis>(VAxes);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcGrid), 10)]
		IItemSet<IIfcGridAxis> IIfcGrid.WAxes 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<GeometricConstraintResource.IfcGridAxis, IIfcGridAxis>(WAxes);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcGrid), 11)]
		Ifc4.Interfaces.IfcGridTypeEnum? IIfcGrid.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcGridTypeEnum.IRREGULAR:
						return Ifc4.Interfaces.IfcGridTypeEnum.IRREGULAR;
					case IfcGridTypeEnum.RADIAL:
						return Ifc4.Interfaces.IfcGridTypeEnum.RADIAL;
					case IfcGridTypeEnum.RECTANGULAR:
						return Ifc4.Interfaces.IfcGridTypeEnum.RECTANGULAR;
					case IfcGridTypeEnum.TRIANGULAR:
						return Ifc4.Interfaces.IfcGridTypeEnum.TRIANGULAR;
					case IfcGridTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcGridTypeEnum.USERDEFINED;
					case IfcGridTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcGridTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcGridTypeEnum.RECTANGULAR:
						PredefinedType = IfcGridTypeEnum.RECTANGULAR;
						return;
					case Ifc4.Interfaces.IfcGridTypeEnum.RADIAL:
						PredefinedType = IfcGridTypeEnum.RADIAL;
						return;
					case Ifc4.Interfaces.IfcGridTypeEnum.TRIANGULAR:
						PredefinedType = IfcGridTypeEnum.TRIANGULAR;
						return;
					case Ifc4.Interfaces.IfcGridTypeEnum.IRREGULAR:
						PredefinedType = IfcGridTypeEnum.IRREGULAR;
						return;
					case Ifc4.Interfaces.IfcGridTypeEnum.USERDEFINED:
						PredefinedType = IfcGridTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcGridTypeEnum.NOTDEFINED:
						PredefinedType = IfcGridTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcGrid.ContainedInStructure 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this), "RelatedElements", this);
			} 
		}
	//## Custom code
	//##
	}
}