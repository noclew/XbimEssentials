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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.BuildingcontrolsDomain
{
	public partial class @IfcSensorType : IIfcSensorType
	{
		Ifc4.BuildingControlsDomain.IfcSensorTypeEnum IIfcSensorType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcSensorTypeEnum.CO2SENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.CO2SENSOR;
					
					case IfcSensorTypeEnum.FIRESENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.FIRESENSOR;
					
					case IfcSensorTypeEnum.FLOWSENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.FLOWSENSOR;
					
					case IfcSensorTypeEnum.GASSENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.GASSENSOR;
					
					case IfcSensorTypeEnum.HEATSENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.HEATSENSOR;
					
					case IfcSensorTypeEnum.HUMIDITYSENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.HUMIDITYSENSOR;
					
					case IfcSensorTypeEnum.LIGHTSENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.LIGHTSENSOR;
					
					case IfcSensorTypeEnum.MOISTURESENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.MOISTURESENSOR;
					
					case IfcSensorTypeEnum.MOVEMENTSENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.MOVEMENTSENSOR;
					
					case IfcSensorTypeEnum.PRESSURESENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.PRESSURESENSOR;
					
					case IfcSensorTypeEnum.SMOKESENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.SMOKESENSOR;
					
					case IfcSensorTypeEnum.SOUNDSENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.SOUNDSENSOR;
					
					case IfcSensorTypeEnum.TEMPERATURESENSOR:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.TEMPERATURESENSOR;
					
					case IfcSensorTypeEnum.USERDEFINED:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.USERDEFINED;
					
					case IfcSensorTypeEnum.NOTDEFINED:
						return Ifc4.BuildingControlsDomain.IfcSensorTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}