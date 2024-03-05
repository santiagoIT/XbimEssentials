// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometryResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometryResource
{
	[ExpressType("IfcSeventhOrderPolynomialSpiral", 1487)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSeventhOrderPolynomialSpiral : IfcSpiral, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcSeventhOrderPolynomialSpiral>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSeventhOrderPolynomialSpiral(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _septicTerm;
		private IfcLengthMeasure? _sexticTerm;
		private IfcLengthMeasure? _quinticTerm;
		private IfcLengthMeasure? _quarticTerm;
		private IfcLengthMeasure? _cubicTerm;
		private IfcLengthMeasure? _quadraticTerm;
		private IfcLengthMeasure? _linearTerm;
		private IfcLengthMeasure? _constantTerm;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLengthMeasure @SepticTerm 
		{ 
			get 
			{
				if(_activated) return _septicTerm;
				Activate();
				return _septicTerm;
			} 
			set
			{
				SetValue( v =>  _septicTerm = v, _septicTerm, value,  "SepticTerm", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLengthMeasure? @SexticTerm 
		{ 
			get 
			{
				if(_activated) return _sexticTerm;
				Activate();
				return _sexticTerm;
			} 
			set
			{
				SetValue( v =>  _sexticTerm = v, _sexticTerm, value,  "SexticTerm", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLengthMeasure? @QuinticTerm 
		{ 
			get 
			{
				if(_activated) return _quinticTerm;
				Activate();
				return _quinticTerm;
			} 
			set
			{
				SetValue( v =>  _quinticTerm = v, _quinticTerm, value,  "QuinticTerm", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLengthMeasure? @QuarticTerm 
		{ 
			get 
			{
				if(_activated) return _quarticTerm;
				Activate();
				return _quarticTerm;
			} 
			set
			{
				SetValue( v =>  _quarticTerm = v, _quarticTerm, value,  "QuarticTerm", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLengthMeasure? @CubicTerm 
		{ 
			get 
			{
				if(_activated) return _cubicTerm;
				Activate();
				return _cubicTerm;
			} 
			set
			{
				SetValue( v =>  _cubicTerm = v, _cubicTerm, value,  "CubicTerm", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcLengthMeasure? @QuadraticTerm 
		{ 
			get 
			{
				if(_activated) return _quadraticTerm;
				Activate();
				return _quadraticTerm;
			} 
			set
			{
				SetValue( v =>  _quadraticTerm = v, _quadraticTerm, value,  "QuadraticTerm", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcLengthMeasure? @LinearTerm 
		{ 
			get 
			{
				if(_activated) return _linearTerm;
				Activate();
				return _linearTerm;
			} 
			set
			{
				SetValue( v =>  _linearTerm = v, _linearTerm, value,  "LinearTerm", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcLengthMeasure? @ConstantTerm 
		{ 
			get 
			{
				if(_activated) return _constantTerm;
				Activate();
				return _constantTerm;
			} 
			set
			{
				SetValue( v =>  _constantTerm = v, _constantTerm, value,  "ConstantTerm", 9);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_septicTerm = value.RealVal;
					return;
				case 2: 
					_sexticTerm = value.RealVal;
					return;
				case 3: 
					_quinticTerm = value.RealVal;
					return;
				case 4: 
					_quarticTerm = value.RealVal;
					return;
				case 5: 
					_cubicTerm = value.RealVal;
					return;
				case 6: 
					_quadraticTerm = value.RealVal;
					return;
				case 7: 
					_linearTerm = value.RealVal;
					return;
				case 8: 
					_constantTerm = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSeventhOrderPolynomialSpiral other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}