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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcBSplineSurface : IIfcBSplineSurface
	{

		[CrossSchemaAttribute(typeof(IIfcBSplineSurface), 1)]
		Ifc4.MeasureResource.IfcInteger IIfcBSplineSurface.UDegree 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(UDegree);
			} 
			set
			{
				UDegree = new MeasureResource.IfcInteger(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBSplineSurface), 2)]
		Ifc4.MeasureResource.IfcInteger IIfcBSplineSurface.VDegree 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(VDegree);
			} 
			set
			{
				VDegree = new MeasureResource.IfcInteger(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBSplineSurface), 3)]
		IItemSet<IItemSet<IIfcCartesianPoint>> IIfcBSplineSurface.ControlPointsList 
		{ 
			get
			{
				return new Common.Collections.ProxyNestedItemSet<IfcCartesianPoint, IIfcCartesianPoint>(ControlPointsList);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcBSplineSurface), 4)]
		Ifc4.Interfaces.IfcBSplineSurfaceForm IIfcBSplineSurface.SurfaceForm 
		{ 
			get
			{
				//## Custom code to handle enumeration of SurfaceForm
				//##
				switch (SurfaceForm)
				{
					case IfcBSplineSurfaceForm.PLANE_SURF:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.PLANE_SURF;
					case IfcBSplineSurfaceForm.CYLINDRICAL_SURF:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.CYLINDRICAL_SURF;
					case IfcBSplineSurfaceForm.CONICAL_SURF:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.CONICAL_SURF;
					case IfcBSplineSurfaceForm.SPHERICAL_SURF:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.SPHERICAL_SURF;
					case IfcBSplineSurfaceForm.TOROIDAL_SURF:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.TOROIDAL_SURF;
					case IfcBSplineSurfaceForm.SURF_OF_REVOLUTION:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.SURF_OF_REVOLUTION;
					case IfcBSplineSurfaceForm.RULED_SURF:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.RULED_SURF;
					case IfcBSplineSurfaceForm.GENERALISED_CONE:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.GENERALISED_CONE;
					case IfcBSplineSurfaceForm.QUADRIC_SURF:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.QUADRIC_SURF;
					case IfcBSplineSurfaceForm.SURF_OF_LINEAR_EXTRUSION:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.SURF_OF_LINEAR_EXTRUSION;
					case IfcBSplineSurfaceForm.UNSPECIFIED:
						return Ifc4.Interfaces.IfcBSplineSurfaceForm.UNSPECIFIED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of SurfaceForm
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.PLANE_SURF:
						SurfaceForm = IfcBSplineSurfaceForm.PLANE_SURF;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.CYLINDRICAL_SURF:
						SurfaceForm = IfcBSplineSurfaceForm.CYLINDRICAL_SURF;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.CONICAL_SURF:
						SurfaceForm = IfcBSplineSurfaceForm.CONICAL_SURF;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.SPHERICAL_SURF:
						SurfaceForm = IfcBSplineSurfaceForm.SPHERICAL_SURF;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.TOROIDAL_SURF:
						SurfaceForm = IfcBSplineSurfaceForm.TOROIDAL_SURF;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.SURF_OF_REVOLUTION:
						SurfaceForm = IfcBSplineSurfaceForm.SURF_OF_REVOLUTION;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.RULED_SURF:
						SurfaceForm = IfcBSplineSurfaceForm.RULED_SURF;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.GENERALISED_CONE:
						SurfaceForm = IfcBSplineSurfaceForm.GENERALISED_CONE;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.QUADRIC_SURF:
						SurfaceForm = IfcBSplineSurfaceForm.QUADRIC_SURF;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.SURF_OF_LINEAR_EXTRUSION:
						SurfaceForm = IfcBSplineSurfaceForm.SURF_OF_LINEAR_EXTRUSION;
						return;
					case Ifc4.Interfaces.IfcBSplineSurfaceForm.UNSPECIFIED:
						SurfaceForm = IfcBSplineSurfaceForm.UNSPECIFIED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBSplineSurface), 5)]
		Ifc4.MeasureResource.IfcLogical IIfcBSplineSurface.UClosed 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLogical(UClosed);
			} 
			set
			{
				UClosed = new MeasureResource.IfcLogical(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBSplineSurface), 6)]
		Ifc4.MeasureResource.IfcLogical IIfcBSplineSurface.VClosed 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLogical(VClosed);
			} 
			set
			{
				VClosed = new MeasureResource.IfcLogical(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBSplineSurface), 7)]
		Ifc4.MeasureResource.IfcLogical IIfcBSplineSurface.SelfIntersect 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLogical(SelfIntersect);
			} 
			set
			{
				SelfIntersect = new MeasureResource.IfcLogical(value);
				
			}
		}
		Ifc4.MeasureResource.IfcInteger IIfcBSplineSurface.UUpper 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcInteger(UUpper);
			}
		}

		Ifc4.MeasureResource.IfcInteger IIfcBSplineSurface.VUpper 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcInteger(VUpper);
			}
		}

		List<List<Common.Geometry.XbimPoint3D>> IIfcBSplineSurface.ControlPoints 
		{
			get 
			{
				return ControlPoints;
			}
		}

	//## Custom code
	//##
	}
}