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
namespace Xbim.Ifc4x3.StructuralLoadResource
{
	public partial class @IfcStructuralLoadConfiguration : IIfcStructuralLoadConfiguration
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadConfiguration), 2)]
		IItemSet<IIfcStructuralLoadOrResult> IIfcStructuralLoadConfiguration.Values 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcStructuralLoadOrResult, IIfcStructuralLoadOrResult>(Values);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadConfiguration), 3)]
		IItemSet<IItemSet<Xbim.Ifc4.MeasureResource.IfcLengthMeasure>> IIfcStructuralLoadConfiguration.Locations 
		{ 
			get
			{
				return new Common.Collections.ProxyNestedValueSet<MeasureResource.IfcLengthMeasure, Ifc4.MeasureResource.IfcLengthMeasure>(Locations, 
					s => new Ifc4.MeasureResource.IfcLengthMeasure(s), 
					t => new MeasureResource.IfcLengthMeasure(t));
			} 
		}
	//## Custom code
	//##
	}
}