// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBooleanResult
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBooleanResult : IIfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect
	{
		IfcBooleanOperator @Operator { get; }
		IIfcBooleanOperand @FirstOperand { get; }
		IIfcBooleanOperand @SecondOperand { get; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcBooleanResult", 339)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBooleanResult : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcBooleanResult, IEqualityComparer<@IfcBooleanResult>, IEquatable<@IfcBooleanResult>
	{
		#region IIfcBooleanResult explicit implementation
		IfcBooleanOperator IIfcBooleanResult.Operator { get { return @Operator; } }	
		IIfcBooleanOperand IIfcBooleanResult.FirstOperand { get { return @FirstOperand; } }	
		IIfcBooleanOperand IIfcBooleanResult.SecondOperand { get { return @SecondOperand; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBooleanResult(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBooleanOperator _operator;
		private IfcBooleanOperand _firstOperand;
		private IfcBooleanOperand _secondOperand;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 3)]
		public IfcBooleanOperator @Operator 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operator;
				((IPersistEntity)this).Activate(false);
				return _operator;
			} 
			set
			{
				SetValue( v =>  _operator = v, _operator, value,  "Operator");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcBooleanOperand @FirstOperand 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _firstOperand;
				((IPersistEntity)this).Activate(false);
				return _firstOperand;
			} 
			set
			{
				SetValue( v =>  _firstOperand = v, _firstOperand, value,  "FirstOperand");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcBooleanOperand @SecondOperand 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _secondOperand;
				((IPersistEntity)this).Activate(false);
				return _secondOperand;
			} 
			set
			{
				SetValue( v =>  _secondOperand = v, _secondOperand, value,  "SecondOperand");
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
                return _firstOperand.Dim;
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
                    _operator = (IfcBooleanOperator) System.Enum.Parse(typeof (IfcBooleanOperator), value.EnumVal, true);
					return;
				case 1: 
					_firstOperand = (IfcBooleanOperand)(value.EntityVal);
					return;
				case 2: 
					_secondOperand = (IfcBooleanOperand)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*SameDim:	SameDim : FirstOperand.Dim = SecondOperand.Dim;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBooleanResult other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBooleanResult
            var root = (@IfcBooleanResult)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBooleanResult left, @IfcBooleanResult right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBooleanResult left, @IfcBooleanResult right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBooleanResult x, @IfcBooleanResult y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBooleanResult obj)
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