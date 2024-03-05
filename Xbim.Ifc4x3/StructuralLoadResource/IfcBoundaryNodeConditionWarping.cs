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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.StructuralLoadResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.StructuralLoadResource
{
	[ExpressType("IfcBoundaryNodeConditionWarping", 395)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition, IInstantiableEntity, IEquatable<@IfcBoundaryNodeConditionWarping>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryNodeConditionWarping(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcWarpingStiffnessSelect _warpingStiffness;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public IfcWarpingStiffnessSelect @WarpingStiffness 
		{ 
			get 
			{
				if(_activated) return _warpingStiffness;
				Activate();
				return _warpingStiffness;
			} 
			set
			{
				SetValue( v =>  _warpingStiffness = v, _warpingStiffness, value,  "WarpingStiffness", 8);
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
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_warpingStiffness = (IfcWarpingStiffnessSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBoundaryNodeConditionWarping other)
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