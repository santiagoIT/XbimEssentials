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
	public partial class @IfcLinearPlacement : IIfcLinearPlacement
	{

		[CrossSchemaAttribute(typeof(IIfcLinearPlacement), 1)]
		IIfcCurve IIfcLinearPlacement.PlacementRelTo 
		{ 
			get
			{
				//## Handle return of PlacementRelTo for which no match was found
				//TODO: Handle return of PlacementRelTo for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
			set
			{
				//## Handle setting of PlacementRelTo for which no match was found
				//TODO: Handle setting of PlacementRelTo for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLinearPlacement), 2)]
		IIfcDistanceExpression IIfcLinearPlacement.Distance 
		{ 
			get
			{
				return Distance;
			} 
			set
			{
				Distance = value as GeometryResource.IfcDistanceExpression;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLinearPlacement), 3)]
		IIfcOrientationExpression IIfcLinearPlacement.Orientation 
		{ 
			get
			{
				return Orientation;
			} 
			set
			{
				Orientation = value as GeometryResource.IfcOrientationExpression;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLinearPlacement), 4)]
		IIfcAxis2Placement3D IIfcLinearPlacement.CartesianPosition 
		{ 
			get
			{
				return CartesianPosition;
			} 
			set
			{
				CartesianPosition = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}
	//## Custom code
	//##
	}
}