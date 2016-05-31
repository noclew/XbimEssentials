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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcTransformerType : IIfcTransformerType
	{
		Ifc4.Interfaces.IfcTransformerTypeEnum IIfcTransformerType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcTransformerTypeEnum.CURRENT:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.CURRENT;
					
					case IfcTransformerTypeEnum.FREQUENCY:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.FREQUENCY;
					
					case IfcTransformerTypeEnum.VOLTAGE:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.VOLTAGE;
					
					case IfcTransformerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcTransformerTypeEnum.USERDEFINED;
					
					case IfcTransformerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTransformerTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcTransformerTypeEnum.CURRENT:
						PredefinedType = IfcTransformerTypeEnum.CURRENT;
						return;
					
					case Ifc4.Interfaces.IfcTransformerTypeEnum.FREQUENCY:
						PredefinedType = IfcTransformerTypeEnum.FREQUENCY;
						return;
					
					case Ifc4.Interfaces.IfcTransformerTypeEnum.INVERTER:
						//## Handle setting of INVERTER member from IfcTransformerTypeEnum in property PredefinedType
						//TODO: Handle setting of INVERTER member from IfcTransformerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcTransformerTypeEnum.RECTIFIER:
						//## Handle setting of RECTIFIER member from IfcTransformerTypeEnum in property PredefinedType
						//TODO: Handle setting of RECTIFIER member from IfcTransformerTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcTransformerTypeEnum.VOLTAGE:
						PredefinedType = IfcTransformerTypeEnum.VOLTAGE;
						return;
					
					case Ifc4.Interfaces.IfcTransformerTypeEnum.USERDEFINED:
						PredefinedType = IfcTransformerTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcTransformerTypeEnum.NOTDEFINED:
						PredefinedType = IfcTransformerTypeEnum.NOTDEFINED;
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