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
namespace Xbim.Ifc4x3.PropertyResource
{
	public partial class @IfcComplexProperty : IIfcComplexProperty
	{

		[CrossSchemaAttribute(typeof(IIfcComplexProperty), 3)]
		Ifc4.MeasureResource.IfcIdentifier IIfcComplexProperty.UsageName 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcIdentifier(UsageName);
			} 
			set
			{
				UsageName = new MeasureResource.IfcIdentifier(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcComplexProperty), 4)]
		IItemSet<IIfcProperty> IIfcComplexProperty.HasProperties 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcProperty, IIfcProperty>(HasProperties);
			} 
		}
	//## Custom code
	//##
	}
}