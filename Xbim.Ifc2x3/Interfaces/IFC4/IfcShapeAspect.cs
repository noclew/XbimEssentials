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
	public partial class @IfcShapeAspect : IIfcShapeAspect
	{
		IItemSet<IIfcShapeModel> IIfcShapeAspect.ShapeRepresentations 
		{ 
			get
			{
				foreach (var member in ShapeRepresentations)
				{
					yield return member as IIfcShapeModel;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcShapeAspect.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcShapeAspect.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLogical IIfcShapeAspect.ProductDefinitional 
		{ 
			get
			{
				//## Handle return of ProductDefinitional for which no match was found
			    return new Ifc4.MeasureResource.IfcLogical(ProductDefinitional);
			    //##
			} 
			set
			{
				ProductDefinitional = value;
				
			}
		}

		private  IIfcProductRepresentationSelect _partOfProductDefinitionShape4;

		IIfcProductRepresentationSelect IIfcShapeAspect.PartOfProductDefinitionShape 
		{ 
			get
			{
				return  _partOfProductDefinitionShape4 ?? PartOfProductDefinitionShape;
			} 
			set
			{
				if (value == null)
				{
					PartOfProductDefinitionShape = null;
					if (_partOfProductDefinitionShape4 != null)
						SetValue(v => _partOfProductDefinitionShape4 = v, _partOfProductDefinitionShape4, null, "PartOfProductDefinitionShape", byte.MaxValue);
					return;
				}
				
				var val = value as IfcProductDefinitionShape;
				if (val != null)
				{
					PartOfProductDefinitionShape = val;
					if (_partOfProductDefinitionShape4 != null)
						SetValue(v => _partOfProductDefinitionShape4 = v, _partOfProductDefinitionShape4, null, "PartOfProductDefinitionShape", byte.MaxValue);
					return;
				} 

				if(PartOfProductDefinitionShape != null)
					PartOfProductDefinitionShape = null;
				SetValue(v => _partOfProductDefinitionShape4 = v, _partOfProductDefinitionShape4, value, "PartOfProductDefinitionShape", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}