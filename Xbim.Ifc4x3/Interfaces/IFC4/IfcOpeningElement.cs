// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcOpeningElement : IIfcOpeningElement
	{

		[CrossSchemaAttribute(typeof(IIfcOpeningElement), 9)]
		Ifc4.Interfaces.IfcOpeningElementTypeEnum? IIfcOpeningElement.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcOpeningElementTypeEnum.OPENING:
						return Ifc4.Interfaces.IfcOpeningElementTypeEnum.OPENING;
					case IfcOpeningElementTypeEnum.RECESS:
						return Ifc4.Interfaces.IfcOpeningElementTypeEnum.RECESS;
					case IfcOpeningElementTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcOpeningElementTypeEnum.USERDEFINED;
					case IfcOpeningElementTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcOpeningElementTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcOpeningElementTypeEnum.OPENING:
						PredefinedType = IfcOpeningElementTypeEnum.OPENING;
						return;
					case Ifc4.Interfaces.IfcOpeningElementTypeEnum.RECESS:
						PredefinedType = IfcOpeningElementTypeEnum.RECESS;
						return;
					case Ifc4.Interfaces.IfcOpeningElementTypeEnum.USERDEFINED:
						PredefinedType = IfcOpeningElementTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcOpeningElementTypeEnum.NOTDEFINED:
						PredefinedType = IfcOpeningElementTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IEnumerable<IIfcRelFillsElement> IIfcOpeningElement.HasFillings 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelFillsElement>(e => (e.RelatingOpeningElement as IfcOpeningElement) == this, "RelatingOpeningElement", this);
			} 
		}
	//## Custom code
	//##
	}
}