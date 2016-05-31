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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcBeamType : IIfcBeamType
	{
		Ifc4.Interfaces.IfcBeamTypeEnum IIfcBeamType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcBeamTypeEnum.BEAM:
						return Ifc4.Interfaces.IfcBeamTypeEnum.BEAM;
					
					case IfcBeamTypeEnum.JOIST:
						return Ifc4.Interfaces.IfcBeamTypeEnum.JOIST;
					
					case IfcBeamTypeEnum.LINTEL:
						return Ifc4.Interfaces.IfcBeamTypeEnum.LINTEL;
					
					case IfcBeamTypeEnum.T_BEAM:
						return Ifc4.Interfaces.IfcBeamTypeEnum.T_BEAM;
					
					case IfcBeamTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcBeamTypeEnum.USERDEFINED;
					
					case IfcBeamTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcBeamTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcBeamTypeEnum.BEAM:
						PredefinedType = IfcBeamTypeEnum.BEAM;
						return;
					
					case Ifc4.Interfaces.IfcBeamTypeEnum.JOIST:
						PredefinedType = IfcBeamTypeEnum.JOIST;
						return;
					
					case Ifc4.Interfaces.IfcBeamTypeEnum.HOLLOWCORE:
						//## Handle setting of HOLLOWCORE member from IfcBeamTypeEnum in property PredefinedType
						//TODO: Handle setting of HOLLOWCORE member from IfcBeamTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcBeamTypeEnum.LINTEL:
						PredefinedType = IfcBeamTypeEnum.LINTEL;
						return;
					
					case Ifc4.Interfaces.IfcBeamTypeEnum.SPANDREL:
						//## Handle setting of SPANDREL member from IfcBeamTypeEnum in property PredefinedType
						//TODO: Handle setting of SPANDREL member from IfcBeamTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcBeamTypeEnum.T_BEAM:
						PredefinedType = IfcBeamTypeEnum.T_BEAM;
						return;
					
					case Ifc4.Interfaces.IfcBeamTypeEnum.USERDEFINED:
						PredefinedType = IfcBeamTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcBeamTypeEnum.NOTDEFINED:
						PredefinedType = IfcBeamTypeEnum.NOTDEFINED;
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