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
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcSurfaceCurveSweptAreaSolid : IIfcSurfaceCurveSweptAreaSolid
	{
		IIfcCurve IIfcSurfaceCurveSweptAreaSolid.Directrix 
		{ 
			get
			{
				return Directrix;
			} 
			set
			{
				Directrix = value as GeometryResource.IfcCurve;
				
			}
		}
		Ifc4.MeasureResource.IfcParameterValue? IIfcSurfaceCurveSweptAreaSolid.StartParam 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(StartParam);
			} 
			set
			{
				StartParam = value.HasValue ? 
					new MeasureResource.IfcParameterValue(value.Value) :  
					 default(MeasureResource.IfcParameterValue) ;
				
			}
		}
		Ifc4.MeasureResource.IfcParameterValue? IIfcSurfaceCurveSweptAreaSolid.EndParam 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(EndParam);
			} 
			set
			{
				EndParam = value.HasValue ? 
					new MeasureResource.IfcParameterValue(value.Value) :  
					 default(MeasureResource.IfcParameterValue) ;
				
			}
		}
		IIfcSurface IIfcSurfaceCurveSweptAreaSolid.ReferenceSurface 
		{ 
			get
			{
				return ReferenceSurface;
			} 
			set
			{
				ReferenceSurface = value as GeometryResource.IfcSurface;
				
			}
		}
	//## Custom code
	//##
	}
}