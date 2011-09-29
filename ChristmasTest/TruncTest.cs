/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 29.09.2011
 * Time: 15:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace EAS.Scrum.Exercise.XMasTree
{
	[TestFixture]
	public class TruncTest
	{
		[Test]
		public void ShoulReturnATrunkSize1WhenBaseline4()
		{
			Trunc trunc=new Trunc(4);
			string result=trunc.ToString();
			Assert.AreEqual("|_|",result);
		}
		
		[Test]
		public void ShouldReturnATrunkSize1WhenBaseline2()
		{
			Trunc trunc = new Trunc(2);
			string result= trunc.ToString();
			Assert.AreEqual("|_|", result);
		}
		
		[Test]
		public void ShoulReturnATrunkSize2WhenBaseline6()
		{
			Trunc trunc=new Trunc(6);
			string result=trunc.ToString();
			Assert.AreEqual("|__|",result);
		}
	}
}
