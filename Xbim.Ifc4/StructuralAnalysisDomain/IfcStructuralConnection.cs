// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.StructuralLoadResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralConnection
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralConnection : IIfcStructuralItem
	{
		IIfcBoundaryCondition @AppliedCondition { get; }
		IEnumerable<IIfcRelConnectsStructuralMember> @ConnectsStructuralMembers {  get; }
	
	}
}

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralConnection", 265)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcStructuralConnection : IfcStructuralItem, IIfcStructuralConnection, IEqualityComparer<@IfcStructuralConnection>, IEquatable<@IfcStructuralConnection>
	{
		#region IIfcStructuralConnection explicit implementation
		IIfcBoundaryCondition IIfcStructuralConnection.AppliedCondition { get { return @AppliedCondition; } }	
		 
		IEnumerable<IIfcRelConnectsStructuralMember> IIfcStructuralConnection.ConnectsStructuralMembers {  get { return @ConnectsStructuralMembers; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralConnection(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBoundaryCondition _appliedCondition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 21)]
		public IfcBoundaryCondition @AppliedCondition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _appliedCondition;
				((IPersistEntity)this).Activate(false);
				return _appliedCondition;
			} 
			set
			{
				SetValue( v =>  _appliedCondition = v, _appliedCondition, value,  "AppliedCondition");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedStructuralConnection")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 22)]
		public IEnumerable<IfcRelConnectsStructuralMember> @ConnectsStructuralMembers 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsStructuralMember>(e => (e.RelatedStructuralConnection as IfcStructuralConnection) == this, "RelatedStructuralConnection", this);
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
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_appliedCondition = (IfcBoundaryCondition)(value.EntityVal);
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
        public bool Equals(@IfcStructuralConnection other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralConnection
            var root = (@IfcStructuralConnection)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralConnection left, @IfcStructuralConnection right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralConnection left, @IfcStructuralConnection right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralConnection x, @IfcStructuralConnection y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralConnection obj)
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