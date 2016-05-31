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
	public partial class @IfcDoorPanelProperties : IIfcDoorPanelProperties
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcDoorPanelProperties.PanelDepth 
		{ 
			get
			{
				if (!PanelDepth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(PanelDepth.Value);
			} 
			set
			{
				PanelDepth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		Ifc4.Interfaces.IfcDoorPanelOperationEnum IIfcDoorPanelProperties.PanelOperation 
		{ 
			get
			{
				switch (PanelOperation)
				{
					case IfcDoorPanelOperationEnum.SWINGING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.SWINGING;
					
					case IfcDoorPanelOperationEnum.DOUBLE_ACTING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.DOUBLE_ACTING;
					
					case IfcDoorPanelOperationEnum.SLIDING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.SLIDING;
					
					case IfcDoorPanelOperationEnum.FOLDING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.FOLDING;
					
					case IfcDoorPanelOperationEnum.REVOLVING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.REVOLVING;
					
					case IfcDoorPanelOperationEnum.ROLLINGUP:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.ROLLINGUP;
					
					case IfcDoorPanelOperationEnum.USERDEFINED:
						//## Optional custom handling of PanelOperation == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.USERDEFINED;
					
					case IfcDoorPanelOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.SWINGING:
						PanelOperation = IfcDoorPanelOperationEnum.SWINGING;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.DOUBLE_ACTING:
						PanelOperation = IfcDoorPanelOperationEnum.DOUBLE_ACTING;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.SLIDING:
						PanelOperation = IfcDoorPanelOperationEnum.SLIDING;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.FOLDING:
						PanelOperation = IfcDoorPanelOperationEnum.FOLDING;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.REVOLVING:
						PanelOperation = IfcDoorPanelOperationEnum.REVOLVING;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.ROLLINGUP:
						PanelOperation = IfcDoorPanelOperationEnum.ROLLINGUP;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.FIXEDPANEL:
						//## Handle setting of FIXEDPANEL member from IfcDoorPanelOperationEnum in property PanelOperation
						//TODO: Handle setting of FIXEDPANEL member from IfcDoorPanelOperationEnum in property PanelOperation
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.USERDEFINED:
						PanelOperation = IfcDoorPanelOperationEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.NOTDEFINED:
						PanelOperation = IfcDoorPanelOperationEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcDoorPanelProperties.PanelWidth 
		{ 
			get
			{
				if (!PanelWidth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure(PanelWidth.Value);
			} 
			set
			{
				PanelWidth = value.HasValue ? 
					new MeasureResource.IfcNormalisedRatioMeasure(value.Value) :  
					 new MeasureResource.IfcNormalisedRatioMeasure?() ;
				
			}
		}
		Ifc4.Interfaces.IfcDoorPanelPositionEnum IIfcDoorPanelProperties.PanelPosition 
		{ 
			get
			{
				switch (PanelPosition)
				{
					case IfcDoorPanelPositionEnum.LEFT:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.LEFT;
					
					case IfcDoorPanelPositionEnum.MIDDLE:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.MIDDLE;
					
					case IfcDoorPanelPositionEnum.RIGHT:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.RIGHT;
					
					case IfcDoorPanelPositionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.LEFT:
						PanelPosition = IfcDoorPanelPositionEnum.LEFT;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.MIDDLE:
						PanelPosition = IfcDoorPanelPositionEnum.MIDDLE;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.RIGHT:
						PanelPosition = IfcDoorPanelPositionEnum.RIGHT;
						return;
					
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.NOTDEFINED:
						PanelPosition = IfcDoorPanelPositionEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IIfcShapeAspect IIfcDoorPanelProperties.ShapeAspectStyle 
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