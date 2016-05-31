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
	public partial class @IfcWallType : IIfcWallType
	{
		Ifc4.Interfaces.IfcWallTypeEnum IIfcWallType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcWallTypeEnum.STANDARD:
						return Ifc4.Interfaces.IfcWallTypeEnum.STANDARD;
					
					case IfcWallTypeEnum.POLYGONAL:
						return Ifc4.Interfaces.IfcWallTypeEnum.POLYGONAL;
					
					case IfcWallTypeEnum.SHEAR:
						return Ifc4.Interfaces.IfcWallTypeEnum.SHEAR;
					
					case IfcWallTypeEnum.ELEMENTEDWALL:
						return Ifc4.Interfaces.IfcWallTypeEnum.ELEMENTEDWALL;
					
					case IfcWallTypeEnum.PLUMBINGWALL:
						return Ifc4.Interfaces.IfcWallTypeEnum.PLUMBINGWALL;
					
					case IfcWallTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcWallTypeEnum.USERDEFINED;
					
					case IfcWallTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWallTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcWallTypeEnum.MOVABLE:
						//## Handle setting of MOVABLE member from IfcWallTypeEnum in property PredefinedType
						//TODO: Handle setting of MOVABLE member from IfcWallTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcWallTypeEnum.PARAPET:
						//## Handle setting of PARAPET member from IfcWallTypeEnum in property PredefinedType
						//TODO: Handle setting of PARAPET member from IfcWallTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcWallTypeEnum.PARTITIONING:
						//## Handle setting of PARTITIONING member from IfcWallTypeEnum in property PredefinedType
						//TODO: Handle setting of PARTITIONING member from IfcWallTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcWallTypeEnum.PLUMBINGWALL:
						PredefinedType = IfcWallTypeEnum.PLUMBINGWALL;
						return;
					
					case Ifc4.Interfaces.IfcWallTypeEnum.SHEAR:
						PredefinedType = IfcWallTypeEnum.SHEAR;
						return;
					
					case Ifc4.Interfaces.IfcWallTypeEnum.SOLIDWALL:
						//## Handle setting of SOLIDWALL member from IfcWallTypeEnum in property PredefinedType
						//TODO: Handle setting of SOLIDWALL member from IfcWallTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcWallTypeEnum.STANDARD:
						PredefinedType = IfcWallTypeEnum.STANDARD;
						return;
					
					case Ifc4.Interfaces.IfcWallTypeEnum.POLYGONAL:
						PredefinedType = IfcWallTypeEnum.POLYGONAL;
						return;
					
					case Ifc4.Interfaces.IfcWallTypeEnum.ELEMENTEDWALL:
						PredefinedType = IfcWallTypeEnum.ELEMENTEDWALL;
						return;
					
					case Ifc4.Interfaces.IfcWallTypeEnum.USERDEFINED:
						PredefinedType = IfcWallTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcWallTypeEnum.NOTDEFINED:
						PredefinedType = IfcWallTypeEnum.NOTDEFINED;
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