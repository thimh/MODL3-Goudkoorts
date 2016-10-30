namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class SafeTile : BaseTile
	{
	    public override string icon
	    {
	        get
	        {
	            if (isOccupied)
	            {
	                return "{00}";
	            }
                return "{__}";
	        }
	    }

	}
}

