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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcWindowPanelProperties : IIfcWindowPanelProperties
	{
		Ifc4.Interfaces.IfcWindowPanelOperationEnum IIfcWindowPanelProperties.OperationType 
		{ 
			get
			{
				switch (OperationType)
				{
					case IfcWindowPanelOperationEnum.SIDEHUNGRIGHTHAND:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.SIDEHUNGRIGHTHAND;
					
					case IfcWindowPanelOperationEnum.SIDEHUNGLEFTHAND:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.SIDEHUNGLEFTHAND;
					
					case IfcWindowPanelOperationEnum.TILTANDTURNRIGHTHAND:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.TILTANDTURNRIGHTHAND;
					
					case IfcWindowPanelOperationEnum.TILTANDTURNLEFTHAND:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.TILTANDTURNLEFTHAND;
					
					case IfcWindowPanelOperationEnum.TOPHUNG:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.TOPHUNG;
					
					case IfcWindowPanelOperationEnum.BOTTOMHUNG:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.BOTTOMHUNG;
					
					case IfcWindowPanelOperationEnum.PIVOTHORIZONTAL:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.PIVOTHORIZONTAL;
					
					case IfcWindowPanelOperationEnum.PIVOTVERTICAL:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.PIVOTVERTICAL;
					
					case IfcWindowPanelOperationEnum.SLIDINGHORIZONTAL:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.SLIDINGHORIZONTAL;
					
					case IfcWindowPanelOperationEnum.SLIDINGVERTICAL:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.SLIDINGVERTICAL;
					
					case IfcWindowPanelOperationEnum.REMOVABLECASEMENT:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.REMOVABLECASEMENT;
					
					case IfcWindowPanelOperationEnum.FIXEDCASEMENT:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.FIXEDCASEMENT;
					
					case IfcWindowPanelOperationEnum.OTHEROPERATION:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.OTHEROPERATION;
					
					case IfcWindowPanelOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWindowPanelOperationEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.SIDEHUNGRIGHTHAND:
						OperationType = IfcWindowPanelOperationEnum.SIDEHUNGRIGHTHAND;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.SIDEHUNGLEFTHAND:
						OperationType = IfcWindowPanelOperationEnum.SIDEHUNGLEFTHAND;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.TILTANDTURNRIGHTHAND:
						OperationType = IfcWindowPanelOperationEnum.TILTANDTURNRIGHTHAND;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.TILTANDTURNLEFTHAND:
						OperationType = IfcWindowPanelOperationEnum.TILTANDTURNLEFTHAND;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.TOPHUNG:
						OperationType = IfcWindowPanelOperationEnum.TOPHUNG;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.BOTTOMHUNG:
						OperationType = IfcWindowPanelOperationEnum.BOTTOMHUNG;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.PIVOTHORIZONTAL:
						OperationType = IfcWindowPanelOperationEnum.PIVOTHORIZONTAL;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.PIVOTVERTICAL:
						OperationType = IfcWindowPanelOperationEnum.PIVOTVERTICAL;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.SLIDINGHORIZONTAL:
						OperationType = IfcWindowPanelOperationEnum.SLIDINGHORIZONTAL;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.SLIDINGVERTICAL:
						OperationType = IfcWindowPanelOperationEnum.SLIDINGVERTICAL;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.REMOVABLECASEMENT:
						OperationType = IfcWindowPanelOperationEnum.REMOVABLECASEMENT;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.FIXEDCASEMENT:
						OperationType = IfcWindowPanelOperationEnum.FIXEDCASEMENT;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.OTHEROPERATION:
						OperationType = IfcWindowPanelOperationEnum.OTHEROPERATION;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelOperationEnum.NOTDEFINED:
						OperationType = IfcWindowPanelOperationEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		Ifc4.Interfaces.IfcWindowPanelPositionEnum IIfcWindowPanelProperties.PanelPosition 
		{ 
			get
			{
				switch (PanelPosition)
				{
					case IfcWindowPanelPositionEnum.LEFT:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.LEFT;
					
					case IfcWindowPanelPositionEnum.MIDDLE:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.MIDDLE;
					
					case IfcWindowPanelPositionEnum.RIGHT:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.RIGHT;
					
					case IfcWindowPanelPositionEnum.BOTTOM:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.BOTTOM;
					
					case IfcWindowPanelPositionEnum.TOP:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.TOP;
					
					case IfcWindowPanelPositionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.LEFT:
						PanelPosition = IfcWindowPanelPositionEnum.LEFT;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.MIDDLE:
						PanelPosition = IfcWindowPanelPositionEnum.MIDDLE;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.RIGHT:
						PanelPosition = IfcWindowPanelPositionEnum.RIGHT;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.BOTTOM:
						PanelPosition = IfcWindowPanelPositionEnum.BOTTOM;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.TOP:
						PanelPosition = IfcWindowPanelPositionEnum.TOP;
						return;
					
					case Ifc4.Interfaces.IfcWindowPanelPositionEnum.NOTDEFINED:
						PanelPosition = IfcWindowPanelPositionEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindowPanelProperties.FrameDepth 
		{ 
			get
			{
				if (!FrameDepth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FrameDepth.Value);
			} 
			set
			{
				FrameDepth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindowPanelProperties.FrameThickness 
		{ 
			get
			{
				if (!FrameThickness.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FrameThickness.Value);
			} 
			set
			{
				FrameThickness = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		IIfcShapeAspect IIfcWindowPanelProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle;
			} 
			set
			{
				ShapeAspectStyle = value as RepresentationResource.IfcShapeAspect;
				
			}
		}
	//## Custom code
	//##
	}
}