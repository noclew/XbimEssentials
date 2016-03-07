// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.StructuralElementsDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcingMesh
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcingMesh : IIfcReinforcingElement
	{
		IfcPositiveLengthMeasure? @MeshLength { get; }
		IfcPositiveLengthMeasure? @MeshWidth { get; }
		IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter { get; }
		IfcPositiveLengthMeasure? @TransverseBarNominalDiameter { get; }
		IfcAreaMeasure? @LongitudinalBarCrossSectionArea { get; }
		IfcAreaMeasure? @TransverseBarCrossSectionArea { get; }
		IfcPositiveLengthMeasure? @LongitudinalBarSpacing { get; }
		IfcPositiveLengthMeasure? @TransverseBarSpacing { get; }
		IfcReinforcingMeshTypeEnum? @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IfcReinforcingMesh", 531)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingMesh : IfcReinforcingElement, IInstantiableEntity, IIfcReinforcingMesh, IEqualityComparer<@IfcReinforcingMesh>, IEquatable<@IfcReinforcingMesh>
	{
		#region IIfcReinforcingMesh explicit implementation
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.MeshLength { get { return @MeshLength; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.MeshWidth { get { return @MeshWidth; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.LongitudinalBarNominalDiameter { get { return @LongitudinalBarNominalDiameter; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.TransverseBarNominalDiameter { get { return @TransverseBarNominalDiameter; } }	
		IfcAreaMeasure? IIfcReinforcingMesh.LongitudinalBarCrossSectionArea { get { return @LongitudinalBarCrossSectionArea; } }	
		IfcAreaMeasure? IIfcReinforcingMesh.TransverseBarCrossSectionArea { get { return @TransverseBarCrossSectionArea; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.LongitudinalBarSpacing { get { return @LongitudinalBarSpacing; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMesh.TransverseBarSpacing { get { return @TransverseBarSpacing; } }	
		IfcReinforcingMeshTypeEnum? IIfcReinforcingMesh.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingMesh(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _meshLength;
		private IfcPositiveLengthMeasure? _meshWidth;
		private IfcPositiveLengthMeasure? _longitudinalBarNominalDiameter;
		private IfcPositiveLengthMeasure? _transverseBarNominalDiameter;
		private IfcAreaMeasure? _longitudinalBarCrossSectionArea;
		private IfcAreaMeasure? _transverseBarCrossSectionArea;
		private IfcPositiveLengthMeasure? _longitudinalBarSpacing;
		private IfcPositiveLengthMeasure? _transverseBarSpacing;
		private IfcReinforcingMeshTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 34)]
		public IfcPositiveLengthMeasure? @MeshLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _meshLength;
				((IPersistEntity)this).Activate(false);
				return _meshLength;
			} 
			set
			{
				SetValue( v =>  _meshLength = v, _meshLength, value,  "MeshLength");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 35)]
		public IfcPositiveLengthMeasure? @MeshWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _meshWidth;
				((IPersistEntity)this).Activate(false);
				return _meshWidth;
			} 
			set
			{
				SetValue( v =>  _meshWidth = v, _meshWidth, value,  "MeshWidth");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 36)]
		public IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarNominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarNominalDiameter = v, _longitudinalBarNominalDiameter, value,  "LongitudinalBarNominalDiameter");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 37)]
		public IfcPositiveLengthMeasure? @TransverseBarNominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarNominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _transverseBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _transverseBarNominalDiameter = v, _transverseBarNominalDiameter, value,  "TransverseBarNominalDiameter");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 38)]
		public IfcAreaMeasure? @LongitudinalBarCrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarCrossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarCrossSectionArea = v, _longitudinalBarCrossSectionArea, value,  "LongitudinalBarCrossSectionArea");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 39)]
		public IfcAreaMeasure? @TransverseBarCrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarCrossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _transverseBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _transverseBarCrossSectionArea = v, _transverseBarCrossSectionArea, value,  "TransverseBarCrossSectionArea");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 40)]
		public IfcPositiveLengthMeasure? @LongitudinalBarSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarSpacing;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarSpacing;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarSpacing = v, _longitudinalBarSpacing, value,  "LongitudinalBarSpacing");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 41)]
		public IfcPositiveLengthMeasure? @TransverseBarSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarSpacing;
				((IPersistEntity)this).Activate(false);
				return _transverseBarSpacing;
			} 
			set
			{
				SetValue( v =>  _transverseBarSpacing = v, _transverseBarSpacing, value,  "TransverseBarSpacing");
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 42)]
		public IfcReinforcingMeshTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_meshLength = value.RealVal;
					return;
				case 10: 
					_meshWidth = value.RealVal;
					return;
				case 11: 
					_longitudinalBarNominalDiameter = value.RealVal;
					return;
				case 12: 
					_transverseBarNominalDiameter = value.RealVal;
					return;
				case 13: 
					_longitudinalBarCrossSectionArea = value.RealVal;
					return;
				case 14: 
					_transverseBarCrossSectionArea = value.RealVal;
					return;
				case 15: 
					_longitudinalBarSpacing = value.RealVal;
					return;
				case 16: 
					_transverseBarSpacing = value.RealVal;
					return;
				case 17: 
                    _predefinedType = (IfcReinforcingMeshTypeEnum) System.Enum.Parse(typeof (IfcReinforcingMeshTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:((PredefinedType = IfcReinforcingMeshTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:('IFC4.IFCREINFORCINGMESHTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingMesh other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcReinforcingMesh
            var root = (@IfcReinforcingMesh)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcReinforcingMesh left, @IfcReinforcingMesh right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcingMesh left, @IfcReinforcingMesh right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcReinforcingMesh x, @IfcReinforcingMesh y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcReinforcingMesh obj)
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