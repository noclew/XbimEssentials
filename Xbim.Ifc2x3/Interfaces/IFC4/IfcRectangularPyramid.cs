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
	public partial class @IfcRectangularPyramid : IIfcRectangularPyramid
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRectangularPyramid.XLength 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(XLength);
			} 
			set
			{
				XLength = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRectangularPyramid.YLength 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(YLength);
			} 
			set
			{
				YLength = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRectangularPyramid.Height 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Height);
			} 
			set
			{
				Height = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}