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
using Xbim.Ifc2x3.ProcessExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTask
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTask : IIfcProcess
	{
		IfcIdentifier @TaskId { get; }
		IfcLabel? @Status { get; }
		IfcLabel? @WorkMethod { get; }
		bool @IsMilestone { get; }
		long? @Priority { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProcessExtension
{
	[ExpressType("IfcTask", 72)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTask : IfcProcess, IInstantiableEntity, IIfcTask, IEqualityComparer<@IfcTask>, IEquatable<@IfcTask>
	{
		#region IIfcTask explicit implementation
		IfcIdentifier IIfcTask.TaskId { get { return @TaskId; } }	
		IfcLabel? IIfcTask.Status { get { return @Status; } }	
		IfcLabel? IIfcTask.WorkMethod { get { return @WorkMethod; } }	
		bool IIfcTask.IsMilestone { get { return @IsMilestone; } }	
		long? IIfcTask.Priority { get { return @Priority; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTask(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _taskId;
		private IfcLabel? _status;
		private IfcLabel? _workMethod;
		private bool _isMilestone;
		private long? _priority;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcIdentifier @TaskId 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _taskId;
				((IPersistEntity)this).Activate(false);
				return _taskId;
			} 
			set
			{
				SetValue( v =>  _taskId = v, _taskId, value,  "TaskId");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
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
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public IfcLabel? @WorkMethod 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _workMethod;
				((IPersistEntity)this).Activate(false);
				return _workMethod;
			} 
			set
			{
				SetValue( v =>  _workMethod = v, _workMethod, value,  "WorkMethod");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public bool @IsMilestone 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isMilestone;
				((IPersistEntity)this).Activate(false);
				return _isMilestone;
			} 
			set
			{
				SetValue( v =>  _isMilestone = v, _isMilestone, value,  "IsMilestone");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 18)]
		public long? @Priority 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _priority;
				((IPersistEntity)this).Activate(false);
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority");
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
					_taskId = value.StringVal;
					return;
				case 6: 
					_status = value.StringVal;
					return;
				case 7: 
					_workMethod = value.StringVal;
					return;
				case 8: 
					_isMilestone = value.BooleanVal;
					return;
				case 9: 
					_priority = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.Decomposes | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.IsDecomposedBy | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR3:	WR3 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTask other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTask
            var root = (@IfcTask)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTask left, @IfcTask right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTask left, @IfcTask right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTask x, @IfcTask y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTask obj)
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