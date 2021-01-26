using System;
using AlibabaCloud.DarabonbaNumber;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_ParseInt()
        {
            Assert.Equal(2, NumberUtil.ParseInt("2"));
        }

        [Fact]
        public void Test_ParseLong()
        {
            Assert.Equal(2, NumberUtil.ParseLong("2"));
        }

        [Fact]
        public void Test_ParseFloat()
        {
            Assert.Equal(2f, NumberUtil.ParseFloat("2"));
        }

        [Fact]
        public void Test_ParseDouble()
        {
            Assert.Equal(2d, NumberUtil.ParseDouble("2"));
        }
    }
}
