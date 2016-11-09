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
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcPile : IIfcPile
	{

		[CrossSchemaAttribute(typeof(IIfcPile), 9)]
		Ifc4.Interfaces.IfcPileTypeEnum? IIfcPile.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcPileTypeEnum.COHESION:
						return Ifc4.Interfaces.IfcPileTypeEnum.COHESION;
					case IfcPileTypeEnum.FRICTION:
						return Ifc4.Interfaces.IfcPileTypeEnum.FRICTION;
					case IfcPileTypeEnum.SUPPORT:
						return Ifc4.Interfaces.IfcPileTypeEnum.SUPPORT;
					case IfcPileTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if(ObjectType.HasValue)
                            switch (ObjectType.Value)
                            {
                                case "BORED":
                                case "DRIVEN":
                                case "JETGROUTING":
                                    return
                                        (Ifc4.Interfaces.IfcPileTypeEnum)
                                            System.Enum.Parse(typeof (Ifc4.Interfaces.IfcPileTypeEnum), ObjectType.Value);
                            }
						//##
						return Ifc4.Interfaces.IfcPileTypeEnum.USERDEFINED;
					case IfcPileTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPileTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcPileTypeEnum.BORED:
						//## Handle setting of BORED member from IfcPileTypeEnum in property PredefinedType
				        ObjectType = System.Enum.GetName(typeof (Ifc4.Interfaces.IfcPileTypeEnum), value);
						PredefinedType = IfcPileTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcPileTypeEnum.DRIVEN:
						//## Handle setting of DRIVEN member from IfcPileTypeEnum in property PredefinedType
						ObjectType = System.Enum.GetName(typeof (Ifc4.Interfaces.IfcPileTypeEnum), value);
						PredefinedType = IfcPileTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcPileTypeEnum.JETGROUTING:
						//## Handle setting of JETGROUTING member from IfcPileTypeEnum in property PredefinedType
						ObjectType = System.Enum.GetName(typeof (Ifc4.Interfaces.IfcPileTypeEnum), value);
						PredefinedType = IfcPileTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcPileTypeEnum.COHESION:
						PredefinedType = IfcPileTypeEnum.COHESION;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.FRICTION:
						PredefinedType = IfcPileTypeEnum.FRICTION;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.SUPPORT:
						PredefinedType = IfcPileTypeEnum.SUPPORT;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.USERDEFINED:
						PredefinedType = IfcPileTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.NOTDEFINED:
						PredefinedType = IfcPileTypeEnum.NOTDEFINED;
						return;
					case null:
						PredefinedType = IfcPileTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPile), 10)]
		Ifc4.Interfaces.IfcPileConstructionEnum? IIfcPile.ConstructionType 
		{ 
			get
			{
				//## Custom code to handle enumeration of ConstructionType
				//##
				switch (ConstructionType)
				{
					case IfcPileConstructionEnum.CAST_IN_PLACE:
						return Ifc4.Interfaces.IfcPileConstructionEnum.CAST_IN_PLACE;
					case IfcPileConstructionEnum.COMPOSITE:
						return Ifc4.Interfaces.IfcPileConstructionEnum.COMPOSITE;
					case IfcPileConstructionEnum.PRECAST_CONCRETE:
						return Ifc4.Interfaces.IfcPileConstructionEnum.PRECAST_CONCRETE;
					case IfcPileConstructionEnum.PREFAB_STEEL:
						return Ifc4.Interfaces.IfcPileConstructionEnum.PREFAB_STEEL;
					case IfcPileConstructionEnum.USERDEFINED:
						//## Optional custom handling of ConstructionType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcPileConstructionEnum.USERDEFINED;
					case IfcPileConstructionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPileConstructionEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ConstructionType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcPileConstructionEnum.CAST_IN_PLACE:
						ConstructionType = IfcPileConstructionEnum.CAST_IN_PLACE;
						return;
					case Ifc4.Interfaces.IfcPileConstructionEnum.COMPOSITE:
						ConstructionType = IfcPileConstructionEnum.COMPOSITE;
						return;
					case Ifc4.Interfaces.IfcPileConstructionEnum.PRECAST_CONCRETE:
						ConstructionType = IfcPileConstructionEnum.PRECAST_CONCRETE;
						return;
					case Ifc4.Interfaces.IfcPileConstructionEnum.PREFAB_STEEL:
						ConstructionType = IfcPileConstructionEnum.PREFAB_STEEL;
						return;
					case Ifc4.Interfaces.IfcPileConstructionEnum.USERDEFINED:
						ConstructionType = IfcPileConstructionEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPileConstructionEnum.NOTDEFINED:
						ConstructionType = IfcPileConstructionEnum.NOTDEFINED;
						return;
					
					case null:
						ConstructionType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}