using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Tests
{
    [TestClass()]
    public class AreaTests
    {


        [TestMethod()]

        [DataRow("20","5","2","400")]
        [DataRow("10","10","10","1000")]
        [DataRow("30","30","30","9000")]
        [DataRow("2","2","2","8")]
        public void AreaofTriangelTest()
        {          
            
            var area = lenght*breath*height(100, 2, 5);
          
            Assert.Fail();
        }
    }
}