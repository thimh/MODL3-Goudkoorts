namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Ship : MovableObject
	{
	    public override int loadAmount { get; set; }

	    public override string icon
	    {
	        get
	        {
	            if (loadAmount < 10)
	            {
	                return "<0" + loadAmount + ">";
	            }
	            else
	            {
                    return "<" + loadAmount + ">";
                }
	        }
	    }

	}
}

