// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.RepresentationResource;
//## Custom using statements
using Xbim.Common.Geometry;
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGeometricRepresentationSubContext
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGeometricRepresentationSubContext : IIfcGeometricRepresentationContext
	{
		IIfcGeometricRepresentationContext @ParentContext { get; }
		IfcPositiveRatioMeasure? @TargetScale { get; }
		IfcGeometricProjectionEnum @TargetView { get; }
		IfcLabel? @UserDefinedTargetView { get; }
	
	}
}

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IfcGeometricRepresentationSubContext", 556)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext, IInstantiableEntity, IIfcGeometricRepresentationSubContext, IEqualityComparer<@IfcGeometricRepresentationSubContext>, IEquatable<@IfcGeometricRepresentationSubContext>
	{
		#region IIfcGeometricRepresentationSubContext explicit implementation
		IIfcGeometricRepresentationContext IIfcGeometricRepresentationSubContext.ParentContext { get { return @ParentContext; } }	
		IfcPositiveRatioMeasure? IIfcGeometricRepresentationSubContext.TargetScale { get { return @TargetScale; } }	
		IfcGeometricProjectionEnum IIfcGeometricRepresentationSubContext.TargetView { get { return @TargetView; } }	
		IfcLabel? IIfcGeometricRepresentationSubContext.UserDefinedTargetView { get { return @UserDefinedTargetView; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationSubContext(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcGeometricRepresentationContext _parentContext;
		private IfcPositiveRatioMeasure? _targetScale;
		private IfcGeometricProjectionEnum _targetView;
		private IfcLabel? _userDefinedTargetView;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public IfcGeometricRepresentationContext @ParentContext 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parentContext;
				((IPersistEntity)this).Activate(false);
				return _parentContext;
			} 
			set
			{
				SetValue( v =>  _parentContext = v, _parentContext, value,  "ParentContext");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcPositiveRatioMeasure? @TargetScale 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _targetScale;
				((IPersistEntity)this).Activate(false);
				return _targetScale;
			} 
			set
			{
				SetValue( v =>  _targetScale = v, _targetScale, value,  "TargetScale");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 12)]
		public IfcGeometricProjectionEnum @TargetView 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _targetView;
				((IPersistEntity)this).Activate(false);
				return _targetView;
			} 
			set
			{
				SetValue( v =>  _targetView = v, _targetView, value,  "TargetView");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcLabel? @UserDefinedTargetView 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedTargetView;
				((IPersistEntity)this).Activate(false);
				return _userDefinedTargetView;
			} 
			set
			{
				SetValue( v =>  _userDefinedTargetView = v, _userDefinedTargetView, value,  "UserDefinedTargetView");
			} 
		}	
		#endregion

		#region Overriding attributes
		[EntityAttribute(5, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public override IfcAxis2Placement @WorldCoordinateSystem 
		{
			get 
			{
				return ParentContext.WorldCoordinateSystem;
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property WorldCoordinateSystem in IfcGeometricRepresentationSubContext"); 
			}
		}
		[EntityAttribute(3, EntityAttributeState.DerivedOverride, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public override IfcDimensionCount @CoordinateSpaceDimension 
		{
			get 
			{
				return ParentContext.CoordinateSpaceDimension;
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property CoordinateSpaceDimension in IfcGeometricRepresentationSubContext"); 
			}
		}
		[EntityAttribute(6, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public override IfcDirection @TrueNorth 
		{
			get 
			{
				//## Overriding derived attribute TrueNorth getter
			    if (ParentContext.TrueNorth != null)
			        return ParentContext.TrueNorth;
                //IfcConvertDirectionInto2D(SELF\IfcGeometricRepresentationContext.WorldCoordinateSystem.P[2]));
			    var dir = new XbimVector3D(WorldCoordinateSystem.P[2].X, WorldCoordinateSystem.P[2].Y, double.NaN);			   
			    return dir;
			    //##
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property TrueNorth in IfcGeometricRepresentationSubContext"); 
			}
		}
		[EntityAttribute(4, EntityAttributeState.DerivedOverride, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public override IfcReal? @Precision 
		{
			get 
			{
				return ParentContext.Precision ?? 1E-05;
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property Precision in IfcGeometricRepresentationSubContext"); 
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_parentContext = (IfcGeometricRepresentationContext)(value.EntityVal);
					return;
				case 7: 
					_targetScale = value.RealVal;
					return;
				case 8: 
                    _targetView = (IfcGeometricProjectionEnum) System.Enum.Parse(typeof (IfcGeometricProjectionEnum), value.EnumVal, true);
					return;
				case 9: 
					_userDefinedTargetView = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ParentNoSub:	ParentNoSub : NOT('IFC4.IFCGEOMETRICREPRESENTATIONSUBCONTEXT' IN TYPEOF(ParentContext));*/
		/*UserTargetProvided:((TargetView =  IfcGeometricProjectionEnum.USERDEFINED) AND EXISTS(UserDefinedTargetView));*/
		/*NoCoordOperation:	NoCoordOperation : SIZEOF(SELF\IfcGeometricRepresentationContext.HasCoordinateOperation) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGeometricRepresentationSubContext other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcGeometricRepresentationSubContext
            var root = (@IfcGeometricRepresentationSubContext)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcGeometricRepresentationSubContext left, @IfcGeometricRepresentationSubContext right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcGeometricRepresentationSubContext left, @IfcGeometricRepresentationSubContext right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcGeometricRepresentationSubContext x, @IfcGeometricRepresentationSubContext y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcGeometricRepresentationSubContext obj)
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