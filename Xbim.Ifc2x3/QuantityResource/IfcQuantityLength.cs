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
using Xbim.Ifc2x3.QuantityResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcQuantityLength
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcQuantityLength : IIfcPhysicalSimpleQuantity
	{
		IfcLengthMeasure @LengthValue { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.QuantityResource
{
	[ExpressType("IfcQuantityLength", 527)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityLength : IfcPhysicalSimpleQuantity, IInstantiableEntity, IIfcQuantityLength, IContainsEntityReferences, IEquatable<@IfcQuantityLength>
	{
		#region IIfcQuantityLength explicit implementation
		IfcLengthMeasure IIfcQuantityLength.LengthValue { 
 
			get { return @LengthValue; } 
			set { LengthValue = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityLength(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _lengthValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcLengthMeasure @LengthValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lengthValue;
				((IPersistEntity)this).Activate(false);
				return _lengthValue;
			} 
			set
			{
				SetValue( v =>  _lengthValue = v, _lengthValue, value,  "LengthValue", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_lengthValue = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityLength other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcQuantityLength
            var root = (@IfcQuantityLength)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcQuantityLength left, @IfcQuantityLength right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcQuantityLength left, @IfcQuantityLength right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}