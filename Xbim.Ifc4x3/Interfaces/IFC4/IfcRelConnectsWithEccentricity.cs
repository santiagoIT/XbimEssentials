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
namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	public partial class @IfcRelConnectsWithEccentricity : IIfcRelConnectsWithEccentricity
	{

		[CrossSchemaAttribute(typeof(IIfcRelConnectsWithEccentricity), 11)]
		IIfcConnectionGeometry IIfcRelConnectsWithEccentricity.ConnectionConstraint 
		{ 
			get
			{
				return ConnectionConstraint;
			} 
			set
			{
				ConnectionConstraint = value as GeometricConstraintResource.IfcConnectionGeometry;
				
			}
		}
	//## Custom code
	//##
	}
}