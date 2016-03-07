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
using Xbim.Ifc2x3.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ArchitectureDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSpaceProgram
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSpaceProgram : IIfcControl
	{
		IfcIdentifier @SpaceProgramIdentifier { get; }
		IfcAreaMeasure? @MaxRequiredArea { get; }
		IfcAreaMeasure? @MinRequiredArea { get; }
		IIfcSpatialStructureElement @RequestedLocation { get; }
		IfcAreaMeasure @StandardRequiredArea { get; }
		IEnumerable<IIfcRelInteractionRequirements> @HasInteractionReqsFrom {  get; }
		IEnumerable<IIfcRelInteractionRequirements> @HasInteractionReqsTo {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ArchitectureDomain
{
	[ExpressType("IfcSpaceProgram", 709)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSpaceProgram : IfcControl, IInstantiableEntity, IIfcSpaceProgram, IEqualityComparer<@IfcSpaceProgram>, IEquatable<@IfcSpaceProgram>
	{
		#region IIfcSpaceProgram explicit implementation
		IfcIdentifier IIfcSpaceProgram.SpaceProgramIdentifier { get { return @SpaceProgramIdentifier; } }	
		IfcAreaMeasure? IIfcSpaceProgram.MaxRequiredArea { get { return @MaxRequiredArea; } }	
		IfcAreaMeasure? IIfcSpaceProgram.MinRequiredArea { get { return @MinRequiredArea; } }	
		IIfcSpatialStructureElement IIfcSpaceProgram.RequestedLocation { get { return @RequestedLocation; } }	
		IfcAreaMeasure IIfcSpaceProgram.StandardRequiredArea { get { return @StandardRequiredArea; } }	
		 
		IEnumerable<IIfcRelInteractionRequirements> IIfcSpaceProgram.HasInteractionReqsFrom {  get { return @HasInteractionReqsFrom; } }
		IEnumerable<IIfcRelInteractionRequirements> IIfcSpaceProgram.HasInteractionReqsTo {  get { return @HasInteractionReqsTo; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpaceProgram(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _spaceProgramIdentifier;
		private IfcAreaMeasure? _maxRequiredArea;
		private IfcAreaMeasure? _minRequiredArea;
		private IfcSpatialStructureElement _requestedLocation;
		private IfcAreaMeasure _standardRequiredArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcIdentifier @SpaceProgramIdentifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _spaceProgramIdentifier;
				((IPersistEntity)this).Activate(false);
				return _spaceProgramIdentifier;
			} 
			set
			{
				SetValue( v =>  _spaceProgramIdentifier = v, _spaceProgramIdentifier, value,  "SpaceProgramIdentifier");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcAreaMeasure? @MaxRequiredArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _maxRequiredArea;
				((IPersistEntity)this).Activate(false);
				return _maxRequiredArea;
			} 
			set
			{
				SetValue( v =>  _maxRequiredArea = v, _maxRequiredArea, value,  "MaxRequiredArea");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcAreaMeasure? @MinRequiredArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _minRequiredArea;
				((IPersistEntity)this).Activate(false);
				return _minRequiredArea;
			} 
			set
			{
				SetValue( v =>  _minRequiredArea = v, _minRequiredArea, value,  "MinRequiredArea");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public IfcSpatialStructureElement @RequestedLocation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _requestedLocation;
				((IPersistEntity)this).Activate(false);
				return _requestedLocation;
			} 
			set
			{
				SetValue( v =>  _requestedLocation = v, _requestedLocation, value,  "RequestedLocation");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public IfcAreaMeasure @StandardRequiredArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _standardRequiredArea;
				((IPersistEntity)this).Activate(false);
				return _standardRequiredArea;
			} 
			set
			{
				SetValue( v =>  _standardRequiredArea = v, _standardRequiredArea, value,  "StandardRequiredArea");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedSpaceProgram")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 17)]
		public IEnumerable<IfcRelInteractionRequirements> @HasInteractionReqsFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelInteractionRequirements>(e => (e.RelatedSpaceProgram as IfcSpaceProgram) == this, "RelatedSpaceProgram", this);
			} 
		}
		[InverseProperty("RelatingSpaceProgram")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 18)]
		public IEnumerable<IfcRelInteractionRequirements> @HasInteractionReqsTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelInteractionRequirements>(e => (e.RelatingSpaceProgram as IfcSpaceProgram) == this, "RelatingSpaceProgram", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_spaceProgramIdentifier = value.StringVal;
					return;
				case 6: 
					_maxRequiredArea = value.RealVal;
					return;
				case 7: 
					_minRequiredArea = value.RealVal;
					return;
				case 8: 
					_requestedLocation = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				case 9: 
					_standardRequiredArea = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSpaceProgram other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSpaceProgram
            var root = (@IfcSpaceProgram)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSpaceProgram left, @IfcSpaceProgram right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSpaceProgram left, @IfcSpaceProgram right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSpaceProgram x, @IfcSpaceProgram y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSpaceProgram obj)
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