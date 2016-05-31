// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProcessExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssignsTasks
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssignsTasks : IIfcRelAssignsToControl
	{
		IIfcScheduleTimeControl @TimeForTask { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProcessExtension
{
	[ExpressType("IfcRelAssignsTasks", 618)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsTasks : IfcRelAssignsToControl, IInstantiableEntity, IIfcRelAssignsTasks, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelAssignsTasks>
	{
		#region IIfcRelAssignsTasks explicit implementation
		IIfcScheduleTimeControl IIfcRelAssignsTasks.TimeForTask { 
 
 
			get { return @TimeForTask; } 
			set { TimeForTask = value as IfcScheduleTimeControl;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsTasks(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcScheduleTimeControl _timeForTask;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcScheduleTimeControl @TimeForTask 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _timeForTask;
				((IPersistEntity)this).Activate(false);
				return _timeForTask;
			} 
			set
			{
				SetValue( v =>  _timeForTask = v, _timeForTask, value,  "TimeForTask", 8);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_timeForTask = (IfcScheduleTimeControl)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssignsTasks other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssignsTasks
            var root = (@IfcRelAssignsTasks)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssignsTasks left, @IfcRelAssignsTasks right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcRelAssignsTasks left, @IfcRelAssignsTasks right)
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
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingControl != null)
					yield return @RelatingControl;
				if (@TimeForTask != null)
					yield return @TimeForTask;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingControl != null)
					yield return @RelatingControl;
				if (@TimeForTask != null)
					yield return @TimeForTask;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}