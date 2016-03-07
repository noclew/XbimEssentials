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
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFaceBound
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFaceBound : IIfcTopologicalRepresentationItem
	{
		IIfcLoop @Bound { get; }
		bool @Orientation { get; }
	
	}
}

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IfcFaceBound", 86)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFaceBound : IfcTopologicalRepresentationItem, IInstantiableEntity, IIfcFaceBound, IEqualityComparer<@IfcFaceBound>, IEquatable<@IfcFaceBound>
	{
		#region IIfcFaceBound explicit implementation
		IIfcLoop IIfcFaceBound.Bound { get { return @Bound; } }	
		bool IIfcFaceBound.Orientation { get { return @Orientation; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFaceBound(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLoop _bound;
		private bool _orientation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcLoop @Bound 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _bound;
				((IPersistEntity)this).Activate(false);
				return _bound;
			} 
			set
			{
				SetValue( v =>  _bound = v, _bound, value,  "Bound");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public bool @Orientation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _orientation;
				((IPersistEntity)this).Activate(false);
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_bound = (IfcLoop)(value.EntityVal);
					return;
				case 1: 
					_orientation = value.BooleanVal;
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
        public bool Equals(@IfcFaceBound other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFaceBound
            var root = (@IfcFaceBound)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFaceBound left, @IfcFaceBound right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFaceBound left, @IfcFaceBound right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFaceBound x, @IfcFaceBound y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFaceBound obj)
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