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
namespace Xbim.Ifc4x3.ProfileResource
{
	public partial class @IfcArbitraryClosedProfileDef : IIfcArbitraryClosedProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcArbitraryClosedProfileDef), 3)]
		IIfcCurve IIfcArbitraryClosedProfileDef.OuterCurve 
		{ 
			get
			{
				return OuterCurve;
			} 
			set
			{
				OuterCurve = value as GeometryResource.IfcCurve;
				
			}
		}
	//## Custom code
	//##
	}
}