/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 29.09.2011
 * Time: 15:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace EAS.Scrum.Exercise.XMasTree
{
	/// <summary>
	/// Description of Trunc.
	/// </summary>
	public class Trunc
	{
		
		private int baseLine;
		
		public Trunc(int _baseLine)
		{
			baseLine=_baseLine;
		}
		
		public int calculateTruncBase(int baseline)
		{
			int result = baseline / 3;
			return Math.Max(1,result);
		}
		
		public override string ToString()
		{
			
			StringBuilder stringBuilder= new StringBuilder();
			stringBuilder.Append("|");
			
			for(int i=0; i<calculateTruncBase(this.baseLine);i++ )
			{
				stringBuilder.Append("_");
			}
			
			stringBuilder.Append("|");
			
			return stringBuilder.ToString();
		}

	}
}
