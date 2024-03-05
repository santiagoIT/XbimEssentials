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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDefinesByType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDefinesByType : IIfcRelDefines
	{
		IItemSet<IIfcObject> @RelatedObjects { get; }
		IIfcTypeObject @RelatingType { get;  set; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelDefinesByType", 206)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByType : IfcRelDefines, IInstantiableEntity, IIfcRelDefinesByType, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelDefinesByType>
	{
		#region IIfcRelDefinesByType explicit implementation
		IItemSet<IIfcObject> IIfcRelDefinesByType.RelatedObjects { 
			get { return new Common.Collections.ProxyItemSet<IfcObject, IIfcObject>( @RelatedObjects); } 
		}	
		IIfcTypeObject IIfcRelDefinesByType.RelatingType { 
 
 
			get { return @RelatingType; } 
			set { RelatingType = value as IfcTypeObject;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByType(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedObjects = new ItemSet<IfcObject>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcObject> _relatedObjects;
		private IfcTypeObject _relatingType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IItemSet<IfcObject> @RelatedObjects 
		{ 
			get 
			{
				if(_activated) return _relatedObjects;
				Activate();
				return _relatedObjects;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcTypeObject @RelatingType 
		{ 
			get 
			{
				if(_activated) return _relatingType;
				Activate();
				return _relatingType;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingType = v, _relatingType, value,  "RelatingType", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatedObjects.InternalAdd((IfcObject)value.EntityVal);
					return;
				case 5: 
					_relatingType = (IfcTypeObject)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelDefinesByType other)
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
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingType != null)
					yield return @RelatingType;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingType != null)
					yield return @RelatingType;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}