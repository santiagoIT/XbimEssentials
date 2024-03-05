// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ConstraintResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ConstraintResource
{
	[ExpressType("IfcResourceConstraintRelationship", 1257)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceConstraintRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcResourceConstraintRelationship>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceConstraintRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this, 0,  4);
		}

		#region Explicit attribute fields
		private IfcConstraint _relatingConstraint;
		private readonly ItemSet<IfcResourceObjectSelect> _relatedResourceObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcConstraint @RelatingConstraint 
		{ 
			get 
			{
				if(_activated) return _relatingConstraint;
				Activate();
				return _relatingConstraint;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingConstraint = v, _relatingConstraint, value,  "RelatingConstraint", 3);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcResourceObjectSelect> @RelatedResourceObjects 
		{ 
			get 
			{
				if(_activated) return _relatedResourceObjects;
				Activate();
				return _relatedResourceObjects;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_relatingConstraint = (IfcConstraint)(value.EntityVal);
					return;
				case 3: 
					_relatedResourceObjects.InternalAdd((IfcResourceObjectSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcResourceConstraintRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RelatingConstraint != null)
					yield return @RelatingConstraint;
				foreach(var entity in @RelatedResourceObjects)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingConstraint != null)
					yield return @RelatingConstraint;
				foreach(var entity in @RelatedResourceObjects)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}