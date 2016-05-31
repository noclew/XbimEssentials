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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationOrganizationResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightDistributionData
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightDistributionData : IPersistEntity
	{
		IfcPlaneAngleMeasure @MainPlaneAngle { get;  set; }
		IItemSet<IfcPlaneAngleMeasure> @SecondaryPlaneAngle { get; }
		IItemSet<IfcLuminousIntensityDistributionMeasure> @LuminousIntensity { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[ExpressType("IfcLightDistributionData", 753)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightDistributionData : INotifyPropertyChanged, IInstantiableEntity, IIfcLightDistributionData, IEquatable<@IfcLightDistributionData>
	{
		#region IIfcLightDistributionData explicit implementation
		IfcPlaneAngleMeasure IIfcLightDistributionData.MainPlaneAngle { 
 
			get { return @MainPlaneAngle; } 
			set { MainPlaneAngle = value;}
		}	
		IItemSet<IfcPlaneAngleMeasure> IIfcLightDistributionData.SecondaryPlaneAngle { 
			get { return @SecondaryPlaneAngle; } 
		}	
		IItemSet<IfcLuminousIntensityDistributionMeasure> IIfcLightDistributionData.LuminousIntensity { 
			get { return @LuminousIntensity; } 
		}	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightDistributionData(IModel model) 		{ 
			Model = model; 
			_secondaryPlaneAngle = new ItemSet<IfcPlaneAngleMeasure>( this, 0,  2);
			_luminousIntensity = new ItemSet<IfcLuminousIntensityDistributionMeasure>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcPlaneAngleMeasure _mainPlaneAngle;
		private readonly ItemSet<IfcPlaneAngleMeasure> _secondaryPlaneAngle;
		private readonly ItemSet<IfcLuminousIntensityDistributionMeasure> _luminousIntensity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcPlaneAngleMeasure @MainPlaneAngle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mainPlaneAngle;
				((IPersistEntity)this).Activate(false);
				return _mainPlaneAngle;
			} 
			set
			{
				SetValue( v =>  _mainPlaneAngle = v, _mainPlaneAngle, value,  "MainPlaneAngle", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 2)]
		public IItemSet<IfcPlaneAngleMeasure> @SecondaryPlaneAngle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _secondaryPlaneAngle;
				((IPersistEntity)this).Activate(false);
				return _secondaryPlaneAngle;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 3)]
		public IItemSet<IfcLuminousIntensityDistributionMeasure> @LuminousIntensity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _luminousIntensity;
				((IPersistEntity)this).Activate(false);
				return _luminousIntensity;
			} 
		}	
		#endregion




		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName, byte propertyOrder)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified, propertyOrder);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_mainPlaneAngle = value.RealVal;
					return;
				case 1: 
					_secondaryPlaneAngle.InternalAdd(value.RealVal);
					return;
				case 2: 
					_luminousIntensity.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLightDistributionData other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLightDistributionData
            var root = (@IfcLightDistributionData)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLightDistributionData left, @IfcLightDistributionData right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcLightDistributionData left, @IfcLightDistributionData right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}