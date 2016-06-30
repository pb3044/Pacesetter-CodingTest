using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingTest.Models;
using Should.Fluent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTest.Tests.Models
{
    [TestClass]
    public class ReadingTests
    {
        // Checks the calculations for totalMag
        
        [TestMethod]
        public void TotalMag_should_be_the_sum_of_other_3_mags()
        {
            var sut = new Reading();
            sut.MagX = 3.3M;
            sut.MagY = 4.7M;
            sut.MaxZ = 8;
            sut.TotalMag.Should().Equal(16M);
        }

        // Checks the calculations for total Gravity GravTotal = (GravX + GravY)/GravZ 
        [TestMethod]
        public void GravTotal_should_be_the_sum_of_firsttwo_dividedby3rdgrav()
        {
            var sut = new Reading();
            sut.GravX = 5.3M;
            sut.GravY = 6.7M;
            sut.GravZ = 8.2M;
            sut.GravTotal.Should().Equal(1.4634146341463414634146341463M);
        }
    }
}
