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
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertyReferenceValue : IIfcPropertyReferenceValue
	{
		Ifc4.MeasureResource.IfcText? IIfcPropertyReferenceValue.UsageName 
		{ 
			get
			{
				if (!UsageName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(UsageName.Value);
			} 
			set
			{
				UsageName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		private  IIfcObjectReferenceSelect _propertyReference4;

		IIfcObjectReferenceSelect IIfcPropertyReferenceValue.PropertyReference 
		{ 
			get
			{
				if (_propertyReference4 != null) return _propertyReference4;
				if (PropertyReference == null) return null;
				var ifcmaterial = PropertyReference as MaterialResource.IfcMaterial;
				if (ifcmaterial != null) 
					//## Handle entity IfcMaterial which is not a part of the target select interface IIfcObjectReferenceSelect in property PropertyReference
			        return ifcmaterial;
					//##
				var ifcperson = PropertyReference as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcdateandtime = PropertyReference as DateTimeResource.IfcDateAndTime;
				if (ifcdateandtime != null) 
					//## Handle entity IfcDateAndTime which is not a part of the target select interface IIfcObjectReferenceSelect in property PropertyReference
			    {
                    //IIfcObjectReferenceSelect does not excepts a DataTime return
			    }
					//##
				var ifcmateriallist = PropertyReference as MaterialResource.IfcMaterialList;
				if (ifcmateriallist != null) 
					//## Handle entity IfcMaterialList which is not a part of the target select interface IIfcObjectReferenceSelect in property PropertyReference
			    {
                    //we should use IfcMaterialConstituentSet but this is not implemented
			    }
					//##
				var ifcorganization = PropertyReference as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifccalendardate = PropertyReference as DateTimeResource.IfcCalendarDate;
				if (ifccalendardate != null) 
					//## Handle entity IfcCalendarDate which is not a part of the target select interface IIfcObjectReferenceSelect in property PropertyReference
			    {
                    //IIfcObjectReferenceSelect does not excepts a Data return
			    }
					//##
				var ifclocaltime = PropertyReference as DateTimeResource.IfcLocalTime;
				if (ifclocaltime != null) 
					//## Handle entity IfcLocalTime which is not a part of the target select interface IIfcObjectReferenceSelect in property PropertyReference
                {
                    //IIfcObjectReferenceSelect does not excepts a Time return
                }
					//##
				var ifcpersonandorganization = PropertyReference as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				var ifcmateriallayer = PropertyReference as MaterialResource.IfcMaterialLayer;
				if (ifcmateriallayer != null) 
					//## Handle entity IfcMaterialLayer which is not a part of the target select interface IIfcObjectReferenceSelect in property PropertyReference
			        return ifcmateriallayer;
					//##
				var ifcexternalreference = PropertyReference as ExternalReferenceResource.IfcExternalReference;
				if (ifcexternalreference != null) 
					return ifcexternalreference;
				var ifctimeseries = PropertyReference as TimeSeriesResource.IfcTimeSeries;
				if (ifctimeseries != null) 
					return ifctimeseries;
				var ifcaddress = PropertyReference as ActorResource.IfcAddress;
				if (ifcaddress != null) 
					return ifcaddress;
				var ifcappliedvalue = PropertyReference as CostResource.IfcAppliedValue;
				if (ifcappliedvalue != null) 
					return ifcappliedvalue;
				return null;
			} 
			set
			{
				if (value == null)
				{
					PropertyReference = null;
					return;
				}	
				var ifcaddress = value as ActorResource.IfcAddress;
				if (ifcaddress != null) 
				{
					PropertyReference = ifcaddress;
					if (_propertyReference4 != null)
						SetValue(v => _propertyReference4 = v, _propertyReference4, null, "PropertyReference", byte.MaxValue);
					return;
				}
				var ifcappliedvalue = value as CostResource.IfcAppliedValue;
				if (ifcappliedvalue != null) 
				{
					PropertyReference = ifcappliedvalue;
					if (_propertyReference4 != null)
						SetValue(v => _propertyReference4 = v, _propertyReference4, null, "PropertyReference", byte.MaxValue);
					return;
				}
				var ifcexternalreference = value as ExternalReferenceResource.IfcExternalReference;
				if (ifcexternalreference != null) 
				{
					PropertyReference = ifcexternalreference;
					if (_propertyReference4 != null)
						SetValue(v => _propertyReference4 = v, _propertyReference4, null, "PropertyReference", byte.MaxValue);
					return;
				}
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					PropertyReference = ifcorganization;
					if (_propertyReference4 != null)
						SetValue(v => _propertyReference4 = v, _propertyReference4, null, "PropertyReference", byte.MaxValue);
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					PropertyReference = ifcperson;
					if (_propertyReference4 != null)
						SetValue(v => _propertyReference4 = v, _propertyReference4, null, "PropertyReference", byte.MaxValue);
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					PropertyReference = ifcpersonandorganization;
					if (_propertyReference4 != null)
						SetValue(v => _propertyReference4 = v, _propertyReference4, null, "PropertyReference", byte.MaxValue);
					return;
				}
				var ifctable = value as UtilityResource.IfcTable;
				if (ifctable != null) 
				{
					//## Handle setting of entity IfcTable which is not a part of the target select interface IIfcObjectReferenceSelect in property PropertyReference
				    if (PropertyReference != null)
				        PropertyReference = null;
                    SetValue(v => _propertyReference4 = v, _propertyReference4, value, "PropertyReference", byte.MaxValue);
                    return;
					//##
				}
				var ifctimeseries = value as TimeSeriesResource.IfcTimeSeries;
				if (ifctimeseries != null) 
				{
					PropertyReference = ifctimeseries;
					if (_propertyReference4 != null)
						SetValue(v => _propertyReference4 = v, _propertyReference4, null, "PropertyReference", byte.MaxValue);
					return;
				}
				
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