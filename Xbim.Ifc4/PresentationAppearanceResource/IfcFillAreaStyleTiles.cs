// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFillAreaStyleTiles
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFillAreaStyleTiles : IIfcGeometricRepresentationItem, IfcFillStyleSelect
	{
		IEnumerable<IIfcVector> @TilingPattern { get; }
		IEnumerable<IIfcStyledItem> @Tiles { get; }
		IfcPositiveRatioMeasure @TilingScale { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcFillAreaStyleTiles", 725)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyleTiles : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcFillAreaStyleTiles, IEqualityComparer<@IfcFillAreaStyleTiles>, IEquatable<@IfcFillAreaStyleTiles>
	{
		#region IIfcFillAreaStyleTiles explicit implementation
		IEnumerable<IIfcVector> IIfcFillAreaStyleTiles.TilingPattern { get { return @TilingPattern; } }	
		IEnumerable<IIfcStyledItem> IIfcFillAreaStyleTiles.Tiles { get { return @Tiles; } }	
		IfcPositiveRatioMeasure IIfcFillAreaStyleTiles.TilingScale { get { return @TilingScale; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleTiles(IModel model) : base(model) 		{ 
			Model = model; 
			_tilingPattern = new ItemSet<IfcVector>( this, 2 );
			_tiles = new ItemSet<IfcStyledItem>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcVector> _tilingPattern;
		private ItemSet<IfcStyledItem> _tiles;
		private IfcPositiveRatioMeasure _tilingScale;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, 2, 3)]
		public ItemSet<IfcVector> @TilingPattern 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tilingPattern;
				((IPersistEntity)this).Activate(false);
				return _tilingPattern;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 4)]
		public ItemSet<IfcStyledItem> @Tiles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tiles;
				((IPersistEntity)this).Activate(false);
				return _tiles;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveRatioMeasure @TilingScale 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tilingScale;
				((IPersistEntity)this).Activate(false);
				return _tilingScale;
			} 
			set
			{
				SetValue( v =>  _tilingScale = v, _tilingScale, value,  "TilingScale");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_tilingPattern == null) _tilingPattern = new ItemSet<IfcVector>( this );
					_tilingPattern.InternalAdd((IfcVector)value.EntityVal);
					return;
				case 1: 
					if (_tiles == null) _tiles = new ItemSet<IfcStyledItem>( this );
					_tiles.InternalAdd((IfcStyledItem)value.EntityVal);
					return;
				case 2: 
					_tilingScale = value.RealVal;
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
        public bool Equals(@IfcFillAreaStyleTiles other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFillAreaStyleTiles
            var root = (@IfcFillAreaStyleTiles)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFillAreaStyleTiles left, @IfcFillAreaStyleTiles right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFillAreaStyleTiles left, @IfcFillAreaStyleTiles right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFillAreaStyleTiles x, @IfcFillAreaStyleTiles y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFillAreaStyleTiles obj)
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