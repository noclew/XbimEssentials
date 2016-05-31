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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcTankType : IIfcTankType
	{
		Ifc4.Interfaces.IfcTankTypeEnum IIfcTankType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcTankTypeEnum.PREFORMED:
						//## Handle translation of PREFORMED member from IfcTankTypeEnum in property PredefinedType
                        return Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED;
						//##
										
					case IfcTankTypeEnum.SECTIONAL:
						//## Handle translation of SECTIONAL member from IfcTankTypeEnum in property PredefinedType
                        return Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED;
						//##
										
					case IfcTankTypeEnum.EXPANSION:
						return Ifc4.Interfaces.IfcTankTypeEnum.EXPANSION;
					
					case IfcTankTypeEnum.PRESSUREVESSEL:
						return Ifc4.Interfaces.IfcTankTypeEnum.PRESSUREVESSEL;
					
					case IfcTankTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED;
					
					case IfcTankTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTankTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcTankTypeEnum.BASIN:
						//## Handle setting of BASIN member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle setting of BASIN member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcTankTypeEnum.BREAKPRESSURE:
						//## Handle setting of BREAKPRESSURE member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle setting of BREAKPRESSURE member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcTankTypeEnum.EXPANSION:
						PredefinedType = IfcTankTypeEnum.EXPANSION;
						return;
					
					case Ifc4.Interfaces.IfcTankTypeEnum.FEEDANDEXPANSION:
						//## Handle setting of FEEDANDEXPANSION member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle setting of FEEDANDEXPANSION member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcTankTypeEnum.PRESSUREVESSEL:
						PredefinedType = IfcTankTypeEnum.PRESSUREVESSEL;
						return;
					
					case Ifc4.Interfaces.IfcTankTypeEnum.STORAGE:
						//## Handle setting of STORAGE member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle setting of STORAGE member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcTankTypeEnum.VESSEL:
						//## Handle setting of VESSEL member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle setting of VESSEL member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED:
						PredefinedType = IfcTankTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcTankTypeEnum.NOTDEFINED:
						PredefinedType = IfcTankTypeEnum.NOTDEFINED;
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