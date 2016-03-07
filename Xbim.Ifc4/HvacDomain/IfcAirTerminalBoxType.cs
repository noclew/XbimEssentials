// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.SharedBldgServiceElements;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.HvacDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAirTerminalBoxType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAirTerminalBoxType : IIfcFlowControllerType
	{
		IfcAirTerminalBoxTypeEnum @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc4.HvacDomain
{
	[ExpressType("IfcAirTerminalBoxType", 332)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAirTerminalBoxType : IfcFlowControllerType, IInstantiableEntity, IIfcAirTerminalBoxType, IEqualityComparer<@IfcAirTerminalBoxType>, IEquatable<@IfcAirTerminalBoxType>
	{
		#region IIfcAirTerminalBoxType explicit implementation
		IfcAirTerminalBoxTypeEnum IIfcAirTerminalBoxType.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAirTerminalBoxType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAirTerminalBoxTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 19)]
		public IfcAirTerminalBoxTypeEnum @PredefinedType 
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
                    _predefinedType = (IfcAirTerminalBoxTypeEnum) System.Enum.Parse(typeof (IfcAirTerminalBoxTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:((PredefinedType = IfcAirTerminalBoxTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAirTerminalBoxType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAirTerminalBoxType
            var root = (@IfcAirTerminalBoxType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAirTerminalBoxType left, @IfcAirTerminalBoxType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAirTerminalBoxType left, @IfcAirTerminalBoxType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAirTerminalBoxType x, @IfcAirTerminalBoxType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAirTerminalBoxType obj)
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