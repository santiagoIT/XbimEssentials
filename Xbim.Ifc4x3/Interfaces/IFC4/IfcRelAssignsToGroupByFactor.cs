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
namespace Xbim.Ifc4x3.Kernel
{
	public partial class @IfcRelAssignsToGroupByFactor : IIfcRelAssignsToGroupByFactor
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssignsToGroupByFactor), 8)]
		Ifc4.MeasureResource.IfcRatioMeasure IIfcRelAssignsToGroupByFactor.Factor 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcRatioMeasure(Factor);
			} 
			set
			{
				Factor = new MeasureResource.IfcRatioMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}