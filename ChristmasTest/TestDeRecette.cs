/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 25.09.2011
 * Time: 17:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace EAS.Scrum.Exercise.XMasTree
{
	[TestFixture]
	public class TestDeRecette
	{
		
		public static String ChristmasTree3lines =
			"  *\n" +
			" * *\n" +
			"* * *\n" +
			" |_|";

		public static String ChristmasTree4lines =
			"   *\n" +
			"  * *\n" +
			" * * *\n" +
			"* * * *\n" +
			"  |_|";

		public static String ChristmasTree5lines =
			"   *\n" +
			"  * *\n" +
			" * * *\n" +
			"* * * *\n" +
			" * * *\n" +
			"  |_|";

		public static String ChristmasTree8lines =
			"      *\n" +
			"     * *\n" +
			"    * * *\n" +
			"   * * * *\n" +
			"    * * *\n" +
			"   * * * *\n" +
			"  * * * * *\n" +
			" * * * * * *\n" +
			"    |___|";
		
		
		static Object[] ChristmasTrees = {
			new Object[] {3, ChristmasTree3lines},
			new Object[] {4, ChristmasTree4lines},
			new Object[] {5, ChristmasTree5lines},
			new Object[] {8, ChristmasTree8lines}
		};
		
		[Test, TestCaseSource("ChristmasTrees"), Ignore]
		public void shouldReturnAPerfectTree(int lines, String expected) {			
			ChristmasTree tree = new ChristmasTree(lines);
			String result = tree.buildTree(lines);
			
			Assert.AreEqual(expected, result);
			
		}
		
	}
}
