namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class SwitchTile : BaseTile
	{
	    public int number { get; set; }


        public override string icon {
            get
            {
                if (isOccupied)
                {
                    return "{00}";
                }
                else
                {
                    if (isUp)
                    {
                        return "{" + number + "^}";
                    }
                    return "{" + number + "v}";
                }
            }
        }

        public SwitchTile(int number)
        {
            this.number = number;
        }

	}
}

