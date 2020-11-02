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
namespace Xbim.Ifc4x3.ProfileResource
{
	public partial class @IfcReinforcementBarProperties : IIfcReinforcementBarProperties
	{

		[CrossSchemaAttribute(typeof(IIfcReinforcementBarProperties), 1)]
		Ifc4.MeasureResource.IfcAreaMeasure IIfcReinforcementBarProperties.TotalCrossSectionArea 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcAreaMeasure(TotalCrossSectionArea);
			} 
			set
			{
				TotalCrossSectionArea = new MeasureResource.IfcAreaMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcementBarProperties), 2)]
		Ifc4.MeasureResource.IfcLabel IIfcReinforcementBarProperties.SteelGrade 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(SteelGrade);
			} 
			set
			{
				SteelGrade = new MeasureResource.IfcLabel(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcementBarProperties), 3)]
		Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum? IIfcReinforcementBarProperties.BarSurface 
		{ 
			get
			{
				//## Custom code to handle enumeration of BarSurface
				//##
				switch (BarSurface)
				{
					case IfcReinforcingBarSurfaceEnum.PLAIN:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.PLAIN;
					case IfcReinforcingBarSurfaceEnum.TEXTURED:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.TEXTURED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of BarSurface
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.PLAIN:
						BarSurface = IfcReinforcingBarSurfaceEnum.PLAIN;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.TEXTURED:
						BarSurface = IfcReinforcingBarSurfaceEnum.TEXTURED;
						return;
					
					case null:
						BarSurface = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcementBarProperties), 4)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcReinforcementBarProperties.EffectiveDepth 
		{ 
			get
			{
				if (!EffectiveDepth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(EffectiveDepth.Value);
			} 
			set
			{
				EffectiveDepth = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcementBarProperties), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcementBarProperties.NominalBarDiameter 
		{ 
			get
			{
				if (!NominalBarDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalBarDiameter.Value);
			} 
			set
			{
				NominalBarDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcementBarProperties), 6)]
		Ifc4.MeasureResource.IfcCountMeasure? IIfcReinforcementBarProperties.BarCount 
		{ 
			get
			{
				if (!BarCount.HasValue) return null;
				return new Ifc4.MeasureResource.IfcCountMeasure(BarCount.Value);
			} 
			set
			{
				BarCount = value.HasValue ? 
					new MeasureResource.IfcCountMeasure(value.Value) :  
					 new MeasureResource.IfcCountMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}