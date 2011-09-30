/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 30.09.2011
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace BigDave
{
	/// <summary>
	/// Description of CategoryService.
	/// </summary>
	public class CategoryService
	{
		private List<Category> categories;
		private List<Product> products ;
		public CategoryService()
		{
			categories = new List<Category>();
			products = new List<Product>();
			Init();
		}
		
		private void Init()
		{
			
			
			categories.Add(new Category("SurfBoard"));
			categories.Add(new Category("Underwear"));
			
			products.Add(new Product(categories[0] ,"AAAA"));
			products.Add(new Product(categories[0],"BBBBB"));
			products.Add(new Product(categories[0],"CCCCC"));
			products.Add(new Product(categories[1],"DDDDDDD"));
		}
		
		public List<Category> GetAllCategories()
		{
			return categories;
		}
		
	
		
		public List<Product> GetProductsByCategory(Category category)
		{
			var query = from p in products
				where p.category.Name == category.Name
				select p;
			return query.ToList();
		}
	}
}
