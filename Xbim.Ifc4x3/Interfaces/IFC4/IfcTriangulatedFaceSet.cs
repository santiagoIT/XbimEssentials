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
namespace Xbim.Ifc4x3.GeometricModelResource
{
	public partial class @IfcTriangulatedFaceSet : IIfcTriangulatedFaceSet
	{

		[CrossSchemaAttribute(typeof(IIfcTriangulatedFaceSet), 2)]
		IItemSet<IItemSet<Xbim.Ifc4.MeasureResource.IfcParameterValue>> IIfcTriangulatedFaceSet.Normals 
		{ 
			get
			{
				return new Common.Collections.ProxyNestedValueSet<MeasureResource.IfcParameterValue, Ifc4.MeasureResource.IfcParameterValue>(Normals, 
					s => new Ifc4.MeasureResource.IfcParameterValue(s), 
					t => new MeasureResource.IfcParameterValue(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcTriangulatedFaceSet), 3)]
		Ifc4.MeasureResource.IfcBoolean? IIfcTriangulatedFaceSet.Closed 
		{ 
			get
			{
				if (!Closed.HasValue) return null;
				return new Ifc4.MeasureResource.IfcBoolean(Closed.Value);
			} 
			set
			{
				Closed = value.HasValue ? 
					new MeasureResource.IfcBoolean(value.Value) :  
					 new MeasureResource.IfcBoolean?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTriangulatedFaceSet), 4)]
		IItemSet<IItemSet<Xbim.Ifc4.MeasureResource.IfcPositiveInteger>> IIfcTriangulatedFaceSet.CoordIndex 
		{ 
			get
			{
				return new Common.Collections.ProxyNestedValueSet<MeasureResource.IfcPositiveInteger, Ifc4.MeasureResource.IfcPositiveInteger>(CoordIndex, 
					s => new Ifc4.MeasureResource.IfcPositiveInteger(s), 
					t => new MeasureResource.IfcPositiveInteger(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcTriangulatedFaceSet), 5)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcPositiveInteger> IIfcTriangulatedFaceSet.PnIndex 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcPositiveInteger, Ifc4.MeasureResource.IfcPositiveInteger>(PnIndex, 
					s => new Ifc4.MeasureResource.IfcPositiveInteger(s), 
					t => new MeasureResource.IfcPositiveInteger(t));
			} 
		}
		Ifc4.MeasureResource.IfcInteger IIfcTriangulatedFaceSet.NumberOfTriangles 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcInteger(NumberOfTriangles);
			}
		}

	//## Custom code
	//##
	}
}