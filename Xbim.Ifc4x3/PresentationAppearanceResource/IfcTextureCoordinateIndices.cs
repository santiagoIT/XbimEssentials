// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometricModelResource;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	[ExpressType("IfcTextureCoordinateIndices", 1496)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureCoordinateIndices : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTextureCoordinateIndices>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureCoordinateIndices(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_texCoordIndex = new ItemSet<IfcPositiveInteger>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcPositiveInteger> _texCoordIndex;
		private IfcIndexedPolygonalFace _texCoordsOf;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 3 }, new int [] { -1 }, 1)]
		public IItemSet<IfcPositiveInteger> @TexCoordIndex 
		{ 
			get 
			{
				if(_activated) return _texCoordIndex;
				Activate();
				return _texCoordIndex;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcIndexedPolygonalFace @TexCoordsOf 
		{ 
			get 
			{
				if(_activated) return _texCoordsOf;
				Activate();
				return _texCoordsOf;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _texCoordsOf = v, _texCoordsOf, value,  "TexCoordsOf", 2);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("TexCoordIndices")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, null, null, 3)]
		public IfcIndexedPolygonalTextureMap @ToTexMap 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcIndexedPolygonalTextureMap>(e => e.TexCoordIndices != null &&  e.TexCoordIndices.Contains(this), "TexCoordIndices", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_texCoordIndex.InternalAdd(value.IntegerVal);
					return;
				case 1: 
					_texCoordsOf = (IfcIndexedPolygonalFace)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureCoordinateIndices other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@TexCoordsOf != null)
					yield return @TexCoordsOf;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@TexCoordsOf != null)
					yield return @TexCoordsOf;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}