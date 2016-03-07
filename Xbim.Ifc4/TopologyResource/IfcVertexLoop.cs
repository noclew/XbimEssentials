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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcVertexLoop
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcVertexLoop : IIfcLoop
	{
		IIfcVertex @LoopVertex { get; }
	
	}
}

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IfcVertexLoop", 244)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexLoop : IfcLoop, IInstantiableEntity, IIfcVertexLoop, IEqualityComparer<@IfcVertexLoop>, IEquatable<@IfcVertexLoop>
	{
		#region IIfcVertexLoop explicit implementation
		IIfcVertex IIfcVertexLoop.LoopVertex { get { return @LoopVertex; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexLoop(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVertex _loopVertex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcVertex @LoopVertex 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _loopVertex;
				((IPersistEntity)this).Activate(false);
				return _loopVertex;
			} 
			set
			{
				SetValue( v =>  _loopVertex = v, _loopVertex, value,  "LoopVertex");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_loopVertex = (IfcVertex)(value.EntityVal);
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
        public bool Equals(@IfcVertexLoop other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcVertexLoop
            var root = (@IfcVertexLoop)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcVertexLoop left, @IfcVertexLoop right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcVertexLoop left, @IfcVertexLoop right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcVertexLoop x, @IfcVertexLoop y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcVertexLoop obj)
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