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
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class @IfcRectangleProfileDef : IIfcRectangleProfileDef
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRectangleProfileDef.XDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(XDim);
			} 
			set
			{
				XDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRectangleProfileDef.YDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(YDim);
			} 
			set
			{
				YDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}