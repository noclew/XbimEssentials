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
using Xbim.Ifc2x3.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectionSurfaceGeometry
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionSurfaceGeometry : IIfcConnectionGeometry
	{
		IIfcSurfaceOrFaceSurface @SurfaceOnRelatingElement { get;  set; }
		IIfcSurfaceOrFaceSurface @SurfaceOnRelatedElement { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	[ExpressType("IfcConnectionSurfaceGeometry", 69)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionSurfaceGeometry : IfcConnectionGeometry, IInstantiableEntity, IIfcConnectionSurfaceGeometry, IContainsEntityReferences, IEquatable<@IfcConnectionSurfaceGeometry>
	{
		#region IIfcConnectionSurfaceGeometry explicit implementation
		IIfcSurfaceOrFaceSurface IIfcConnectionSurfaceGeometry.SurfaceOnRelatingElement { 
 
 
			get { return @SurfaceOnRelatingElement; } 
			set { SurfaceOnRelatingElement = value as IfcSurfaceOrFaceSurface;}
		}	
		IIfcSurfaceOrFaceSurface IIfcConnectionSurfaceGeometry.SurfaceOnRelatedElement { 
 
 
			get { return @SurfaceOnRelatedElement; } 
			set { SurfaceOnRelatedElement = value as IfcSurfaceOrFaceSurface;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionSurfaceGeometry(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private IfcSurfaceOrFaceSurface _surfaceOnRelatingElement;
		private IfcSurfaceOrFaceSurface _surfaceOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _surfaceOnRelatingElement;
				((IPersistEntity)this).Activate(false);
				return _surfaceOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _surfaceOnRelatingElement = v, _surfaceOnRelatingElement, value,  "SurfaceOnRelatingElement", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatedElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _surfaceOnRelatedElement;
				((IPersistEntity)this).Activate(false);
				return _surfaceOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _surfaceOnRelatedElement = v, _surfaceOnRelatedElement, value,  "SurfaceOnRelatedElement", 2);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_surfaceOnRelatingElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
					return;
				case 1: 
					_surfaceOnRelatedElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConnectionSurfaceGeometry other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConnectionSurfaceGeometry
            var root = (@IfcConnectionSurfaceGeometry)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConnectionSurfaceGeometry left, @IfcConnectionSurfaceGeometry right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcConnectionSurfaceGeometry left, @IfcConnectionSurfaceGeometry right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SurfaceOnRelatingElement != null)
					yield return @SurfaceOnRelatingElement;
				if (@SurfaceOnRelatedElement != null)
					yield return @SurfaceOnRelatedElement;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}