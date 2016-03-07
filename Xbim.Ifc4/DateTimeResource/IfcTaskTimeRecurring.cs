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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTaskTimeRecurring
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTaskTimeRecurring : IIfcTaskTime
	{
		IIfcRecurrencePattern @Recurrence { get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcTaskTimeRecurring", 1295)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTaskTimeRecurring : IfcTaskTime, IInstantiableEntity, IIfcTaskTimeRecurring, IEqualityComparer<@IfcTaskTimeRecurring>, IEquatable<@IfcTaskTimeRecurring>
	{
		#region IIfcTaskTimeRecurring explicit implementation
		IIfcRecurrencePattern IIfcTaskTimeRecurring.Recurrence { get { return @Recurrence; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTaskTimeRecurring(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRecurrencePattern _recurrence;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(21, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 21)]
		public IfcRecurrencePattern @Recurrence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _recurrence;
				((IPersistEntity)this).Activate(false);
				return _recurrence;
			} 
			set
			{
				SetValue( v =>  _recurrence = v, _recurrence, value,  "Recurrence");
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
				case 9: 
				case 10: 
				case 11: 
				case 12: 
				case 13: 
				case 14: 
				case 15: 
				case 16: 
				case 17: 
				case 18: 
				case 19: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 20: 
					_recurrence = (IfcRecurrencePattern)(value.EntityVal);
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
        public bool Equals(@IfcTaskTimeRecurring other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTaskTimeRecurring
            var root = (@IfcTaskTimeRecurring)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTaskTimeRecurring left, @IfcTaskTimeRecurring right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTaskTimeRecurring left, @IfcTaskTimeRecurring right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTaskTimeRecurring x, @IfcTaskTimeRecurring y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTaskTimeRecurring obj)
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