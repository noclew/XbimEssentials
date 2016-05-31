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
    /// Readonly interface for IfcRibPlateProfileProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRibPlateProfileProperties : IIfcProfileProperties
	{
		IfcPositiveLengthMeasure? @Thickness { get;  set; }
		IfcPositiveLengthMeasure? @RibHeight { get;  set; }
		IfcPositiveLengthMeasure? @RibWidth { get;  set; }
		IfcPositiveLengthMeasure? @RibSpacing { get;  set; }
		IfcRibPlateDirectionEnum @Direction { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcRibPlateProfileProperties", 763)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRibPlateProfileProperties : IfcProfileProperties, IInstantiableEntity, IIfcRibPlateProfileProperties, IContainsEntityReferences, IEquatable<@IfcRibPlateProfileProperties>
	{
		#region IIfcRibPlateProfileProperties explicit implementation
		IfcPositiveLengthMeasure? IIfcRibPlateProfileProperties.Thickness { 
 
			get { return @Thickness; } 
			set { Thickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcRibPlateProfileProperties.RibHeight { 
 
			get { return @RibHeight; } 
			set { RibHeight = value;}
		}	
		IfcPositiveLengthMeasure? IIfcRibPlateProfileProperties.RibWidth { 
 
			get { return @RibWidth; } 
			set { RibWidth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcRibPlateProfileProperties.RibSpacing { 
 
			get { return @RibSpacing; } 
			set { RibSpacing = value;}
		}	
		IfcRibPlateDirectionEnum IIfcRibPlateProfileProperties.Direction { 
 
			get { return @Direction; } 
			set { Direction = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRibPlateProfileProperties(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _thickness;
		private IfcPositiveLengthMeasure? _ribHeight;
		private IfcPositiveLengthMeasure? _ribWidth;
		private IfcPositiveLengthMeasure? _ribSpacing;
		private IfcRibPlateDirectionEnum _direction;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcPositiveLengthMeasure? @Thickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thickness;
				((IPersistEntity)this).Activate(false);
				return _thickness;
			} 
			set
			{
				SetValue( v =>  _thickness = v, _thickness, value,  "Thickness", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure? @RibHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _ribHeight;
				((IPersistEntity)this).Activate(false);
				return _ribHeight;
			} 
			set
			{
				SetValue( v =>  _ribHeight = v, _ribHeight, value,  "RibHeight", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure? @RibWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _ribWidth;
				((IPersistEntity)this).Activate(false);
				return _ribWidth;
			} 
			set
			{
				SetValue( v =>  _ribWidth = v, _ribWidth, value,  "RibWidth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure? @RibSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _ribSpacing;
				((IPersistEntity)this).Activate(false);
				return _ribSpacing;
			} 
			set
			{
				SetValue( v =>  _ribSpacing = v, _ribSpacing, value,  "RibSpacing", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 7)]
		public IfcRibPlateDirectionEnum @Direction 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _direction;
				((IPersistEntity)this).Activate(false);
				return _direction;
			} 
			set
			{
				SetValue( v =>  _direction = v, _direction, value,  "Direction", 7);
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
					_thickness = value.RealVal;
					return;
				case 3: 
					_ribHeight = value.RealVal;
					return;
				case 4: 
					_ribWidth = value.RealVal;
					return;
				case 5: 
					_ribSpacing = value.RealVal;
					return;
				case 6: 
                    _direction = (IfcRibPlateDirectionEnum) System.Enum.Parse(typeof (IfcRibPlateDirectionEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRibPlateProfileProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRibPlateProfileProperties
            var root = (@IfcRibPlateProfileProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRibPlateProfileProperties left, @IfcRibPlateProfileProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcRibPlateProfileProperties left, @IfcRibPlateProfileProperties right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ProfileDefinition != null)
					yield return @ProfileDefinition;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}