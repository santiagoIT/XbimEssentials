// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCartesianTransformationOperator3DnonUniform
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCartesianTransformationOperator3DnonUniform : IIfcCartesianTransformationOperator3D
	{
		IfcReal? @Scale2 { get;  set; }
		IfcReal? @Scale3 { get;  set; }
		IfcReal @Scl2  { get ; }
		IfcReal @Scl3  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCartesianTransformationOperator3DnonUniform", 479)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D, IInstantiableEntity, IIfcCartesianTransformationOperator3DnonUniform, IContainsEntityReferences, IEquatable<@IfcCartesianTransformationOperator3DnonUniform>
	{
		#region IIfcCartesianTransformationOperator3DnonUniform explicit implementation
		IfcReal? IIfcCartesianTransformationOperator3DnonUniform.Scale2 { 
 
			get { return @Scale2; } 
			set { Scale2 = value;}
		}	
		IfcReal? IIfcCartesianTransformationOperator3DnonUniform.Scale3 { 
 
			get { return @Scale3; } 
			set { Scale3 = value;}
		}	
		IfcReal IIfcCartesianTransformationOperator3DnonUniform.@Scl2  { get { return @Scl2; } }
		IfcReal IIfcCartesianTransformationOperator3DnonUniform.@Scl3  { get { return @Scl3; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator3DnonUniform(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcReal? _scale2;
		private IfcReal? _scale3;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcReal? @Scale2 
		{ 
			get 
			{
				if(_activated) return _scale2;
				Activate();
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcReal? @Scale3 
		{ 
			get 
			{
				if(_activated) return _scale3;
				Activate();
				return _scale3;
			} 
			set
			{
				SetValue( v =>  _scale3 = v, _scale3, value,  "Scale3", 7);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcReal @Scl2 
		{
			get 
			{
				//## Getter for Scl2
                return Scale2 ?? Scl;
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcReal @Scl3 
		{
			get 
			{
				//## Getter for Scl3
                return Scale3 ?? Scl;
				//##
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
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_scale2 = value.RealVal;
					return;
				case 6: 
					_scale3 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator3DnonUniform other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Axis1 != null)
					yield return @Axis1;
				if (@Axis2 != null)
					yield return @Axis2;
				if (@LocalOrigin != null)
					yield return @LocalOrigin;
				if (@Axis3 != null)
					yield return @Axis3;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}