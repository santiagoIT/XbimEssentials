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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcCartesianTransformationOperator : IIfcCartesianTransformationOperator
	{

		[CrossSchemaAttribute(typeof(IIfcCartesianTransformationOperator), 1)]
		IIfcDirection IIfcCartesianTransformationOperator.Axis1 
		{ 
			get
			{
				return Axis1;
			} 
			set
			{
				Axis1 = value as IfcDirection;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCartesianTransformationOperator), 2)]
		IIfcDirection IIfcCartesianTransformationOperator.Axis2 
		{ 
			get
			{
				return Axis2;
			} 
			set
			{
				Axis2 = value as IfcDirection;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCartesianTransformationOperator), 3)]
		IIfcCartesianPoint IIfcCartesianTransformationOperator.LocalOrigin 
		{ 
			get
			{
				return LocalOrigin;
			} 
			set
			{
				LocalOrigin = value as IfcCartesianPoint;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCartesianTransformationOperator), 4)]
		Ifc4.MeasureResource.IfcReal? IIfcCartesianTransformationOperator.Scale 
		{ 
			get
			{
				if (!Scale.HasValue) return null;
				return new Ifc4.MeasureResource.IfcReal(Scale.Value);
			} 
			set
			{
				Scale = value.HasValue ? 
					new MeasureResource.IfcReal(value.Value) :  
					 new MeasureResource.IfcReal?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcCartesianTransformationOperator.Scl 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcReal(Scl);
			}
		}

		Ifc4.GeometryResource.IfcDimensionCount IIfcCartesianTransformationOperator.Dim 
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