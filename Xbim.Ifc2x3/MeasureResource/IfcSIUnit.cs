// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MeasureResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSIUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSIUnit : IIfcNamedUnit
	{
		IfcSIPrefix? @Prefix { get;  set; }
		IfcSIUnitName @Name { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IfcSIUnit", 164)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSIUnit : IfcNamedUnit, IInstantiableEntity, IIfcSIUnit, IContainsEntityReferences, IEquatable<@IfcSIUnit>
	{
		#region IIfcSIUnit explicit implementation
		IfcSIPrefix? IIfcSIUnit.Prefix { 
 
			get { return @Prefix; } 
			set { Prefix = value;}
		}	
		IfcSIUnitName IIfcSIUnit.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSIUnit(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcSIPrefix? _prefix;
		private IfcSIUnitName _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 3)]
		public IfcSIPrefix? @Prefix 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _prefix;
				((IPersistEntity)this).Activate(false);
				return _prefix;
			} 
			set
			{
				SetValue( v =>  _prefix = v, _prefix, value,  "Prefix", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 4)]
		public IfcSIUnitName @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 4);
			} 
		}	
		#endregion

		#region Overriding attributes
		[EntityAttribute(1, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public override IfcDimensionalExponents @Dimensions 
		{
			get 
			{
				return IfcDimensionsForSiUnit(Name);
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property Dimensions in IfcSIUnit"); 
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
                    _prefix = (IfcSIPrefix) System.Enum.Parse(typeof (IfcSIPrefix), value.EnumVal, true);
					return;
				case 3: 
                    _name = (IfcSIUnitName) System.Enum.Parse(typeof (IfcSIUnitName), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSIUnit other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSIUnit
            var root = (@IfcSIUnit)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSIUnit left, @IfcSIUnit right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcSIUnit left, @IfcSIUnit right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Dimensions != null)
					yield return @Dimensions;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}