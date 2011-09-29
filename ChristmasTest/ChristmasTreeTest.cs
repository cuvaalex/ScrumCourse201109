/*
 * Created by SharpDevelop.
 * User: acuva
 * Date: 29.09.2011
 * Time: 15:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace EAS.Scrum.Exercise.XMasTree
{
	[TestFixture]
	public class ChristmasTreeTest
	{
		[Test]
		public void ShouldReturnA3BranchesAnd1TrunkWhenLevel1()
		{
			ChristmasTree xMasTree = new ChristmasTree(1);
			int numberOfBranche = xMasTree.NumberOfBranches;
			Assert.AreEqual(3, numberOfBranche);
			
			int numberOfTrunk = xMasTree.NumberOfTrunk;
			Assert.AreEqual(1, numberOfTrunk);
			
		}
		
		 
		[Test]
		public void ShouldReturnA3BranchesAnd1TrunkWhenLevel2()
		{
			ChristmasTree xMasTree = new ChristmasTree(2);
			int numberOfBranche = xMasTree.NumberOfBranches;
			Assert.AreEqual(3, numberOfBranche);
			
			int numberOfTrunk = xMasTree.NumberOfTrunk;
			Assert.AreEqual(1, numberOfTrunk);
		}
		
		[Test]
		public void ShouldReturnA4BranchesAnd1TrunkWhenLevel4()
		{
			ChristmasTree xMasTree = new ChristmasTree(4);
			int numberOfBranche = xMasTree.NumberOfBranches;
			Assert.AreEqual(4, numberOfBranche);
			
			int numberOfTrunk = xMasTree.NumberOfTrunk;
			Assert.AreEqual(1, numberOfTrunk);
		}
		
		[Test]
		public void ShouldReturn2SpacesBeforeStarsOn1stBranchWhenLevel3()
		{
			ChristmasTree xMasTree = new ChristmasTree(3);
			int numberOfSpaces = xMasTree.GetNumberOfSpace(1);
			Assert.AreEqual(2, numberOfSpaces);
		}
	}
}
