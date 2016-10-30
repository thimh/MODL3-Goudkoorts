namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class DockTile : BaseTile
	{
	    public override string icon
	    {
	        get
	        {
	            if (isOccupied)
	            {
	                return "{00}";
	            }
	            return "{_D}";
	        }
	    }
	}
}

