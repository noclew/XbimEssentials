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
namespace Xbim.Ifc2x3.SharedMgmtElements
{
	public partial class @IfcProjectOrder : IIfcProjectOrder
	{
		Ifc4.Interfaces.IfcProjectOrderTypeEnum? IIfcProjectOrder.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcProjectOrderTypeEnum.CHANGEORDER:
						return Ifc4.Interfaces.IfcProjectOrderTypeEnum.CHANGEORDER;
					
					case IfcProjectOrderTypeEnum.MAINTENANCEWORKORDER:
						return Ifc4.Interfaces.IfcProjectOrderTypeEnum.MAINTENANCEWORKORDER;
					
					case IfcProjectOrderTypeEnum.MOVEORDER:
						return Ifc4.Interfaces.IfcProjectOrderTypeEnum.MOVEORDER;
					
					case IfcProjectOrderTypeEnum.PURCHASEORDER:
						return Ifc4.Interfaces.IfcProjectOrderTypeEnum.PURCHASEORDER;
					
					case IfcProjectOrderTypeEnum.WORKORDER:
						return Ifc4.Interfaces.IfcProjectOrderTypeEnum.WORKORDER;
					
					case IfcProjectOrderTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcProjectOrderTypeEnum.USERDEFINED;
					
					case IfcProjectOrderTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcProjectOrderTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcProjectOrderTypeEnum.CHANGEORDER:
						PredefinedType = IfcProjectOrderTypeEnum.CHANGEORDER;
						return;
					
					case Ifc4.Interfaces.IfcProjectOrderTypeEnum.MAINTENANCEWORKORDER:
						PredefinedType = IfcProjectOrderTypeEnum.MAINTENANCEWORKORDER;
						return;
					
					case Ifc4.Interfaces.IfcProjectOrderTypeEnum.MOVEORDER:
						PredefinedType = IfcProjectOrderTypeEnum.MOVEORDER;
						return;
					
					case Ifc4.Interfaces.IfcProjectOrderTypeEnum.PURCHASEORDER:
						PredefinedType = IfcProjectOrderTypeEnum.PURCHASEORDER;
						return;
					
					case Ifc4.Interfaces.IfcProjectOrderTypeEnum.WORKORDER:
						PredefinedType = IfcProjectOrderTypeEnum.WORKORDER;
						return;
					
					case Ifc4.Interfaces.IfcProjectOrderTypeEnum.USERDEFINED:
						PredefinedType = IfcProjectOrderTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcProjectOrderTypeEnum.NOTDEFINED:
						PredefinedType = IfcProjectOrderTypeEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcProjectOrder.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
			set
			{
				Status = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcProjectOrder.LongDescription 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcText(ID);
			} 
			set
			{
				ID = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 default(MeasureResource.IfcIdentifier) ;
				
			}
		}
	//## Custom code
	//##
	}
}