/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 30.09.2011
 * Time: 14:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BigDave
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private CategoryService categoryService;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Init();

		}
		
		private void Init()
		{
			categoryService=new CategoryService();
			cbCategories.DataSource = categoryService.GetAllCategories();
			cbCategories.DisplayMember="Name"  ;
			
		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			
			
			List<Product> products=categoryService.GetProductsByCategory((Category)cbCategories.SelectedItem );
			
			listViewProducts.Items.Clear();
			foreach(Product p in products)
			{
				listViewProducts.Items.Add(p.Name);
			}
			
			
		}
	}
}
