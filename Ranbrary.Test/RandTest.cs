using Ranbrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ranbrary.Test
{
    
    
    /// <summary>
    ///This is a test class for RandTest and is intended
    ///to contain all RandTest Unit Tests
    ///</summary>
	[TestClass()]
	public class RandTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for GetDouble
		///</summary>
		[TestMethod()]
		public void GetDoubleTest()
		{
			double minValue = 0F; // TODO: Initialize to an appropriate value
			double maxValue = 0F; // TODO: Initialize to an appropriate value
			double actual;
			actual = Rand.GetDouble(minValue, maxValue);
			if (actual < minValue || actual >= maxValue)
			{
				Assert.Fail("The result out of range.");
			}
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for GetDouble
		///</summary>
		[TestMethod()]
		public void GetDoubleTest1()
		{
			double maxValue = 0F; // TODO: Initialize to an appropriate value
			double actual;
			actual = Rand.GetDouble(maxValue);
			if (actual < 0 || actual >= maxValue)
			{
				Assert.Fail("The result out of range.");
			}
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
