// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfilePropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGeneralProfileProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGeneralProfileProperties : IIfcProfileProperties
	{
		IfcMassPerLengthMeasure? @PhysicalWeight { get; }
		IfcPositiveLengthMeasure? @Perimeter { get; }
		IfcPositiveLengthMeasure? @MinimumPlateThickness { get; }
		IfcPositiveLengthMeasure? @MaximumPlateThickness { get; }
		IfcAreaMeasure? @CrossSectionArea { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcGeneralProfileProperties", 648)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeneralProfileProperties : IfcProfileProperties, IInstantiableEntity, IIfcGeneralProfileProperties, IEqualityComparer<@IfcGeneralProfileProperties>, IEquatable<@IfcGeneralProfileProperties>
	{
		#region IIfcGeneralProfileProperties explicit implementation
		IfcMassPerLengthMeasure? IIfcGeneralProfileProperties.PhysicalWeight { get { return @PhysicalWeight; } }	
		IfcPositiveLengthMeasure? IIfcGeneralProfileProperties.Perimeter { get { return @Perimeter; } }	
		IfcPositiveLengthMeasure? IIfcGeneralProfileProperties.MinimumPlateThickness { get { return @MinimumPlateThickness; } }	
		IfcPositiveLengthMeasure? IIfcGeneralProfileProperties.MaximumPlateThickness { get { return @MaximumPlateThickness; } }	
		IfcAreaMeasure? IIfcGeneralProfileProperties.CrossSectionArea { get { return @CrossSectionArea; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeneralProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMassPerLengthMeasure? _physicalWeight;
		private IfcPositiveLengthMeasure? _perimeter;
		private IfcPositiveLengthMeasure? _minimumPlateThickness;
		private IfcPositiveLengthMeasure? _maximumPlateThickness;
		private IfcAreaMeasure? _crossSectionArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcMassPerLengthMeasure? @PhysicalWeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _physicalWeight;
				((IPersistEntity)this).Activate(false);
				return _physicalWeight;
			} 
			set
			{
				SetValue( v =>  _physicalWeight = v, _physicalWeight, value,  "PhysicalWeight");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure? @Perimeter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _perimeter;
				((IPersistEntity)this).Activate(false);
				return _perimeter;
			} 
			set
			{
				SetValue( v =>  _perimeter = v, _perimeter, value,  "Perimeter");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure? @MinimumPlateThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _minimumPlateThickness;
				((IPersistEntity)this).Activate(false);
				return _minimumPlateThickness;
			} 
			set
			{
				SetValue( v =>  _minimumPlateThickness = v, _minimumPlateThickness, value,  "MinimumPlateThickness");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure? @MaximumPlateThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _maximumPlateThickness;
				((IPersistEntity)this).Activate(false);
				return _maximumPlateThickness;
			} 
			set
			{
				SetValue( v =>  _maximumPlateThickness = v, _maximumPlateThickness, value,  "MaximumPlateThickness");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcAreaMeasure? @CrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_physicalWeight = value.RealVal;
					return;
				case 3: 
					_perimeter = value.RealVal;
					return;
				case 4: 
					_minimumPlateThickness = value.RealVal;
					return;
				case 5: 
					_maximumPlateThickness = value.RealVal;
					return;
				case 6: 
					_crossSectionArea = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : NOT(EXISTS(CrossSectionArea)) OR (CrossSectionArea > 0.);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGeneralProfileProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcGeneralProfileProperties
            var root = (@IfcGeneralProfileProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcGeneralProfileProperties left, @IfcGeneralProfileProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcGeneralProfileProperties left, @IfcGeneralProfileProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcGeneralProfileProperties x, @IfcGeneralProfileProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcGeneralProfileProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}