﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class BaseTile
	{
		public virtual string icon
		{
		    get { return "[  ]"; }
		}

		public bool isOccupied
		{
			get;
			set;
		}

		public MovableObject MovableObject
		{
			get;
			set;
		}

	    public BaseTile()
	    {
	        
	    }

	}
}

