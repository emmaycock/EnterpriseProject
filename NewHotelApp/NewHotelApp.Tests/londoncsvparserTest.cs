﻿using NewHotelApp.ingestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.IO;
using NewHotelApp.Models;
using System.Collections.Generic;

namespace NewHotelApp.Tests
{

    /*
    /// <summary>
    ///This is a test class for londoncsvparserTest and is intended
    ///to contain all londoncsvparserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class londoncsvparserTest
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
        ///A test for londoncsvparser Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\STEVE\\Desktop\\MvcApplication1\\MvcApplication1", "/")]
        [UrlToTest("http://localhost:41211/")]
        public void londoncsvparserConstructorTest()
        {
            londoncsvparser target = new londoncsvparser();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MvcApplication1.ingestion.IDataParser.setStreamSource
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\STEVE\\Desktop\\MvcApplication1\\MvcApplication1", "/")]
        [UrlToTest("http://localhost:41211/")]
        [DeploymentItem("MvcApplication1.dll")]
        public void setStreamSourceTest()
        {
            IDataParser_Accessor target = new londoncsvparser_Accessor(); // TODO: Initialize to an appropriate value
            StreamReader reader = null; // TODO: Initialize to an appropriate value
            target.setStreamSource(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for parseHotelDetails
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\STEVE\\Desktop\\MvcApplication1\\MvcApplication1", "/")]
        [UrlToTest("http://localhost:41211/")]
        public void parseHotelDetailsTest()
        {
            londoncsvparser target = new londoncsvparser(); // TODO: Initialize to an appropriate value
            List<HotelDetail> expected = null; // TODO: Initialize to an appropriate value
            List<HotelDetail> actual;
            actual = target.parseHotelDetails();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for supportsType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\STEVE\\Desktop\\MvcApplication1\\MvcApplication1", "/")]
        [UrlToTest("http://localhost:41211/")]
        public void supportsTypeTest()
        {
            londoncsvparser target = new londoncsvparser(); // TODO: Initialize to an appropriate value
            string format = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.supportsType(format);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }*/
}
