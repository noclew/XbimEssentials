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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelNests : IIfcRelNests
	{
		IIfcObjectDefinition IIfcRelNests.RelatingObject 
		{ 
			get
			{
				return RelatingObject;
			} 
			set
			{
				RelatingObject = value as IfcObjectDefinition;
				
			}
		}
		IItemSet<IIfcObjectDefinition> IIfcRelNests.RelatedObjects 
		{ 
			get
			{
				//## Handle return of RelatedObjects for which no match was found
                return this.RelatedObjects;
				//##
			} 
		}
	//## Custom code
	//##
	}
}