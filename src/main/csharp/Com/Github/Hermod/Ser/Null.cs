/*
 * Created by SharpDevelop.
 * User: Alexandre
 * Date: 03/11/2013
 * Time: 23:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Com.Github.Hermod.Ser
{
	/// <summary>
	/// Description of Null.
	/// </summary>
	public class Null
	{
		private int Length;

		private Null(int length)
		{
			if (length < 0)
				throw new ArgumentException("The length must be superior to 0.");
			this.Length = length;
		}
		
		public static Null valueOf(int aLength)
    	{
			//TODO optimize with 30 Null preallocated
			return new Null(aLength);
		}
	}
}
	