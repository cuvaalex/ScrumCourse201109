/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 25.09.2011
 * Time: 17:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace EAS.Scrum.Exercise.XMasTree
{
	/// <summary>
	/// Description of ChristmasTree.
	/// </summary>
	public class ChristmasTree
	{
		public List<Branch> Branches = new List<Branch>();
		Trunc trunc;
		public ChristmasTree(int level)
		{
			BuildBranches(level);
			trunc = new Trunc(level);
		}
		
		public int GetNumberOfSpace(int branchLevel)
		{
			return 2;
		}
		
		private void BuildBranches(int level)
		{
			if(level < 3)
			{
				level = 3;
			}
			
			for(int i = 1; i <= level; i++)
			{
				Branches.Add(new Branch(i));
			}
		}
		
		public int NumberOfBranches 
		{
			get
			{
				return Branches.Count;
			}
		}
		
		public int NumberOfTrunk
		{
			get { return 1; }
		}

		public String buildTree(int lines) {
			StringBuilder builtString = new StringBuilder();
			for(int i=0; i < lines;i++)
			{
				for(int j = 0; j < (i+1); j++)
				{
					builtString.Append("*");
					if(j >0 )
					{
						builtString.Append(" ");
					}
				}
				
				builtString.Append("\n");
			}
			
			return builtString.ToString();
			
		}
		
	}
}
