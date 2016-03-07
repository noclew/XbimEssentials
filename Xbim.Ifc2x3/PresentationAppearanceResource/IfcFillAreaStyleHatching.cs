// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFillAreaStyleHatching
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFillAreaStyleHatching : IIfcGeometricRepresentationItem, IfcFillStyleSelect
	{
		IIfcCurveStyle @HatchLineAppearance { get; }
		IIfcHatchLineDistanceSelect @StartOfNextHatchLine { get; }
		IIfcCartesianPoint @PointOfReferenceHatchLine { get; }
		IIfcCartesianPoint @PatternStart { get; }
		IfcPlaneAngleMeasure @HatchLineAngle { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcFillAreaStyleHatching", 462)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyleHatching : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcFillAreaStyleHatching, IEqualityComparer<@IfcFillAreaStyleHatching>, IEquatable<@IfcFillAreaStyleHatching>
	{
		#region IIfcFillAreaStyleHatching explicit implementation
		IIfcCurveStyle IIfcFillAreaStyleHatching.HatchLineAppearance { get { return @HatchLineAppearance; } }	
		IIfcHatchLineDistanceSelect IIfcFillAreaStyleHatching.StartOfNextHatchLine { get { return @StartOfNextHatchLine; } }	
		IIfcCartesianPoint IIfcFillAreaStyleHatching.PointOfReferenceHatchLine { get { return @PointOfReferenceHatchLine; } }	
		IIfcCartesianPoint IIfcFillAreaStyleHatching.PatternStart { get { return @PatternStart; } }	
		IfcPlaneAngleMeasure IIfcFillAreaStyleHatching.HatchLineAngle { get { return @HatchLineAngle; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleHatching(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurveStyle _hatchLineAppearance;
		private IfcHatchLineDistanceSelect _startOfNextHatchLine;
		private IfcCartesianPoint _pointOfReferenceHatchLine;
		private IfcCartesianPoint _patternStart;
		private IfcPlaneAngleMeasure _hatchLineAngle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcCurveStyle @HatchLineAppearance 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hatchLineAppearance;
				((IPersistEntity)this).Activate(false);
				return _hatchLineAppearance;
			} 
			set
			{
				SetValue( v =>  _hatchLineAppearance = v, _hatchLineAppearance, value,  "HatchLineAppearance");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcHatchLineDistanceSelect @StartOfNextHatchLine 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startOfNextHatchLine;
				((IPersistEntity)this).Activate(false);
				return _startOfNextHatchLine;
			} 
			set
			{
				SetValue( v =>  _startOfNextHatchLine = v, _startOfNextHatchLine, value,  "StartOfNextHatchLine");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcCartesianPoint @PointOfReferenceHatchLine 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pointOfReferenceHatchLine;
				((IPersistEntity)this).Activate(false);
				return _pointOfReferenceHatchLine;
			} 
			set
			{
				SetValue( v =>  _pointOfReferenceHatchLine = v, _pointOfReferenceHatchLine, value,  "PointOfReferenceHatchLine");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcCartesianPoint @PatternStart 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _patternStart;
				((IPersistEntity)this).Activate(false);
				return _patternStart;
			} 
			set
			{
				SetValue( v =>  _patternStart = v, _patternStart, value,  "PatternStart");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcPlaneAngleMeasure @HatchLineAngle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hatchLineAngle;
				((IPersistEntity)this).Activate(false);
				return _hatchLineAngle;
			} 
			set
			{
				SetValue( v =>  _hatchLineAngle = v, _hatchLineAngle, value,  "HatchLineAngle");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_hatchLineAppearance = (IfcCurveStyle)(value.EntityVal);
					return;
				case 1: 
					_startOfNextHatchLine = (IfcHatchLineDistanceSelect)(value.EntityVal);
					return;
				case 2: 
					_pointOfReferenceHatchLine = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 3: 
					_patternStart = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 4: 
					_hatchLineAngle = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             );*/
		/*WR22:             OR (PatternStart.Dim = 2);*/
		/*WR23:             OR (PointOfReferenceHatchLine.Dim = 2);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFillAreaStyleHatching other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFillAreaStyleHatching
            var root = (@IfcFillAreaStyleHatching)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFillAreaStyleHatching left, @IfcFillAreaStyleHatching right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFillAreaStyleHatching left, @IfcFillAreaStyleHatching right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFillAreaStyleHatching x, @IfcFillAreaStyleHatching y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFillAreaStyleHatching obj)
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