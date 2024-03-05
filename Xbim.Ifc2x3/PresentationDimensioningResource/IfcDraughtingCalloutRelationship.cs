// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.PresentationDimensioningResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IfcDraughtingCalloutRelationship", 740)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDraughtingCalloutRelationship : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDraughtingCalloutRelationship>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDraughtingCalloutRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcDraughtingCallout _relatingDraughtingCallout;
		private IfcDraughtingCallout _relatedDraughtingCallout;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcDraughtingCallout @RelatingDraughtingCallout 
		{ 
			get 
			{
				if(_activated) return _relatingDraughtingCallout;
				Activate();
				return _relatingDraughtingCallout;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingDraughtingCallout = v, _relatingDraughtingCallout, value,  "RelatingDraughtingCallout", 3);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcDraughtingCallout @RelatedDraughtingCallout 
		{ 
			get 
			{
				if(_activated) return _relatedDraughtingCallout;
				Activate();
				return _relatedDraughtingCallout;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedDraughtingCallout = v, _relatedDraughtingCallout, value,  "RelatedDraughtingCallout", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_relatingDraughtingCallout = (IfcDraughtingCallout)(value.EntityVal);
					return;
				case 3: 
					_relatedDraughtingCallout = (IfcDraughtingCallout)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDraughtingCalloutRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RelatingDraughtingCallout != null)
					yield return @RelatingDraughtingCallout;
				if (@RelatedDraughtingCallout != null)
					yield return @RelatedDraughtingCallout;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingDraughtingCallout != null)
					yield return @RelatingDraughtingCallout;
				if (@RelatedDraughtingCallout != null)
					yield return @RelatedDraughtingCallout;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}