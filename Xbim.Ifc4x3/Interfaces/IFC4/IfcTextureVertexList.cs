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
namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	public partial class @IfcTextureVertexList : IIfcTextureVertexList
	{

		[CrossSchemaAttribute(typeof(IIfcTextureVertexList), 1)]
		IItemSet<IItemSet<Xbim.Ifc4.MeasureResource.IfcParameterValue>> IIfcTextureVertexList.TexCoordsList 
		{ 
			get
			{
				return new Common.Collections.ProxyNestedValueSet<MeasureResource.IfcParameterValue, Ifc4.MeasureResource.IfcParameterValue>(TexCoordsList, 
					s => new Ifc4.MeasureResource.IfcParameterValue(s), 
					t => new MeasureResource.IfcParameterValue(t));
			} 
		}
	//## Custom code
	//##
	}
}