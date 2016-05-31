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
namespace Xbim.Ifc2x3.RepresentationResource
{
	public partial class @IfcRepresentation : IIfcRepresentation
	{
		IIfcRepresentationContext IIfcRepresentation.ContextOfItems 
		{ 
			get
			{
				return ContextOfItems;
			} 
			set
			{
				ContextOfItems = value as IfcRepresentationContext;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcRepresentation.RepresentationIdentifier 
		{ 
			get
			{
				if (!RepresentationIdentifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(RepresentationIdentifier.Value);
			} 
			set
			{
				RepresentationIdentifier = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcRepresentation.RepresentationType 
		{ 
			get
			{
				if (!RepresentationType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(RepresentationType.Value);
			} 
			set
			{
				RepresentationType = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IItemSet<IIfcRepresentationItem> IIfcRepresentation.Items 
		{ 
			get
			{
				foreach (var member in Items)
				{
					yield return member as IIfcRepresentationItem;
				}
			} 
		}
		IEnumerable<IIfcRepresentationMap> IIfcRepresentation.RepresentationMap 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRepresentationMap>(e => (e.MappedRepresentation as IfcRepresentation) == this, "MappedRepresentation", this);
			} 
		}
		IEnumerable<IIfcPresentationLayerAssignment> IIfcRepresentation.LayerAssignments 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPresentationLayerAssignment>(e => e.AssignedItems != null &&  e.AssignedItems.Contains(this), "AssignedItems", this);
			} 
		}
		IEnumerable<IIfcProductRepresentation> IIfcRepresentation.OfProductRepresentation 
		{ 
			get
			{
				return Model.Instances.Where<IIfcProductRepresentation>(e => e.Representations != null &&  e.Representations.Contains(this), "Representations", this);
			} 
		}
	//## Custom code
	//##
	}
}