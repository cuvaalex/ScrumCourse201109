/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 29.09.2011
 * Time: 10:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace EAS.Scrum.Exercise.XMasTree
{
	[TestFixture]
	public class BrancheTest
	{
		
	
		
		[Test]
		public void shouldReturn1StartWhen1Line() {
			Branch branch = new Branch(1);
			String result = branch.ToString();
			Assert.AreEqual(1, branch.calculateNumberStars(1));
			Assert.AreEqual("*",result);
		}
		
		[Test]
		public void shouldReturn2StarsWhenLevel2()
		{
			Branch branch = new Branch(2);
			String result = branch.ToString();
			Assert.AreEqual(2, branch.calculateNumberStars(2));
			Assert.AreEqual("* *",result);
		}
		
		[Test]
		public void shouldReturn3StarsWhenLevel3()
		{
			Branch branch = new Branch(3);
			String result=branch.ToString();
			Assert.AreEqual(3, branch.calculateNumberStars(3));
			Assert.AreEqual("* * *",result);
		}
		
		
		[Test]
		public void shouldReturn4StarsWhenLevel4(){
			Branch branch = new Branch(4);
			String result = branch.ToString();
			Assert.AreEqual(4, branch.calculateNumberStars(4));
			Assert.AreEqual("* * * *", result);
		}		
		
		[Test]
		public void shouldReturn3StarsWhenLevel5(){
			Branch branch = new Branch(5);
			String result = branch.ToString();
			Assert.AreEqual(3, branch.calculateNumberStars(5));
			Assert.AreEqual("* * *", result);
		}
		
		[Test]
		public void shouldReturn4StarsWhenLevel6(){
			Branch branch = new Branch(6);
			String result = branch.ToString();
			Assert.AreEqual(4, branch.calculateNumberStars(6));
			Assert.AreEqual("* * * *", result);
		}
		
		[Test]
		public void shouldReturn5StarsWhenLevel7(){
			Branch branch = new Branch(7);
			String result = branch.ToString();
			Assert.AreEqual(5, branch.calculateNumberStars(7));
			Assert.AreEqual("* * * * *", result);
		}
		
		[Test]
		public void shouldReturn6StarsWhenLevel8(){
			Branch branch = new Branch(8);
			String result = branch.ToString();
			Assert.AreEqual(6, branch.calculateNumberStars(8));
			Assert.AreEqual("* * * * * *", result);
		}
		
	}
}
