using WindowsFormsApplication1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class LoginPage
    {
        [TestMethod()]
        public void GetUserNameTest(TextBox _input)
        {
            Assert.Fail();
        }
    }
}

namespace BAU_Unit_Tests
{
    [TestClass]
    public class LoginPage
    {
        [TestMethod]
        public void Test_isStringNotBlank(TextBox _input)
        {

        }
    }
}
