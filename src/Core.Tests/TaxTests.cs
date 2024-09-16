using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public class TaxTests
    {
        [Theory]
        [InlineData(10000, 0)]
        [InlineData(5000, 0)]
        [InlineData(13500, 200)]
        [InlineData(16500, 800)]
        [InlineData(50000, 7500)]
        [InlineData(60000, 11500)]
        [InlineData(70000,15_500)]
        [InlineData(100_000,27500)]
        public void testtax(decimal input, decimal output)
        {
            var taxCalc = new TaxCalc();
            var o = taxCalc.Calc(input);
            Assert.Equal(output, o);
        }
    }
}
