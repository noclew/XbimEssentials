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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcTextStyleForDefinedFont : IIfcTextStyleForDefinedFont
	{
		IIfcColour IIfcTextStyleForDefinedFont.Colour 
		{ 
			get
			{
				if (Colour == null) return null;
				var ifccolourspecification = Colour as PresentationResource.IfcColourSpecification;
				if (ifccolourspecification != null) 
					return ifccolourspecification;
				var ifcpredefinedcolour = Colour as PresentationResource.IfcPreDefinedColour;
				if (ifcpredefinedcolour != null) 
					return ifcpredefinedcolour;
				return null;
			} 
			set
			{
				if (value == null)
				{
					Colour = null;
					return;
				}	
				var ifccolourspecification = value as PresentationResource.IfcColourSpecification;
				if (ifccolourspecification != null) 
				{
					Colour = ifccolourspecification;
					return;
				}
				var ifcpredefinedcolour = value as PresentationResource.IfcPreDefinedColour;
				if (ifcpredefinedcolour != null) 
				{
					Colour = ifcpredefinedcolour;
					return;
				}
				
			}
		}
		IIfcColour IIfcTextStyleForDefinedFont.BackgroundColour 
		{ 
			get
			{
				if (BackgroundColour == null) return null;
				var ifccolourspecification = BackgroundColour as PresentationResource.IfcColourSpecification;
				if (ifccolourspecification != null) 
					return ifccolourspecification;
				var ifcpredefinedcolour = BackgroundColour as PresentationResource.IfcPreDefinedColour;
				if (ifcpredefinedcolour != null) 
					return ifcpredefinedcolour;
				return null;
			} 
			set
			{
				if (value == null)
				{
					BackgroundColour = null;
					return;
				}	
				var ifccolourspecification = value as PresentationResource.IfcColourSpecification;
				if (ifccolourspecification != null) 
				{
					BackgroundColour = ifccolourspecification;
					return;
				}
				var ifcpredefinedcolour = value as PresentationResource.IfcPreDefinedColour;
				if (ifcpredefinedcolour != null) 
				{
					BackgroundColour = ifcpredefinedcolour;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}