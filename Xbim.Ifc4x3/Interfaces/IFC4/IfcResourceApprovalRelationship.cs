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
namespace Xbim.Ifc4x3.ApprovalResource
{
	public partial class @IfcResourceApprovalRelationship : IIfcResourceApprovalRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcResourceApprovalRelationship), 3)]
		IItemSet<IIfcResourceObjectSelect> IIfcResourceApprovalRelationship.RelatedResourceObjects 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<ExternalReferenceResource.IfcResourceObjectSelect, IIfcResourceObjectSelect>(RelatedResourceObjects);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcResourceApprovalRelationship), 4)]
		IIfcApproval IIfcResourceApprovalRelationship.RelatingApproval 
		{ 
			get
			{
				return RelatingApproval;
			} 
			set
			{
				RelatingApproval = value as IfcApproval;
				
			}
		}
	//## Custom code
	//##
	}
}