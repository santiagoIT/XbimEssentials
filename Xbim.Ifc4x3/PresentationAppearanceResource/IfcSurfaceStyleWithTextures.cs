// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceStyleWithTextures", 392)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleWithTextures : IfcPresentationItem, IInstantiableEntity, IfcSurfaceStyleElementSelect, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcSurfaceStyleWithTextures>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleWithTextures(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_textures = new ItemSet<IfcSurfaceTexture>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcSurfaceTexture> _textures;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 1)]
		public IItemSet<IfcSurfaceTexture> @Textures 
		{ 
			get 
			{
				if(_activated) return _textures;
				Activate();
				return _textures;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_textures.InternalAdd((IfcSurfaceTexture)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyleWithTextures other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Textures)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Textures)
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