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
namespace Xbim.Ifc4x3.RepresentationResource
{
	public partial class @IfcProductDefinitionShape : IIfcProductDefinitionShape
	{
		IEnumerable<IIfcProduct> IIfcProductDefinitionShape.ShapeOfProduct 
		{ 
			get
			{
				return Model.Instances.Where<IIfcProduct>(e => (e.Representation as IfcProductDefinitionShape) == this, "Representation", this);
			} 
		}
		IEnumerable<IIfcShapeAspect> IIfcProductDefinitionShape.HasShapeAspects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcShapeAspect>(e => (e.PartOfProductDefinitionShape as IfcProductDefinitionShape) == this, "PartOfProductDefinitionShape", this);
			} 
		}
	//## Custom code
	//##
	}
}