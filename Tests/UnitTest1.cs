using System;
using System.Collections.Generic;
using MyBucks.Core.Model;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBaseContainment()
        {
            var lst = new ListReply<int>
            {
                ResultList = new List<int> {1,2,3}
            };
            Assert.NotEmpty(((ListReply) lst).ResultList);
        }
    }
}