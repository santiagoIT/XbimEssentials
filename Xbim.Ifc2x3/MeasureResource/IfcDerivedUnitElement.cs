// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.MeasureResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IfcDerivedUnitElement", 380)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDerivedUnitElement : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcDerivedUnitElement>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDerivedUnitElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcNamedUnit _unit;
		private long _exponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcNamedUnit @Unit 
		{ 
			get 
			{
				if(_activated) return _unit;
				Activate();
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public long @Exponent 
		{ 
			get 
			{
				if(_activated) return _exponent;
				Activate();
				return _exponent;
			} 
			set
			{
				SetValue( v =>  _exponent = v, _exponent, value,  "Exponent", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_unit = (IfcNamedUnit)(value.EntityVal);
					return;
				case 1: 
					_exponent = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDerivedUnitElement other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}