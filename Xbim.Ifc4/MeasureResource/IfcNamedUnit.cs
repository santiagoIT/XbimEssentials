// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.MeasureResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcNamedUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcNamedUnit : IPersistEntity, IfcUnit
	{
		IIfcDimensionalExponents @Dimensions { get;  set; }
		IfcUnitEnum @UnitType { get;  set; }
	
	}
}

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IfcNamedUnit", 93)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcNamedUnit : PersistEntity, IIfcNamedUnit, IEquatable<@IfcNamedUnit>
	{
		#region IIfcNamedUnit explicit implementation
		IIfcDimensionalExponents IIfcNamedUnit.Dimensions { 
 
 
			get { return @Dimensions; } 
			set { Dimensions = value as IfcDimensionalExponents;}
		}	
		IfcUnitEnum IIfcNamedUnit.UnitType { 
 
			get { return @UnitType; } 
			set { UnitType = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcNamedUnit(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDimensionalExponents _dimensions;
		private IfcUnitEnum _unitType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public virtual IfcDimensionalExponents @Dimensions 
		{ 
			get 
			{
				if(_activated) return _dimensions;
				Activate();
				return _dimensions;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _dimensions = v, _dimensions, value,  "Dimensions", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 2)]
		public IfcUnitEnum @UnitType 
		{ 
			get 
			{
				if(_activated) return _unitType;
				Activate();
				return _unitType;
			} 
			set
			{
				SetValue( v =>  _unitType = v, _unitType, value,  "UnitType", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_dimensions = (IfcDimensionalExponents)(value.EntityVal);
					return;
				case 1: 
                    _unitType = (IfcUnitEnum) System.Enum.Parse(typeof (IfcUnitEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcNamedUnit other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}