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
	public partial class @IfcReinforcingElement : IIfcReinforcingElement
	{

		[CrossSchemaAttribute(typeof(IIfcReinforcingElement), 9)]
		Ifc4.MeasureResource.IfcLabel? IIfcReinforcingElement.SteelGrade 
		{ 
			get
			{
				if (!SteelGrade.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(SteelGrade.Value);
			} 
			set
			{
				SteelGrade = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}