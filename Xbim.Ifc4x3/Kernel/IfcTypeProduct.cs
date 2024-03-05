// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using Xbim.Ifc4x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.Kernel;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.Kernel
{
	[ExpressType("IfcTypeProduct", 43)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTypeProduct : IfcTypeObject, IInstantiableEntity, IfcProductSelect, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTypeProduct>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeProduct(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_representationMaps = new OptionalItemSet<IfcRepresentationMap>( this, 0,  7);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcRepresentationMap> _representationMaps;
		private IfcLabel? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 15)]
		public IOptionalItemSet<IfcRepresentationMap> @RepresentationMaps 
		{ 
			get 
			{
				if(_activated) return _representationMaps;
				Activate();
				return _representationMaps;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 16)]
		public IfcLabel? @Tag 
		{ 
			get 
			{
				if(_activated) return _tag;
				Activate();
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag", 8);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingProduct")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 17)]
		public IEnumerable<IfcRelAssignsToProduct> @ReferencedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToProduct>(e => Equals(e.RelatingProduct), "RelatingProduct", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_representationMaps.InternalAdd((IfcRepresentationMap)value.EntityVal);
					return;
				case 7: 
					_tag = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTypeProduct other)
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
				foreach(var entity in @HasPropertySets)
					yield return entity;
				foreach(var entity in @RepresentationMaps)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertySets)
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