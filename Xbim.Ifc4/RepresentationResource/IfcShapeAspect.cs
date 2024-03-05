// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.RepresentationResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcShapeAspect
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcShapeAspect : IPersistEntity, IfcResourceObjectSelect
	{
		IItemSet<IIfcShapeModel> @ShapeRepresentations { get; }
		IfcLabel? @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IfcLogical @ProductDefinitional { get;  set; }
		IIfcProductRepresentationSelect @PartOfProductDefinitionShape { get;  set; }
	
	}
}

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IfcShapeAspect", 665)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcShapeAspect : PersistEntity, IInstantiableEntity, IIfcShapeAspect, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcShapeAspect>
	{
		#region IIfcShapeAspect explicit implementation
		IItemSet<IIfcShapeModel> IIfcShapeAspect.ShapeRepresentations { 
			get { return new Common.Collections.ProxyItemSet<IfcShapeModel, IIfcShapeModel>( @ShapeRepresentations); } 
		}	
		IfcLabel? IIfcShapeAspect.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcShapeAspect.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcLogical IIfcShapeAspect.ProductDefinitional { 
 
			get { return @ProductDefinitional; } 
			set { ProductDefinitional = value;}
		}	
		IIfcProductRepresentationSelect IIfcShapeAspect.PartOfProductDefinitionShape { 
 
 
			get { return @PartOfProductDefinitionShape; } 
			set { PartOfProductDefinitionShape = value as IfcProductRepresentationSelect;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShapeAspect(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_shapeRepresentations = new ItemSet<IfcShapeModel>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcShapeModel> _shapeRepresentations;
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcLogical _productDefinitional;
		private IfcProductRepresentationSelect _partOfProductDefinitionShape;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 1)]
		public IItemSet<IfcShapeModel> @ShapeRepresentations 
		{ 
			get 
			{
				if(_activated) return _shapeRepresentations;
				Activate();
				return _shapeRepresentations;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLogical @ProductDefinitional 
		{ 
			get 
			{
				if(_activated) return _productDefinitional;
				Activate();
				return _productDefinitional;
			} 
			set
			{
				SetValue( v =>  _productDefinitional = v, _productDefinitional, value,  "ProductDefinitional", 4);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcProductRepresentationSelect @PartOfProductDefinitionShape 
		{ 
			get 
			{
				if(_activated) return _partOfProductDefinitionShape;
				Activate();
				return _partOfProductDefinitionShape;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _partOfProductDefinitionShape = v, _partOfProductDefinitionShape, value,  "PartOfProductDefinitionShape", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_shapeRepresentations.InternalAdd((IfcShapeModel)value.EntityVal);
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_productDefinitional = value.BooleanVal;
					return;
				case 4: 
					_partOfProductDefinitionShape = (IfcProductRepresentationSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcShapeAspect other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @ShapeRepresentations)
					yield return entity;
				if (@PartOfProductDefinitionShape != null)
					yield return @PartOfProductDefinitionShape;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @ShapeRepresentations)
					yield return entity;
				if (@PartOfProductDefinitionShape != null)
					yield return @PartOfProductDefinitionShape;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}