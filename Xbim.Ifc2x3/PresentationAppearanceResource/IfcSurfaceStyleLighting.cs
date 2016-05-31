// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceStyleLighting
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceStyleLighting : IPersistEntity, IfcSurfaceStyleElementSelect
	{
		IIfcColourRgb @DiffuseTransmissionColour { get;  set; }
		IIfcColourRgb @DiffuseReflectionColour { get;  set; }
		IIfcColourRgb @TransmissionColour { get;  set; }
		IIfcColourRgb @ReflectanceColour { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceStyleLighting", 117)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleLighting : INotifyPropertyChanged, IInstantiableEntity, IIfcSurfaceStyleLighting, IContainsEntityReferences, IEquatable<@IfcSurfaceStyleLighting>
	{
		#region IIfcSurfaceStyleLighting explicit implementation
		IIfcColourRgb IIfcSurfaceStyleLighting.DiffuseTransmissionColour { 
 
 
			get { return @DiffuseTransmissionColour; } 
			set { DiffuseTransmissionColour = value as IfcColourRgb;}
		}	
		IIfcColourRgb IIfcSurfaceStyleLighting.DiffuseReflectionColour { 
 
 
			get { return @DiffuseReflectionColour; } 
			set { DiffuseReflectionColour = value as IfcColourRgb;}
		}	
		IIfcColourRgb IIfcSurfaceStyleLighting.TransmissionColour { 
 
 
			get { return @TransmissionColour; } 
			set { TransmissionColour = value as IfcColourRgb;}
		}	
		IIfcColourRgb IIfcSurfaceStyleLighting.ReflectanceColour { 
 
 
			get { return @ReflectanceColour; } 
			set { ReflectanceColour = value as IfcColourRgb;}
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
		internal IfcSurfaceStyleLighting(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcColourRgb _diffuseTransmissionColour;
		private IfcColourRgb _diffuseReflectionColour;
		private IfcColourRgb _transmissionColour;
		private IfcColourRgb _reflectanceColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcColourRgb @DiffuseTransmissionColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _diffuseTransmissionColour;
				((IPersistEntity)this).Activate(false);
				return _diffuseTransmissionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseTransmissionColour = v, _diffuseTransmissionColour, value,  "DiffuseTransmissionColour", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcColourRgb @DiffuseReflectionColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _diffuseReflectionColour;
				((IPersistEntity)this).Activate(false);
				return _diffuseReflectionColour;
			} 
			set
			{
				SetValue( v =>  _diffuseReflectionColour = v, _diffuseReflectionColour, value,  "DiffuseReflectionColour", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcColourRgb @TransmissionColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transmissionColour;
				((IPersistEntity)this).Activate(false);
				return _transmissionColour;
			} 
			set
			{
				SetValue( v =>  _transmissionColour = v, _transmissionColour, value,  "TransmissionColour", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcColourRgb @ReflectanceColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _reflectanceColour;
				((IPersistEntity)this).Activate(false);
				return _reflectanceColour;
			} 
			set
			{
				SetValue( v =>  _reflectanceColour = v, _reflectanceColour, value,  "ReflectanceColour", 4);
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
					_diffuseTransmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 1: 
					_diffuseReflectionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 2: 
					_transmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 3: 
					_reflectanceColour = (IfcColourRgb)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyleLighting other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceStyleLighting
            var root = (@IfcSurfaceStyleLighting)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceStyleLighting left, @IfcSurfaceStyleLighting right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcSurfaceStyleLighting left, @IfcSurfaceStyleLighting right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcSurfaceStyleLighting left, IfcSurfaceStyleElementSelect right)
		{
			return left == right as @IfcSurfaceStyleLighting;
		}

		public static bool operator !=(@IfcSurfaceStyleLighting left, IfcSurfaceStyleElementSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@DiffuseTransmissionColour != null)
					yield return @DiffuseTransmissionColour;
				if (@DiffuseReflectionColour != null)
					yield return @DiffuseReflectionColour;
				if (@TransmissionColour != null)
					yield return @TransmissionColour;
				if (@ReflectanceColour != null)
					yield return @ReflectanceColour;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}