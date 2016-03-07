// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTypeObject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTypeObject : IIfcObjectDefinition
	{
		IfcIdentifier? @ApplicableOccurrence { get; }
		IEnumerable<IIfcPropertySetDefinition> @HasPropertySets { get; }
		IEnumerable<IIfcRelDefinesByType> @Types {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcTypeObject", 42)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTypeObject : IfcObjectDefinition, IInstantiableEntity, IIfcTypeObject, IEqualityComparer<@IfcTypeObject>, IEquatable<@IfcTypeObject>
	{
		#region IIfcTypeObject explicit implementation
		IfcIdentifier? IIfcTypeObject.ApplicableOccurrence { get { return @ApplicableOccurrence; } }	
		IEnumerable<IIfcPropertySetDefinition> IIfcTypeObject.HasPropertySets { get { return @HasPropertySets; } }	
		 
		IEnumerable<IIfcRelDefinesByType> IIfcTypeObject.Types {  get { return @Types; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeObject(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertySets = new OptionalItemSet<IfcPropertySetDefinition>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _applicableOccurrence;
		private OptionalItemSet<IfcPropertySetDefinition> _hasPropertySets;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcIdentifier? @ApplicableOccurrence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _applicableOccurrence;
				((IPersistEntity)this).Activate(false);
				return _applicableOccurrence;
			} 
			set
			{
				SetValue( v =>  _applicableOccurrence = v, _applicableOccurrence, value,  "ApplicableOccurrence");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 13)]
		public OptionalItemSet<IfcPropertySetDefinition> @HasPropertySets 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasPropertySets;
				((IPersistEntity)this).Activate(false);
				return _hasPropertySets;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingType")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 14)]
		public IEnumerable<IfcRelDefinesByType> @Types 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => (e.RelatingType as IfcTypeObject) == this, "RelatingType", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_applicableOccurrence = value.StringVal;
					return;
				case 5: 
					if (_hasPropertySets == null) _hasPropertySets = new OptionalItemSet<IfcPropertySetDefinition>( this );
					_hasPropertySets.InternalAdd((IfcPropertySetDefinition)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NameRequired:	NameRequired : EXISTS(SELF\IfcRoot.Name);*/
		/*UniquePropertySetNames:	UniquePropertySetNames : (NOT(EXISTS(HasPropertySets))) OR IfcUniquePropertySetNames(HasPropertySets);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTypeObject other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTypeObject
            var root = (@IfcTypeObject)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTypeObject left, @IfcTypeObject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTypeObject left, @IfcTypeObject right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTypeObject x, @IfcTypeObject y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTypeObject obj)
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