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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcSurfaceStyleShading : IIfcSurfaceStyleShading
	{
		IIfcColourRgb IIfcSurfaceStyleShading.SurfaceColour 
		{ 
			get
			{
				return SurfaceColour;
			} 
		}
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcSurfaceStyleShading.Transparency 
		{ 
			get
			{
				//## Handle return of Transparency for which no match was found
                var rendering = this as IfcSurfaceStyleRendering;
                if (rendering != null && rendering.Transparency.HasValue)
                    return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)rendering.Transparency);
                return null;   
				//##
			} 
		}

	//## Custom code
	//##
	}
}