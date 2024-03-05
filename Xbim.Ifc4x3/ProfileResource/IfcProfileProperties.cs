// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ProfileResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProfileResource
{
	[ExpressType("IfcProfileProperties", 649)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProfileProperties : IfcExtendedProperties, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcProfileProperties>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProfileProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcProfileDef _profileDefinition;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcProfileDef @ProfileDefinition 
		{ 
			get 
			{
				if(_activated) return _profileDefinition;
				Activate();
				return _profileDefinition;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _profileDefinition = v, _profileDefinition, value,  "ProfileDefinition", 4);
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
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_profileDefinition = (IfcProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProfileProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Properties)
					yield return entity;
				if (@ProfileDefinition != null)
					yield return @ProfileDefinition;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ProfileDefinition != null)
					yield return @ProfileDefinition;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}