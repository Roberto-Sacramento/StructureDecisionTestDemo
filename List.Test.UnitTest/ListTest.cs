using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using List;

namespace List.Test.UnitTest;

    public class ListTest
    {
        

        [Fact]
        public void FibonacciNumbers_GivenNumberZeroNumberDoesNotExists_ShouldReturnTrue()
        {
        ListBaseClass listBaseClass = new ListBaseClass();
        Assert.All(listBaseClass.FiboNumbers, n => Assert.NotEqual(0, n));

    }
}