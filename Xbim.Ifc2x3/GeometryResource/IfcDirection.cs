// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.StructuralAnalysisDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDirection
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDirection : IIfcGeometricRepresentationItem, IfcOrientationSelect, IfcVectorOrDirection
	{
		IItemSet<double> @DirectionRatios { get; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcDirection", 344)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDirection : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcDirection, IEquatable<@IfcDirection>
	{
		#region IIfcDirection explicit implementation
		IItemSet<double> IIfcDirection.DirectionRatios { 
			get { return @DirectionRatios; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDirection(IModel model) : base(model) 		{ 
			_directionRatios = new ItemSet<double>( this, 3,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<double> _directionRatios;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, 3, 3)]
		public IItemSet<double> @DirectionRatios 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _directionRatios;
				((IPersistEntity)this).Activate(false);
				return _directionRatios;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
                return DirectionRatios.Count;
				//##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_directionRatios.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDirection other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDirection
            var root = (@IfcDirection)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDirection left, @IfcDirection right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcDirection left, @IfcDirection right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcDirection left, IfcOrientationSelect right)
		{
			return left == right as @IfcDirection;
		}

		public static bool operator !=(@IfcDirection left, IfcOrientationSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcDirection left, IfcVectorOrDirection right)
		{
			return left == right as @IfcDirection;
		}

		public static bool operator !=(@IfcDirection left, IfcVectorOrDirection right)
		{
			return !(left == right);
		}

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
        /// <summary>
        /// Do not use this conversion operator unless you are absolutely sure you know what you do.
        /// Resulting object is not a properpart of the model and will throw an exception if you
        /// try to modify it or anything. It is only used in IfcGeometricRepresentationSubContext.TrueNorth where
        /// derived attribute is returned in derived overwriting attribute.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static implicit operator IfcDirection(Common.Geometry.XbimVector3D vector)  // explicit byte to digit conversion operator
        {
            var result = new IfcDirection(null);
            result._directionRatios.InternalAdd(vector.X);
            result._directionRatios.InternalAdd(vector.Y);
            result._directionRatios.InternalAdd(vector.Z);
            result.ActivationStatus = ActivationStatus.ActivatedRead;
            result.EntityLabel = -1;
            return result;
        }
		//##
		#endregion
	}
}