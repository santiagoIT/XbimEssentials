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
	public partial class @IfcAlignment2DHorizontalSegment : IIfcAlignment2DHorizontalSegment
	{

		[CrossSchemaAttribute(typeof(IIfcAlignment2DHorizontalSegment), 4)]
		IIfcCurveSegment2D IIfcAlignment2DHorizontalSegment.CurveGeometry 
		{ 
			get
			{
				return CurveGeometry;
			} 
			set
			{
				CurveGeometry = value as GeometryResource.IfcCurveSegment2D;
				
			}
		}
		IEnumerable<IIfcAlignment2DHorizontal> IIfcAlignment2DHorizontalSegment.ToHorizontal 
		{ 
			get
			{
				return Model.Instances.Where<IIfcAlignment2DHorizontal>(e => e.Segments != null &&  e.Segments.Contains(this), "Segments", this);
			} 
		}
	//## Custom code
	//##
	}
}