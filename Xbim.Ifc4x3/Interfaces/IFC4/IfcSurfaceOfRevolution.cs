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
	public partial class @IfcSurfaceOfRevolution : IIfcSurfaceOfRevolution
	{

		[CrossSchemaAttribute(typeof(IIfcSurfaceOfRevolution), 3)]
		IIfcAxis1Placement IIfcSurfaceOfRevolution.AxisPosition 
		{ 
			get
			{
				return AxisPosition;
			} 
			set
			{
				AxisPosition = value as IfcAxis1Placement;
				
			}
		}
		Common.Geometry.XbimLine IIfcSurfaceOfRevolution.AxisLine 
		{
			get 
			{
				return AxisLine;
			}
		}

	//## Custom code
	//##
	}
}