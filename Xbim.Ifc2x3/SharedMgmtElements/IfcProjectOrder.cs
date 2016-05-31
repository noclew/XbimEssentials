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
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedMgmtElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProjectOrder
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProjectOrder : IIfcControl
	{
		IfcIdentifier @ID { get;  set; }
		IfcProjectOrderTypeEnum @PredefinedType { get;  set; }
		IfcLabel? @Status { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedMgmtElements
{
	[ExpressType("IfcProjectOrder", 696)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProjectOrder : IfcControl, IInstantiableEntity, IIfcProjectOrder, IContainsEntityReferences, IEquatable<@IfcProjectOrder>
	{
		#region IIfcProjectOrder explicit implementation
		IfcIdentifier IIfcProjectOrder.ID { 
 
			get { return @ID; } 
			set { ID = value;}
		}	
		IfcProjectOrderTypeEnum IIfcProjectOrder.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IfcLabel? IIfcProjectOrder.Status { 
 
			get { return @Status; } 
			set { Status = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProjectOrder(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcIdentifier _iD;
		private IfcProjectOrderTypeEnum _predefinedType;
		private IfcLabel? _status;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcIdentifier @ID 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _iD;
				((IPersistEntity)this).Activate(false);
				return _iD;
			} 
			set
			{
				SetValue( v =>  _iD = v, _iD, value,  "ID", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 13)]
		public IfcProjectOrderTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _status;
				((IPersistEntity)this).Activate(false);
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status", 8);
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
					_iD = value.StringVal;
					return;
				case 6: 
                    _predefinedType = (IfcProjectOrderTypeEnum) System.Enum.Parse(typeof (IfcProjectOrderTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_status = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProjectOrder other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProjectOrder
            var root = (@IfcProjectOrder)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProjectOrder left, @IfcProjectOrder right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcProjectOrder left, @IfcProjectOrder right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}