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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcWindow : IIfcWindow
	{

		[CrossSchemaAttribute(typeof(IIfcWindow), 9)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindow.OverallHeight 
		{ 
			get
			{
				if (!OverallHeight.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallHeight.Value);
			} 
			set
			{
				OverallHeight = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcWindow), 10)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindow.OverallWidth 
		{ 
			get
			{
				if (!OverallWidth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallWidth.Value);
			} 
			set
			{
				OverallWidth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcWindow), 11)]
		Ifc4.Interfaces.IfcWindowTypeEnum? IIfcWindow.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcWindowTypeEnum.WINDOW:
						return Ifc4.Interfaces.IfcWindowTypeEnum.WINDOW;
					case IfcWindowTypeEnum.SKYLIGHT:
						return Ifc4.Interfaces.IfcWindowTypeEnum.SKYLIGHT;
					case IfcWindowTypeEnum.LIGHTDOME:
						return Ifc4.Interfaces.IfcWindowTypeEnum.LIGHTDOME;
					case IfcWindowTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcWindowTypeEnum.USERDEFINED;
					case IfcWindowTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWindowTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcWindowTypeEnum.WINDOW:
						PredefinedType = IfcWindowTypeEnum.WINDOW;
						return;
					case Ifc4.Interfaces.IfcWindowTypeEnum.SKYLIGHT:
						PredefinedType = IfcWindowTypeEnum.SKYLIGHT;
						return;
					case Ifc4.Interfaces.IfcWindowTypeEnum.LIGHTDOME:
						PredefinedType = IfcWindowTypeEnum.LIGHTDOME;
						return;
					case Ifc4.Interfaces.IfcWindowTypeEnum.USERDEFINED:
						PredefinedType = IfcWindowTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcWindowTypeEnum.NOTDEFINED:
						PredefinedType = IfcWindowTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcWindow), 12)]
		Ifc4.Interfaces.IfcWindowTypePartitioningEnum? IIfcWindow.PartitioningType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PartitioningType
				//##
				switch (PartitioningType)
				{
					case IfcWindowTypePartitioningEnum.SINGLE_PANEL:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.SINGLE_PANEL;
					case IfcWindowTypePartitioningEnum.DOUBLE_PANEL_VERTICAL:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.DOUBLE_PANEL_VERTICAL;
					case IfcWindowTypePartitioningEnum.DOUBLE_PANEL_HORIZONTAL:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.DOUBLE_PANEL_HORIZONTAL;
					case IfcWindowTypePartitioningEnum.TRIPLE_PANEL_VERTICAL:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_VERTICAL;
					case IfcWindowTypePartitioningEnum.TRIPLE_PANEL_BOTTOM:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_BOTTOM;
					case IfcWindowTypePartitioningEnum.TRIPLE_PANEL_TOP:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_TOP;
					case IfcWindowTypePartitioningEnum.TRIPLE_PANEL_LEFT:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_LEFT;
					case IfcWindowTypePartitioningEnum.TRIPLE_PANEL_RIGHT:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_RIGHT;
					case IfcWindowTypePartitioningEnum.TRIPLE_PANEL_HORIZONTAL:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_HORIZONTAL;
					case IfcWindowTypePartitioningEnum.USERDEFINED:
						//## Optional custom handling of PartitioningType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.USERDEFINED;
					case IfcWindowTypePartitioningEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PartitioningType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.SINGLE_PANEL:
						PartitioningType = IfcWindowTypePartitioningEnum.SINGLE_PANEL;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.DOUBLE_PANEL_VERTICAL:
						PartitioningType = IfcWindowTypePartitioningEnum.DOUBLE_PANEL_VERTICAL;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.DOUBLE_PANEL_HORIZONTAL:
						PartitioningType = IfcWindowTypePartitioningEnum.DOUBLE_PANEL_HORIZONTAL;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_VERTICAL:
						PartitioningType = IfcWindowTypePartitioningEnum.TRIPLE_PANEL_VERTICAL;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_BOTTOM:
						PartitioningType = IfcWindowTypePartitioningEnum.TRIPLE_PANEL_BOTTOM;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_TOP:
						PartitioningType = IfcWindowTypePartitioningEnum.TRIPLE_PANEL_TOP;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_LEFT:
						PartitioningType = IfcWindowTypePartitioningEnum.TRIPLE_PANEL_LEFT;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_RIGHT:
						PartitioningType = IfcWindowTypePartitioningEnum.TRIPLE_PANEL_RIGHT;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.TRIPLE_PANEL_HORIZONTAL:
						PartitioningType = IfcWindowTypePartitioningEnum.TRIPLE_PANEL_HORIZONTAL;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.USERDEFINED:
						PartitioningType = IfcWindowTypePartitioningEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcWindowTypePartitioningEnum.NOTDEFINED:
						PartitioningType = IfcWindowTypePartitioningEnum.NOTDEFINED;
						return;
					
					case null:
						PartitioningType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcWindow), 13)]
		Ifc4.MeasureResource.IfcLabel? IIfcWindow.UserDefinedPartitioningType 
		{ 
			get
			{
				if (!UserDefinedPartitioningType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedPartitioningType.Value);
			} 
			set
			{
				UserDefinedPartitioningType = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}