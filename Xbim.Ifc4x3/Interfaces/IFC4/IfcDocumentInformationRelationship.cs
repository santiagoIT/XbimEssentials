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
namespace Xbim.Ifc4x3.ExternalReferenceResource
{
	public partial class @IfcDocumentInformationRelationship : IIfcDocumentInformationRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcDocumentInformationRelationship), 3)]
		IIfcDocumentInformation IIfcDocumentInformationRelationship.RelatingDocument 
		{ 
			get
			{
				return RelatingDocument;
			} 
			set
			{
				RelatingDocument = value as IfcDocumentInformation;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformationRelationship), 4)]
		IItemSet<IIfcDocumentInformation> IIfcDocumentInformationRelationship.RelatedDocuments 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcDocumentInformation, IIfcDocumentInformation>(RelatedDocuments);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformationRelationship), 5)]
		Ifc4.MeasureResource.IfcLabel? IIfcDocumentInformationRelationship.RelationshipType 
		{ 
			get
			{
				if (!RelationshipType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(RelationshipType.Value);
			} 
			set
			{
				RelationshipType = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}