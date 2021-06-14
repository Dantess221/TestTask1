using NUnit.Framework;
using System;
using Test;

namespace Test_FoundMax2nd
{
    public class Tests
    {
        [Test]
        public void EmptyArr_returnNULL()
        {
            var found = new Found();
            Int32[] arr = new Int32[] {};
            var ans = found.FoundMax2nd(arr);
            Assert.AreEqual(ans, null);
        }

        [Test]
        public void StandartArr_return13()
        {
            var found = new Found();
            Int32[] arr = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 7, 9, 10, 14, 13 };
            var ans = found.FoundMax2nd(arr);
            Assert.AreEqual(ans, 13);
        }


    }
}