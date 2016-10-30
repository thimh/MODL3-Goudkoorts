namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class MovableObject
	{
        public virtual string icon { get; set; }

        public bool hasMoved { get; set; }

        public virtual int loadAmount { get; set; }
	}
}

