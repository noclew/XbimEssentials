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
namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	public partial class @IfcDistributionChamberElementType : IIfcDistributionChamberElementType
	{
		Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum IIfcDistributionChamberElementType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcDistributionChamberElementTypeEnum.FORMEDDUCT:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.FORMEDDUCT;
					
					case IfcDistributionChamberElementTypeEnum.INSPECTIONCHAMBER:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.INSPECTIONCHAMBER;
					
					case IfcDistributionChamberElementTypeEnum.INSPECTIONPIT:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.INSPECTIONPIT;
					
					case IfcDistributionChamberElementTypeEnum.MANHOLE:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.MANHOLE;
					
					case IfcDistributionChamberElementTypeEnum.METERCHAMBER:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.METERCHAMBER;
					
					case IfcDistributionChamberElementTypeEnum.SUMP:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.SUMP;
					
					case IfcDistributionChamberElementTypeEnum.TRENCH:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.TRENCH;
					
					case IfcDistributionChamberElementTypeEnum.VALVECHAMBER:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.VALVECHAMBER;
					
					case IfcDistributionChamberElementTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.USERDEFINED;
					
					case IfcDistributionChamberElementTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.FORMEDDUCT:
						PredefinedType = IfcDistributionChamberElementTypeEnum.FORMEDDUCT;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.INSPECTIONCHAMBER:
						PredefinedType = IfcDistributionChamberElementTypeEnum.INSPECTIONCHAMBER;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.INSPECTIONPIT:
						PredefinedType = IfcDistributionChamberElementTypeEnum.INSPECTIONPIT;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.MANHOLE:
						PredefinedType = IfcDistributionChamberElementTypeEnum.MANHOLE;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.METERCHAMBER:
						PredefinedType = IfcDistributionChamberElementTypeEnum.METERCHAMBER;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.SUMP:
						PredefinedType = IfcDistributionChamberElementTypeEnum.SUMP;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.TRENCH:
						PredefinedType = IfcDistributionChamberElementTypeEnum.TRENCH;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.VALVECHAMBER:
						PredefinedType = IfcDistributionChamberElementTypeEnum.VALVECHAMBER;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.USERDEFINED:
						PredefinedType = IfcDistributionChamberElementTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcDistributionChamberElementTypeEnum.NOTDEFINED:
						PredefinedType = IfcDistributionChamberElementTypeEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}