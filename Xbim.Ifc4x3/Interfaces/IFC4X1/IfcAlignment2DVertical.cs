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
	public partial class @IfcAlignment2DVertical : IIfcAlignment2DVertical
	{

		[CrossSchemaAttribute(typeof(IIfcAlignment2DVertical), 1)]
		IItemSet<IIfcAlignment2DVerticalSegment> IIfcAlignment2DVertical.Segments 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcAlignment2DVerticalSegment, IIfcAlignment2DVerticalSegment>(Segments);
			} 
		}
		IEnumerable<IIfcAlignmentCurve> IIfcAlignment2DVertical.ToAlignmentCurve 
		{ 
			get
			{
				return Model.Instances.Where<IIfcAlignmentCurve>(e => (e.Vertical as IfcAlignment2DVertical) == this, "Vertical", this);
			} 
		}
	//## Custom code
	//##
	}
}