// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ProductExtension;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProductExtension
{
	[ExpressType("IfcRelFillsElement", 563)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelFillsElement : IfcRelConnects, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelFillsElement>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelFillsElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcOpeningElement _relatingOpeningElement;
		private IfcElement _relatedBuildingElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcOpeningElement @RelatingOpeningElement 
		{ 
			get 
			{
				if(_activated) return _relatingOpeningElement;
				Activate();
				return _relatingOpeningElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingOpeningElement = v, _relatingOpeningElement, value,  "RelatingOpeningElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcElement @RelatedBuildingElement 
		{ 
			get 
			{
				if(_activated) return _relatedBuildingElement;
				Activate();
				return _relatedBuildingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedBuildingElement = v, _relatedBuildingElement, value,  "RelatedBuildingElement", 6);
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
					_relatingOpeningElement = (IfcOpeningElement)(value.EntityVal);
					return;
				case 5: 
					_relatedBuildingElement = (IfcElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelFillsElement other)
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
				if (@RelatingOpeningElement != null)
					yield return @RelatingOpeningElement;
				if (@RelatedBuildingElement != null)
					yield return @RelatedBuildingElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingOpeningElement != null)
					yield return @RelatingOpeningElement;
				if (@RelatedBuildingElement != null)
					yield return @RelatedBuildingElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}