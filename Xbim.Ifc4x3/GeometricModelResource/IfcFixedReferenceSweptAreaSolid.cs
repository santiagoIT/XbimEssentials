// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricModelResource
{
	[ExpressType("IfcFixedReferenceSweptAreaSolid", 1180)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFixedReferenceSweptAreaSolid : IfcDirectrixCurveSweptAreaSolid, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcFixedReferenceSweptAreaSolid>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFixedReferenceSweptAreaSolid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _fixedReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public IfcDirection @FixedReference 
		{ 
			get 
			{
				if(_activated) return _fixedReference;
				Activate();
				return _fixedReference;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _fixedReference = v, _fixedReference, value,  "FixedReference", 6);
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
					_fixedReference = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFixedReferenceSweptAreaSolid other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SweptArea != null)
					yield return @SweptArea;
				if (@Position != null)
					yield return @Position;
				if (@Directrix != null)
					yield return @Directrix;
				if (@FixedReference != null)
					yield return @FixedReference;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}