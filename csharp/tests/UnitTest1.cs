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

        [Fact]
        public void Test_Itol()
        {
            Assert.Equal(2L, NumberUtil.Itol(2));
        }

        [Fact]
        public void Test_Ltoi()
        {
            Assert.Equal(2, NumberUtil.Ltoi(2L));
        }

        [Fact]
        public void Test_Add()
        {
            Assert.Equal(2L + 3L, NumberUtil.Add(2L,3L));
        }

        [Fact]
        public void Test_Sub()
        {
            Assert.Equal(2L - 3L, NumberUtil.Sub(2L, 3L));
        }

        [Fact]
        public void Test_Mul()
        {
            Assert.Equal(2L * 3L, NumberUtil.Mul(2L, 3L));
        }

        [Fact]
        public void Test_Div()
        {
            Assert.Equal(2L / 3L, NumberUtil.Div(2L, 3L)) ;
        }

        [Fact]
        public void Test_Gt()
        {
            Assert.Equal(2L > 3L, NumberUtil.Gt(2L, 3L));
        }

        [Fact]
        public void Test_Gte()
        {
            Assert.Equal(2L >= 3L, NumberUtil.Gt(2L, 3L));
        }

        [Fact]
        public void Test_Lt()
        {
            Assert.Equal(2L < 3L, NumberUtil.Lt(2L, 3L));
        }

        [Fact]
        public void Test_Lte()
        {
            Assert.Equal(2L <= 3L, NumberUtil.Lte(2L, 3L));
        }
    }
}
