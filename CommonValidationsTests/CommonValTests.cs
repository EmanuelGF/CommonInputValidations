using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonValidations;
using NUnit.Framework;

namespace CommonValidationsTests
{

    [TestFixture]
    public class CommonValTests
    {
        //Put your tests here.

        [Test]
        public void HasNineDigits()
        {
            Assert.That(CommonPT.IsPhoneNumberPT("969920456"), Is.EqualTo(true));
        }

        
    }
}
