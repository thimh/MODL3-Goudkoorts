namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Cart : MovableObject
	{
		public virtual bool hasLoad { get; set; }

        public override string icon { get { return "[00]"; } }

		public virtual void Unload()
		{
			throw new System.NotImplementedException();
		}

	}
}

