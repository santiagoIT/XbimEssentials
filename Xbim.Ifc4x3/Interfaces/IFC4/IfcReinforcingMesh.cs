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
namespace Xbim.Ifc4x3.StructuralElementsDomain
{
	public partial class @IfcReinforcingMesh : IIfcReinforcingMesh
	{

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 10)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingMesh.MeshLength 
		{ 
			get
			{
				if (!MeshLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(MeshLength.Value);
			} 
			set
			{
				MeshLength = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 11)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingMesh.MeshWidth 
		{ 
			get
			{
				if (!MeshWidth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(MeshWidth.Value);
			} 
			set
			{
				MeshWidth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 12)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingMesh.LongitudinalBarNominalDiameter 
		{ 
			get
			{
				if (!LongitudinalBarNominalDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(LongitudinalBarNominalDiameter.Value);
			} 
			set
			{
				LongitudinalBarNominalDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 13)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingMesh.TransverseBarNominalDiameter 
		{ 
			get
			{
				if (!TransverseBarNominalDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(TransverseBarNominalDiameter.Value);
			} 
			set
			{
				TransverseBarNominalDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 14)]
		Ifc4.MeasureResource.IfcAreaMeasure? IIfcReinforcingMesh.LongitudinalBarCrossSectionArea 
		{ 
			get
			{
				if (!LongitudinalBarCrossSectionArea.HasValue) return null;
				return new Ifc4.MeasureResource.IfcAreaMeasure(LongitudinalBarCrossSectionArea.Value);
			} 
			set
			{
				LongitudinalBarCrossSectionArea = value.HasValue ? 
					new MeasureResource.IfcAreaMeasure(value.Value) :  
					 new MeasureResource.IfcAreaMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 15)]
		Ifc4.MeasureResource.IfcAreaMeasure? IIfcReinforcingMesh.TransverseBarCrossSectionArea 
		{ 
			get
			{
				if (!TransverseBarCrossSectionArea.HasValue) return null;
				return new Ifc4.MeasureResource.IfcAreaMeasure(TransverseBarCrossSectionArea.Value);
			} 
			set
			{
				TransverseBarCrossSectionArea = value.HasValue ? 
					new MeasureResource.IfcAreaMeasure(value.Value) :  
					 new MeasureResource.IfcAreaMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 16)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingMesh.LongitudinalBarSpacing 
		{ 
			get
			{
				if (!LongitudinalBarSpacing.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(LongitudinalBarSpacing.Value);
			} 
			set
			{
				LongitudinalBarSpacing = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 17)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingMesh.TransverseBarSpacing 
		{ 
			get
			{
				if (!TransverseBarSpacing.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(TransverseBarSpacing.Value);
			} 
			set
			{
				TransverseBarSpacing = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingMesh), 18)]
		Ifc4.Interfaces.IfcReinforcingMeshTypeEnum? IIfcReinforcingMesh.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcReinforcingMeshTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcReinforcingMeshTypeEnum.USERDEFINED;
					case IfcReinforcingMeshTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcReinforcingMeshTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcReinforcingMeshTypeEnum.USERDEFINED:
						PredefinedType = IfcReinforcingMeshTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcReinforcingMeshTypeEnum.NOTDEFINED:
						PredefinedType = IfcReinforcingMeshTypeEnum.NOTDEFINED;
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