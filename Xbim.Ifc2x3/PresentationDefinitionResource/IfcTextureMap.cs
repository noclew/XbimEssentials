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
using Xbim.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextureMap
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureMap : IIfcTextureCoordinate
	{
		IEnumerable<IIfcVertexBasedTextureMap> @TextureMaps { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcTextureMap", 734)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureMap : IfcTextureCoordinate, IInstantiableEntity, IIfcTextureMap, IEqualityComparer<@IfcTextureMap>, IEquatable<@IfcTextureMap>
	{
		#region IIfcTextureMap explicit implementation
		IEnumerable<IIfcVertexBasedTextureMap> IIfcTextureMap.TextureMaps { get { return @TextureMaps; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureMap(IModel model) : base(model) 		{ 
			Model = model; 
			_textureMaps = new ItemSet<IfcVertexBasedTextureMap>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcVertexBasedTextureMap> _textureMaps;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 2)]
		public ItemSet<IfcVertexBasedTextureMap> @TextureMaps 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureMaps;
				((IPersistEntity)this).Activate(false);
				return _textureMaps;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_textureMaps == null) _textureMaps = new ItemSet<IfcVertexBasedTextureMap>( this );
					_textureMaps.InternalAdd((IfcVertexBasedTextureMap)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:               ) >= 1;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureMap other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextureMap
            var root = (@IfcTextureMap)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextureMap left, @IfcTextureMap right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextureMap left, @IfcTextureMap right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextureMap x, @IfcTextureMap y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextureMap obj)
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