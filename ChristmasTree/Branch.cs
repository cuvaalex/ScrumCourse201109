/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 29.09.2011
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace EAS.Scrum.Exercise.XMasTree
{
	/// <summary>
	/// Description of Branch.
	/// </summary>
	public class Branch
	{
		
		private int branchLevel;
		public Branch(int branchLevel)
		{
			this.branchLevel=branchLevel;
		}
		
		public int calculateNumberStars(int branchLevel){
			return branchLevel - 2*((branchLevel - 1)/4);
		}
		
		public override string ToString()
		{
			StringBuilder stringBuilder= new StringBuilder();
			for(int i=0; i < calculateNumberStars(branchLevel) ; i++)
			{
				if (i == 0)
				{
					stringBuilder.Append("*");
				}
				else
				{
					stringBuilder.Append(" *");
				}
			}
			
			return stringBuilder.ToString();
		}

	}


}
