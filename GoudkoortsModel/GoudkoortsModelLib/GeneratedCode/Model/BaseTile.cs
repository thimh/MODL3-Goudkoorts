namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class BaseTile
    {
        public virtual bool isOccupied { get; set; }

        public virtual MovableObject ship { get; set; }

        public virtual string icon
	    {
	        get
	        {
	            if (!isOccupied)
	            {
	                return "[  ]";
                }
                else if (hasShip)
                {
                    return "<0" + ship.loadAmount + ">";
                }
                else
	            {
	                return "[00]";
	            }
	        }
            set { }
        }

        public virtual bool isUp { get; set; }

        public virtual bool hasShip { get; set; }

        public virtual BaseTile Next { get; set; }

        public virtual BaseTile Previous { get; set; }

        public int index { get; set; }

        public MovableObject currentObject { get; set; }
	}
}

