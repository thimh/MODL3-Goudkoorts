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

	public class Ship : MovableObject
	{
		public virtual int loadAmount
		{
			get;
			set;
		}

		public virtual void CheckLoad()
		{
			throw new System.NotImplementedException();
		}

		public virtual void AddLoad()
		{
			throw new System.NotImplementedException();
		}

	}
}

