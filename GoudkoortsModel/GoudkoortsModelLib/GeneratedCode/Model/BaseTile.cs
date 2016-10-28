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
        public virtual bool isOccupied { get; set; }

        public virtual string icon
	    {
	        get
	        {
	            if (!isOccupied)
	            {
	                return "[  ]";
	            }
	            else
	            {
	                return "[00]";
	            }
	        }
            set { }
        }

        public virtual bool isUp { get; set; }

        public virtual BaseTile Next { get; set; }

        public virtual BaseTile Previous { get; set; }

        public int index { get; set; }

        public MovableObject currentObject { get; set; }

        public virtual void ChangeIcon()
        {
            if (isOccupied)
            {
                icon = "[00]";
            }
            else
            {
                icon = "[  ]";
            }
        }
	}
}

