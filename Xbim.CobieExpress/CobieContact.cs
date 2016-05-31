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
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieContact
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieContact : ICobieReferencedObject
	{
		string @Email { get;  set; }
		ICobieRole @Category { get;  set; }
		string @Company { get;  set; }
		string @Phone { get;  set; }
		string @Department { get;  set; }
		string @OrganizationCode { get;  set; }
		string @GivenName { get;  set; }
		string @FamilyName { get;  set; }
		string @Street { get;  set; }
		string @PostalBox { get;  set; }
		string @Town { get;  set; }
		string @StateRegion { get;  set; }
		string @PostalCode { get;  set; }
		string @Country { get;  set; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Contact", 12)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieContact : CobieReferencedObject, IInstantiableEntity, ICobieContact, IContainsEntityReferences, IEquatable<@CobieContact>
	{
		#region ICobieContact explicit implementation
		string ICobieContact.Email { 
 
			get { return @Email; } 
			set { Email = value;}
		}	
		ICobieRole ICobieContact.Category { 
 
 
			get { return @Category; } 
			set { Category = value as CobieRole;}
		}	
		string ICobieContact.Company { 
 
			get { return @Company; } 
			set { Company = value;}
		}	
		string ICobieContact.Phone { 
 
			get { return @Phone; } 
			set { Phone = value;}
		}	
		string ICobieContact.Department { 
 
			get { return @Department; } 
			set { Department = value;}
		}	
		string ICobieContact.OrganizationCode { 
 
			get { return @OrganizationCode; } 
			set { OrganizationCode = value;}
		}	
		string ICobieContact.GivenName { 
 
			get { return @GivenName; } 
			set { GivenName = value;}
		}	
		string ICobieContact.FamilyName { 
 
			get { return @FamilyName; } 
			set { FamilyName = value;}
		}	
		string ICobieContact.Street { 
 
			get { return @Street; } 
			set { Street = value;}
		}	
		string ICobieContact.PostalBox { 
 
			get { return @PostalBox; } 
			set { PostalBox = value;}
		}	
		string ICobieContact.Town { 
 
			get { return @Town; } 
			set { Town = value;}
		}	
		string ICobieContact.StateRegion { 
 
			get { return @StateRegion; } 
			set { StateRegion = value;}
		}	
		string ICobieContact.PostalCode { 
 
			get { return @PostalCode; } 
			set { PostalCode = value;}
		}	
		string ICobieContact.Country { 
 
			get { return @Country; } 
			set { Country = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieContact(IModel model) : base(model) 		{ 
		}

		#region Explicit attribute fields
		private string _email;
		private CobieRole _category;
		private string _company;
		private string _phone;
		private string _department;
		private string _organizationCode;
		private string _givenName;
		private string _familyName;
		private string _street;
		private string _postalBox;
		private string _town;
		private string _stateRegion;
		private string _postalCode;
		private string _country;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public string @Email 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _email;
				((IPersistEntity)this).Activate(false);
				return _email;
			} 
			set
			{
				SetValue( v =>  _email = v, _email, value,  "Email", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public CobieRole @Category 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _category;
				((IPersistEntity)this).Activate(false);
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public string @Company 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _company;
				((IPersistEntity)this).Activate(false);
				return _company;
			} 
			set
			{
				SetValue( v =>  _company = v, _company, value,  "Company", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public string @Phone 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _phone;
				((IPersistEntity)this).Activate(false);
				return _phone;
			} 
			set
			{
				SetValue( v =>  _phone = v, _phone, value,  "Phone", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public string @Department 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _department;
				((IPersistEntity)this).Activate(false);
				return _department;
			} 
			set
			{
				SetValue( v =>  _department = v, _department, value,  "Department", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public string @OrganizationCode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _organizationCode;
				((IPersistEntity)this).Activate(false);
				return _organizationCode;
			} 
			set
			{
				SetValue( v =>  _organizationCode = v, _organizationCode, value,  "OrganizationCode", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public string @GivenName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _givenName;
				((IPersistEntity)this).Activate(false);
				return _givenName;
			} 
			set
			{
				SetValue( v =>  _givenName = v, _givenName, value,  "GivenName", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public string @FamilyName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _familyName;
				((IPersistEntity)this).Activate(false);
				return _familyName;
			} 
			set
			{
				SetValue( v =>  _familyName = v, _familyName, value,  "FamilyName", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public string @Street 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _street;
				((IPersistEntity)this).Activate(false);
				return _street;
			} 
			set
			{
				SetValue( v =>  _street = v, _street, value,  "Street", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public string @PostalBox 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _postalBox;
				((IPersistEntity)this).Activate(false);
				return _postalBox;
			} 
			set
			{
				SetValue( v =>  _postalBox = v, _postalBox, value,  "PostalBox", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public string @Town 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _town;
				((IPersistEntity)this).Activate(false);
				return _town;
			} 
			set
			{
				SetValue( v =>  _town = v, _town, value,  "Town", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public string @StateRegion 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _stateRegion;
				((IPersistEntity)this).Activate(false);
				return _stateRegion;
			} 
			set
			{
				SetValue( v =>  _stateRegion = v, _stateRegion, value,  "StateRegion", 17);
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 18)]
		public string @PostalCode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _postalCode;
				((IPersistEntity)this).Activate(false);
				return _postalCode;
			} 
			set
			{
				SetValue( v =>  _postalCode = v, _postalCode, value,  "PostalCode", 18);
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 19)]
		public string @Country 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _country;
				((IPersistEntity)this).Activate(false);
				return _country;
			} 
			set
			{
				SetValue( v =>  _country = v, _country, value,  "Country", 19);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_email = value.StringVal;
					return;
				case 6: 
					_category = (CobieRole)(value.EntityVal);
					return;
				case 7: 
					_company = value.StringVal;
					return;
				case 8: 
					_phone = value.StringVal;
					return;
				case 9: 
					_department = value.StringVal;
					return;
				case 10: 
					_organizationCode = value.StringVal;
					return;
				case 11: 
					_givenName = value.StringVal;
					return;
				case 12: 
					_familyName = value.StringVal;
					return;
				case 13: 
					_street = value.StringVal;
					return;
				case 14: 
					_postalBox = value.StringVal;
					return;
				case 15: 
					_town = value.StringVal;
					return;
				case 16: 
					_stateRegion = value.StringVal;
					return;
				case 17: 
					_postalCode = value.StringVal;
					return;
				case 18: 
					_country = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieContact other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieContact
            var root = (@CobieContact)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieContact left, @CobieContact right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@CobieContact left, @CobieContact right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Created != null)
					yield return @Created;
				if (@ExternalSystem != null)
					yield return @ExternalSystem;
				if (@ExternalObject != null)
					yield return @ExternalObject;
				if (@Category != null)
					yield return @Category;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}