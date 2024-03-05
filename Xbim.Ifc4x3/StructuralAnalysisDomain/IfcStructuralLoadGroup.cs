// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.Kernel;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.StructuralAnalysisDomain;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralLoadGroup", 573)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadGroup : IfcGroup, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcStructuralLoadGroup>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadGroup(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLoadGroupTypeEnum _predefinedType;
		private IfcActionTypeEnum _actionType;
		private IfcActionSourceTypeEnum _actionSource;
		private IfcRatioMeasure? _coefficient;
		private IfcLabel? _purpose;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 19)]
		public IfcLoadGroupTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 20)]
		public IfcActionTypeEnum @ActionType 
		{ 
			get 
			{
				if(_activated) return _actionType;
				Activate();
				return _actionType;
			} 
			set
			{
				SetValue( v =>  _actionType = v, _actionType, value,  "ActionType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 21)]
		public IfcActionSourceTypeEnum @ActionSource 
		{ 
			get 
			{
				if(_activated) return _actionSource;
				Activate();
				return _actionSource;
			} 
			set
			{
				SetValue( v =>  _actionSource = v, _actionSource, value,  "ActionSource", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 22)]
		public IfcRatioMeasure? @Coefficient 
		{ 
			get 
			{
				if(_activated) return _coefficient;
				Activate();
				return _coefficient;
			} 
			set
			{
				SetValue( v =>  _coefficient = v, _coefficient, value,  "Coefficient", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 23)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(_activated) return _purpose;
				Activate();
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose", 10);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ResultForLoadGroup")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 24)]
		public IEnumerable<IfcStructuralResultGroup> @SourceOfResultGroup 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralResultGroup>(e => Equals(e.ResultForLoadGroup), "ResultForLoadGroup", this);
			} 
		}
		[InverseProperty("LoadedBy")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 25)]
		public IEnumerable<IfcStructuralAnalysisModel> @LoadGroupFor 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralAnalysisModel>(e => e.LoadedBy != null &&  e.LoadedBy.Contains(this), "LoadedBy", this);
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
                    _predefinedType = (IfcLoadGroupTypeEnum) System.Enum.Parse(typeof (IfcLoadGroupTypeEnum), value.EnumVal, true);
					return;
				case 6: 
                    _actionType = (IfcActionTypeEnum) System.Enum.Parse(typeof (IfcActionTypeEnum), value.EnumVal, true);
					return;
				case 7: 
                    _actionSource = (IfcActionSourceTypeEnum) System.Enum.Parse(typeof (IfcActionSourceTypeEnum), value.EnumVal, true);
					return;
				case 8: 
					_coefficient = value.RealVal;
					return;
				case 9: 
					_purpose = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadGroup other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}