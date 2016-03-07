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
using Xbim.Ifc4.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextLiteralWithExtent
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextLiteralWithExtent : IIfcTextLiteral
	{
		IIfcPlanarExtent @Extent { get; }
		IfcBoxAlignment @BoxAlignment { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationDefinitionResource
{
	[ExpressType("IfcTextLiteralWithExtent", 426)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextLiteralWithExtent : IfcTextLiteral, IInstantiableEntity, IIfcTextLiteralWithExtent, IEqualityComparer<@IfcTextLiteralWithExtent>, IEquatable<@IfcTextLiteralWithExtent>
	{
		#region IIfcTextLiteralWithExtent explicit implementation
		IIfcPlanarExtent IIfcTextLiteralWithExtent.Extent { get { return @Extent; } }	
		IfcBoxAlignment IIfcTextLiteralWithExtent.BoxAlignment { get { return @BoxAlignment; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextLiteralWithExtent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPlanarExtent _extent;
		private IfcBoxAlignment _boxAlignment;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcPlanarExtent @Extent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _extent;
				((IPersistEntity)this).Activate(false);
				return _extent;
			} 
			set
			{
				SetValue( v =>  _extent = v, _extent, value,  "Extent");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcBoxAlignment @BoxAlignment 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boxAlignment;
				((IPersistEntity)this).Activate(false);
				return _boxAlignment;
			} 
			set
			{
				SetValue( v =>  _boxAlignment = v, _boxAlignment, value,  "BoxAlignment");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_extent = (IfcPlanarExtent)(value.EntityVal);
					return;
				case 4: 
					_boxAlignment = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT('IFC4.IFCPLANARBOX' IN TYPEOF(Extent));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextLiteralWithExtent other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextLiteralWithExtent
            var root = (@IfcTextLiteralWithExtent)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextLiteralWithExtent left, @IfcTextLiteralWithExtent right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextLiteralWithExtent left, @IfcTextLiteralWithExtent right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextLiteralWithExtent x, @IfcTextLiteralWithExtent y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextLiteralWithExtent obj)
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