// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.CostResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurrencyRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurrencyRelationship : IIfcResourceLevelRelationship
	{
		IIfcMonetaryUnit @RelatingMonetaryUnit { get; }
		IIfcMonetaryUnit @RelatedMonetaryUnit { get; }
		IfcPositiveRatioMeasure @ExchangeRate { get; }
		IfcDateTime? @RateDateTime { get; }
		IIfcLibraryInformation @RateSource { get; }
	
	}
}

namespace Xbim.Ifc4.CostResource
{
	[ExpressType("IfcCurrencyRelationship", 195)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurrencyRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcCurrencyRelationship, IEqualityComparer<@IfcCurrencyRelationship>, IEquatable<@IfcCurrencyRelationship>
	{
		#region IIfcCurrencyRelationship explicit implementation
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatingMonetaryUnit { get { return @RelatingMonetaryUnit; } }	
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatedMonetaryUnit { get { return @RelatedMonetaryUnit; } }	
		IfcPositiveRatioMeasure IIfcCurrencyRelationship.ExchangeRate { get { return @ExchangeRate; } }	
		IfcDateTime? IIfcCurrencyRelationship.RateDateTime { get { return @RateDateTime; } }	
		IIfcLibraryInformation IIfcCurrencyRelationship.RateSource { get { return @RateSource; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurrencyRelationship(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMonetaryUnit _relatingMonetaryUnit;
		private IfcMonetaryUnit _relatedMonetaryUnit;
		private IfcPositiveRatioMeasure _exchangeRate;
		private IfcDateTime? _rateDateTime;
		private IfcLibraryInformation _rateSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcMonetaryUnit @RelatingMonetaryUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingMonetaryUnit;
				((IPersistEntity)this).Activate(false);
				return _relatingMonetaryUnit;
			} 
			set
			{
				SetValue( v =>  _relatingMonetaryUnit = v, _relatingMonetaryUnit, value,  "RelatingMonetaryUnit");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcMonetaryUnit @RelatedMonetaryUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedMonetaryUnit;
				((IPersistEntity)this).Activate(false);
				return _relatedMonetaryUnit;
			} 
			set
			{
				SetValue( v =>  _relatedMonetaryUnit = v, _relatedMonetaryUnit, value,  "RelatedMonetaryUnit");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveRatioMeasure @ExchangeRate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _exchangeRate;
				((IPersistEntity)this).Activate(false);
				return _exchangeRate;
			} 
			set
			{
				SetValue( v =>  _exchangeRate = v, _exchangeRate, value,  "ExchangeRate");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcDateTime? @RateDateTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rateDateTime;
				((IPersistEntity)this).Activate(false);
				return _rateDateTime;
			} 
			set
			{
				SetValue( v =>  _rateDateTime = v, _rateDateTime, value,  "RateDateTime");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcLibraryInformation @RateSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rateSource;
				((IPersistEntity)this).Activate(false);
				return _rateSource;
			} 
			set
			{
				SetValue( v =>  _rateSource = v, _rateSource, value,  "RateSource");
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
					_relatingMonetaryUnit = (IfcMonetaryUnit)(value.EntityVal);
					return;
				case 3: 
					_relatedMonetaryUnit = (IfcMonetaryUnit)(value.EntityVal);
					return;
				case 4: 
					_exchangeRate = value.RealVal;
					return;
				case 5: 
					_rateDateTime = value.StringVal;
					return;
				case 6: 
					_rateSource = (IfcLibraryInformation)(value.EntityVal);
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
        public bool Equals(@IfcCurrencyRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurrencyRelationship
            var root = (@IfcCurrencyRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurrencyRelationship left, @IfcCurrencyRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurrencyRelationship left, @IfcCurrencyRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCurrencyRelationship x, @IfcCurrencyRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCurrencyRelationship obj)
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