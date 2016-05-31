// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDoorPanelProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDoorPanelProperties : IIfcPropertySetDefinition
	{
		IfcPositiveLengthMeasure? @PanelDepth { get;  set; }
		IfcDoorPanelOperationEnum @PanelOperation { get;  set; }
		IfcNormalisedRatioMeasure? @PanelWidth { get;  set; }
		IfcDoorPanelPositionEnum @PanelPosition { get;  set; }
		IIfcShapeAspect @ShapeAspectStyle { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IfcDoorPanelProperties", 602)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoorPanelProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcDoorPanelProperties, IContainsEntityReferences, IEquatable<@IfcDoorPanelProperties>
	{
		#region IIfcDoorPanelProperties explicit implementation
		IfcPositiveLengthMeasure? IIfcDoorPanelProperties.PanelDepth { 
 
			get { return @PanelDepth; } 
			set { PanelDepth = value;}
		}	
		IfcDoorPanelOperationEnum IIfcDoorPanelProperties.PanelOperation { 
 
			get { return @PanelOperation; } 
			set { PanelOperation = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcDoorPanelProperties.PanelWidth { 
 
			get { return @PanelWidth; } 
			set { PanelWidth = value;}
		}	
		IfcDoorPanelPositionEnum IIfcDoorPanelProperties.PanelPosition { 
 
			get { return @PanelPosition; } 
			set { PanelPosition = value;}
		}	
		IIfcShapeAspect IIfcDoorPanelProperties.ShapeAspectStyle { 
 
 
			get { return @ShapeAspectStyle; } 
			set { ShapeAspectStyle = value as IfcShapeAspect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorPanelProperties(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _panelDepth;
		private IfcDoorPanelOperationEnum _panelOperation;
		private IfcNormalisedRatioMeasure? _panelWidth;
		private IfcDoorPanelPositionEnum _panelPosition;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcPositiveLengthMeasure? @PanelDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _panelDepth;
				((IPersistEntity)this).Activate(false);
				return _panelDepth;
			} 
			set
			{
				SetValue( v =>  _panelDepth = v, _panelDepth, value,  "PanelDepth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 9)]
		public IfcDoorPanelOperationEnum @PanelOperation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _panelOperation;
				((IPersistEntity)this).Activate(false);
				return _panelOperation;
			} 
			set
			{
				SetValue( v =>  _panelOperation = v, _panelOperation, value,  "PanelOperation", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcNormalisedRatioMeasure? @PanelWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _panelWidth;
				((IPersistEntity)this).Activate(false);
				return _panelWidth;
			} 
			set
			{
				SetValue( v =>  _panelWidth = v, _panelWidth, value,  "PanelWidth", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 11)]
		public IfcDoorPanelPositionEnum @PanelPosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _panelPosition;
				((IPersistEntity)this).Activate(false);
				return _panelPosition;
			} 
			set
			{
				SetValue( v =>  _panelPosition = v, _panelPosition, value,  "PanelPosition", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shapeAspectStyle;
				((IPersistEntity)this).Activate(false);
				return _shapeAspectStyle;
			} 
			set
			{
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle", 9);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_panelDepth = value.RealVal;
					return;
				case 5: 
                    _panelOperation = (IfcDoorPanelOperationEnum) System.Enum.Parse(typeof (IfcDoorPanelOperationEnum), value.EnumVal, true);
					return;
				case 6: 
					_panelWidth = value.RealVal;
					return;
				case 7: 
                    _panelPosition = (IfcDoorPanelPositionEnum) System.Enum.Parse(typeof (IfcDoorPanelPositionEnum), value.EnumVal, true);
					return;
				case 8: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDoorPanelProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDoorPanelProperties
            var root = (@IfcDoorPanelProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDoorPanelProperties left, @IfcDoorPanelProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcDoorPanelProperties left, @IfcDoorPanelProperties right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ShapeAspectStyle != null)
					yield return @ShapeAspectStyle;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}