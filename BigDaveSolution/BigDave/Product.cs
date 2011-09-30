/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 30.09.2011
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BigDave
{
	/// <summary>
	/// Description of Product.
	/// </summary>
	public class Product
	{
		
		
		public Category category   {get ; set ;} 
		public String Name {get; set;}
		
		public Product( Category category)
		{
			
			this.category=category;
			this.Name="dummy";
		}
		
		public Product( Category category,String name)
		{
			
			this.category=category;
			this.Name=name;
		}
		
		
		
	}
}
