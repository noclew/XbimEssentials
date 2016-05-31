// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	public partial class @IfcSectionProperties : IIfcSectionProperties
	{
		Ifc4.Interfaces.IfcSectionTypeEnum IIfcSectionProperties.SectionType 
		{ 
			get
			{
				switch (SectionType)
				{
					case IfcSectionTypeEnum.UNIFORM:
						return Ifc4.Interfaces.IfcSectionTypeEnum.UNIFORM;
					
					case IfcSectionTypeEnum.TAPERED:
						return Ifc4.Interfaces.IfcSectionTypeEnum.TAPERED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcSectionTypeEnum.UNIFORM:
						SectionType = IfcSectionTypeEnum.UNIFORM;
						return;
					
					case Ifc4.Interfaces.IfcSectionTypeEnum.TAPERED:
						SectionType = IfcSectionTypeEnum.TAPERED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IIfcProfileDef IIfcSectionProperties.StartProfile 
		{ 
			get
			{
				return StartProfile;
			} 
			set
			{
				StartProfile = value as ProfileResource.IfcProfileDef;
				
			}
		}
		IIfcProfileDef IIfcSectionProperties.EndProfile 
		{ 
			get
			{
				return EndProfile;
			} 
			set
			{
				EndProfile = value as ProfileResource.IfcProfileDef;
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
	//## Custom code
	//##
	}
}