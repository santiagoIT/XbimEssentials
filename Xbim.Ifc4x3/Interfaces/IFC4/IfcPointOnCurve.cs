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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcPointOnCurve : IIfcPointOnCurve
	{

		[CrossSchemaAttribute(typeof(IIfcPointOnCurve), 1)]
		IIfcCurve IIfcPointOnCurve.BasisCurve 
		{ 
			get
			{
				return BasisCurve;
			} 
			set
			{
				BasisCurve = value as IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPointOnCurve), 2)]
		Ifc4.MeasureResource.IfcParameterValue IIfcPointOnCurve.PointParameter 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(PointParameter);
			} 
			set
			{
				PointParameter = new MeasureResource.IfcParameterValue(value);
				
			}
		}
		Ifc4.GeometryResource.IfcDimensionCount Ifc4.GeometricModelResource.IfcGeometricSetSelect.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}