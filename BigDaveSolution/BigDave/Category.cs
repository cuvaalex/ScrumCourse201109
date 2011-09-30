/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 30.09.2011
 * Time: 14:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BigDave
{
	/// <summary>
	/// Description of Category.
	/// </summary>
	public class Category
	{
		public string Name { get; private set; }
		public Category(string name)
		{
			Name = name;
		}
	}
}
