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
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBooleanClippingResult
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBooleanClippingResult : IIfcBooleanResult
	{
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcBooleanClippingResult", 340)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBooleanClippingResult : IfcBooleanResult, IInstantiableEntity, IIfcBooleanClippingResult, IEqualityComparer<@IfcBooleanClippingResult>, IEquatable<@IfcBooleanClippingResult>
	{
		#region IIfcBooleanClippingResult explicit implementation
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBooleanClippingResult(IModel model) : base(model) 		{ 
			Model = model; 
		}






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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*FirstOperandType:('IFC4.IFCBOOLEANCLIPPINGRESULT' IN TYPEOF(FirstOperand));*/
		/*SecondOperandType:	SecondOperandType : ('IFC4.IFCHALFSPACESOLID' IN TYPEOF(SecondOperand));*/
		/*OperatorType:	OperatorType : Operator = DIFFERENCE;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBooleanClippingResult other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBooleanClippingResult
            var root = (@IfcBooleanClippingResult)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBooleanClippingResult left, @IfcBooleanClippingResult right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBooleanClippingResult left, @IfcBooleanClippingResult right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBooleanClippingResult x, @IfcBooleanClippingResult y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBooleanClippingResult obj)
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