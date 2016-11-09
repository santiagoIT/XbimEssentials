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
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralAnalysisModel : IIfcStructuralAnalysisModel
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralAnalysisModel), 6)]
		Ifc4.Interfaces.IfcAnalysisModelTypeEnum IIfcStructuralAnalysisModel.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcAnalysisModelTypeEnum.IN_PLANE_LOADING_2D:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.IN_PLANE_LOADING_2D;
					case IfcAnalysisModelTypeEnum.OUT_PLANE_LOADING_2D:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.OUT_PLANE_LOADING_2D;
					case IfcAnalysisModelTypeEnum.LOADING_3D:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.LOADING_3D;
					case IfcAnalysisModelTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.USERDEFINED;
					case IfcAnalysisModelTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcAnalysisModelTypeEnum.IN_PLANE_LOADING_2D:
						PredefinedType = IfcAnalysisModelTypeEnum.IN_PLANE_LOADING_2D;
						return;
					case Ifc4.Interfaces.IfcAnalysisModelTypeEnum.OUT_PLANE_LOADING_2D:
						PredefinedType = IfcAnalysisModelTypeEnum.OUT_PLANE_LOADING_2D;
						return;
					case Ifc4.Interfaces.IfcAnalysisModelTypeEnum.LOADING_3D:
						PredefinedType = IfcAnalysisModelTypeEnum.LOADING_3D;
						return;
					case Ifc4.Interfaces.IfcAnalysisModelTypeEnum.USERDEFINED:
						PredefinedType = IfcAnalysisModelTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcAnalysisModelTypeEnum.NOTDEFINED:
						PredefinedType = IfcAnalysisModelTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralAnalysisModel), 7)]
		IIfcAxis2Placement3D IIfcStructuralAnalysisModel.OrientationOf2DPlane 
		{ 
			get
			{
				return OrientationOf2DPlane;
			} 
			set
			{
				OrientationOf2DPlane = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralAnalysisModel), 8)]
		IItemSet<IIfcStructuralLoadGroup> IIfcStructuralAnalysisModel.LoadedBy 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcStructuralLoadGroup, IIfcStructuralLoadGroup>(LoadedBy);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralAnalysisModel), 9)]
		IItemSet<IIfcStructuralResultGroup> IIfcStructuralAnalysisModel.HasResults 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcStructuralResultGroup, IIfcStructuralResultGroup>(HasResults);
			} 
		}

		private  IIfcObjectPlacement _sharedPlacement;


		[CrossSchemaAttribute(typeof(IIfcStructuralAnalysisModel), 10)]
		IIfcObjectPlacement IIfcStructuralAnalysisModel.SharedPlacement 
		{ 
			get
			{
				return _sharedPlacement;
			} 
			set
			{
				SetValue(v => _sharedPlacement = v, _sharedPlacement, value, "SharedPlacement", -10);
				
			}
		}
	//## Custom code
	//##
	}
}