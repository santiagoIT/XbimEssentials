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
namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	public partial class @IfcConnectionPointEccentricity : IIfcConnectionPointEccentricity
	{

		[CrossSchemaAttribute(typeof(IIfcConnectionPointEccentricity), 3)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInX 
		{ 
			get
			{
				if (!EccentricityInX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(EccentricityInX.Value);
			} 
			set
			{
				EccentricityInX = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConnectionPointEccentricity), 4)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInY 
		{ 
			get
			{
				if (!EccentricityInY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(EccentricityInY.Value);
			} 
			set
			{
				EccentricityInY = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConnectionPointEccentricity), 5)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInZ 
		{ 
			get
			{
				if (!EccentricityInZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(EccentricityInZ.Value);
			} 
			set
			{
				EccentricityInZ = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}