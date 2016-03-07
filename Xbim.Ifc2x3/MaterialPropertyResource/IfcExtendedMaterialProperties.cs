// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcExtendedMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcExtendedMaterialProperties : IIfcMaterialProperties
	{
		IEnumerable<IIfcProperty> @ExtendedProperties { get; }
		IfcText? @Description { get; }
		IfcLabel @Name { get; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcExtendedMaterialProperties", 585)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcExtendedMaterialProperties : IfcMaterialProperties, IInstantiableEntity, IIfcExtendedMaterialProperties, IEqualityComparer<@IfcExtendedMaterialProperties>, IEquatable<@IfcExtendedMaterialProperties>
	{
		#region IIfcExtendedMaterialProperties explicit implementation
		IEnumerable<IIfcProperty> IIfcExtendedMaterialProperties.ExtendedProperties { get { return @ExtendedProperties; } }	
		IfcText? IIfcExtendedMaterialProperties.Description { get { return @Description; } }	
		IfcLabel IIfcExtendedMaterialProperties.Name { get { return @Name; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtendedMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_extendedProperties = new ItemSet<IfcProperty>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProperty> _extendedProperties;
		private IfcText? _description;
		private IfcLabel _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 2)]
		public ItemSet<IfcProperty> @ExtendedProperties 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _extendedProperties;
				((IPersistEntity)this).Activate(false);
				return _extendedProperties;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					if (_extendedProperties == null) _extendedProperties = new ItemSet<IfcProperty>( this );
					_extendedProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_name = value.StringVal;
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
        public bool Equals(@IfcExtendedMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcExtendedMaterialProperties
            var root = (@IfcExtendedMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcExtendedMaterialProperties left, @IfcExtendedMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcExtendedMaterialProperties left, @IfcExtendedMaterialProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcExtendedMaterialProperties x, @IfcExtendedMaterialProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcExtendedMaterialProperties obj)
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