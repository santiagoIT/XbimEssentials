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
namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	public partial class @IfcCurveStyleFont : IIfcCurveStyleFont
	{

		[CrossSchemaAttribute(typeof(IIfcCurveStyleFont), 1)]
		Ifc4.MeasureResource.IfcLabel? IIfcCurveStyleFont.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurveStyleFont), 2)]
		IItemSet<IIfcCurveStyleFontPattern> IIfcCurveStyleFont.PatternList 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcCurveStyleFontPattern, IIfcCurveStyleFontPattern>(PatternList);
			} 
		}
	//## Custom code
	//##
	}
}