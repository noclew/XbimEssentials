// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.SharedBldgElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindowType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindowType : IIfcBuildingElementType
	{
		IfcWindowTypeEnum @PredefinedType { get; }
		IfcWindowTypePartitioningEnum @PartitioningType { get; }
		IfcBoolean? @ParameterTakesPrecedence { get; }
		IfcLabel? @UserDefinedPartitioningType { get; }
	
	}
}

namespace Xbim.Ifc4.SharedBldgElements
{
	[ExpressType("IfcWindowType", 1317)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowType : IfcBuildingElementType, IInstantiableEntity, IIfcWindowType, IEqualityComparer<@IfcWindowType>, IEquatable<@IfcWindowType>
	{
		#region IIfcWindowType explicit implementation
		IfcWindowTypeEnum IIfcWindowType.PredefinedType { get { return @PredefinedType; } }	
		IfcWindowTypePartitioningEnum IIfcWindowType.PartitioningType { get { return @PartitioningType; } }	
		IfcBoolean? IIfcWindowType.ParameterTakesPrecedence { get { return @ParameterTakesPrecedence; } }	
		IfcLabel? IIfcWindowType.UserDefinedPartitioningType { get { return @UserDefinedPartitioningType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWindowTypeEnum _predefinedType;
		private IfcWindowTypePartitioningEnum _partitioningType;
		private IfcBoolean? _parameterTakesPrecedence;
		private IfcLabel? _userDefinedPartitioningType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 19)]
		public IfcWindowTypeEnum @PredefinedType 
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
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 20)]
		public IfcWindowTypePartitioningEnum @PartitioningType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _partitioningType;
				((IPersistEntity)this).Activate(false);
				return _partitioningType;
			} 
			set
			{
				SetValue( v =>  _partitioningType = v, _partitioningType, value,  "PartitioningType");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcBoolean? @ParameterTakesPrecedence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parameterTakesPrecedence;
				((IPersistEntity)this).Activate(false);
				return _parameterTakesPrecedence;
			} 
			set
			{
				SetValue( v =>  _parameterTakesPrecedence = v, _parameterTakesPrecedence, value,  "ParameterTakesPrecedence");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public IfcLabel? @UserDefinedPartitioningType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedPartitioningType;
				((IPersistEntity)this).Activate(false);
				return _userDefinedPartitioningType;
			} 
			set
			{
				SetValue( v =>  _userDefinedPartitioningType = v, _userDefinedPartitioningType, value,  "UserDefinedPartitioningType");
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
                    _predefinedType = (IfcWindowTypeEnum) System.Enum.Parse(typeof (IfcWindowTypeEnum), value.EnumVal, true);
					return;
				case 10: 
                    _partitioningType = (IfcWindowTypePartitioningEnum) System.Enum.Parse(typeof (IfcWindowTypePartitioningEnum), value.EnumVal, true);
					return;
				case 11: 
					_parameterTakesPrecedence = value.BooleanVal;
					return;
				case 12: 
					_userDefinedPartitioningType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:((PredefinedType = IfcWindowTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindowType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWindowType
            var root = (@IfcWindowType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWindowType left, @IfcWindowType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWindowType left, @IfcWindowType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcWindowType x, @IfcWindowType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcWindowType obj)
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