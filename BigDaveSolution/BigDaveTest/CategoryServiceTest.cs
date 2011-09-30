/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 30.09.2011
 * Time: 14:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace BigDave
{
	[TestFixture]
	public class CategoryServiceTest
	{
		[Test]
		public void shouldReturnAtLeastOneCategory()
		{
			CategoryService categoryService = new CategoryService();
			List<Category> categories = categoryService.GetAllCategories();
			
			Assert.Greater(categories.Count, 0);
		}
		
		[Test]
		public void shouldReturnAlLeastOneProductWhenCategory()
		{
			CategoryService categoryService = new CategoryService();
			Category category = categoryService.GetAllCategories()[0];
			List<Product> products = categoryService.GetProductsByCategory(category);
			
			Assert.Greater(products.Count, 0);
		}
		
		[Test]
		public void shouldReturnAllProductOfCategoryWhenCategorySpecified()
		{
			CategoryService categoryService = new CategoryService();
			Category category = categoryService.GetAllCategories()[0];
			List<Product> products = categoryService.GetProductsByCategory(category);
			
			foreach(Product p in products)
			{
				Assert.AreEqual(category.Name, p.category.Name);
			}
		}
	}
}
