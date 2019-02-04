using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  NUnit.Framework;
namespace Russian_roulate_askaran
{
    class UnitTest
    {
        spin sp = new spin();//this the object of the spin class
        [TestCase]
        public void pos()//this is the positive test
        {
            
            Assert.AreEqual(6, sp.spined(5));
        }

        [TestCase]
        public void neg()//this is the negative test
        {
            
            Assert.AreNotEqual(7, sp.spined(6));
        }
    }
}
