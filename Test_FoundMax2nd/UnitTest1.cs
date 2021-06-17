using NUnit.Framework;
using System;
using System.Collections.Generic;
using Test;

namespace Test_FoundMax2nd
{
    [TestFixture]
    public class TestsInt32
    {
        #region Vars
        Found<Int32> _found = new Found<Int32>();
        Int32[] _arrr;
        #endregion

        [Test]
        public void EmptyArr_returnNULL()
        {
            //  arrange
            Int32[] _arr = new Int32[] { };

            //  act
            var _ans = _found.FoundMax2nd(_arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }

        [Test]
        public void StandartArr_return13()
        {
            //  arrange
            Int32[] _arr = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 7, 9, 10, 14, 13 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 13);
        }

        [Test]
        public void StandartArrSomeMax_return13()
        {
            //  arrange
            Int32[] _arr = new Int32[] { 1, 14, 3, 4, 5, 6, 7, 8, 7, 9, 14, 14, 13 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 13);
        }


        [Test]
        public void StandartArrSome2ndMax_return13()
        {
            //  arrange
            Int32[] _arr = new Int32[] { 1, 13, 3, 4, 5, 6, 7, 8, 7, 9, 14, 13, 13 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 13);
        }

        [Test]
        public void MinValArr_returnMinVal()
        {
            //  arrange
            Int32[] _arr = new Int32[] { Int32.MinValue, Int32.MinValue + 1, Int32.MinValue + 1, Int32.MinValue + 1, Int32.MinValue + 1 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: Int32.MinValue);
        }


        [Test]
        public void SingleElArr_returnNULL()
        {
            //  arrange
            Int32[] _arr = new Int32[] { 1 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }

        [Test]
        public void IdenticalElArr_returnNULL()
        {
            //  arrange
            Int32[] _arr = new Int32[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }


        [Test]
        public void NotInitializeArr_returnNULL()
        {
            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arrr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }

    }

    [TestFixture]
    public class TestsDecimal
    {
        #region Vars
        Found<Decimal> _found = new Found<Decimal>();
        Decimal[] _arrr;
        #endregion

        [Test]
        public void EmptyArr_returnNULL()
        {
            //  arrange
            Decimal[] _arr = new Decimal[] { };

            //  act
            var _ans = _found.FoundMax2nd(_arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }

        [Test]
        public void StandartArr_return13dot6()
        {
            //  arrange
            Decimal[] _arr = new Decimal[] { 1.4M, 2, 3, 4, 5, 6, 7, 8, 7, 9.9M, 13.6M, 14, 13 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 13.6M);
        }

        [Test]
        public void StandartArrSomeMax_return13()
        {
            //  arrange
            Decimal[] _arr = new Decimal[] { 1, 14, 3, 4, 5, 6, 7, 8, 7, 9, 14, 14, 13 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 13);
        }


        [Test]
        public void StandartArrSome2ndMax_return13()
        {
            //  arrange
            Decimal[] _arr = new Decimal[] { 1, 13, 3, 4, 5, 6, 7, 8, 7, 9, 14, 13, 13 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 13);
        }

        [Test]
        public void MinValArr_returnMinVal()
        {
            //  arrange
            Decimal[] _arr = new Decimal[] { Decimal.MinValue, Decimal.MinValue + 1, Decimal.MinValue + 1, Decimal.MinValue + 1, Decimal.MinValue + 1 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: Decimal.MinValue);
        }


        [Test]
        public void SingleElArr_returnNULL()
        {
            //  arrange
            Decimal[] _arr = new Decimal[] { 1 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }

        [Test]
        public void IdenticalElArr_returnNULL()
        {
            //  arrange
            Decimal[] _arr = new Decimal[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }


        [Test]
        public void NotInitializeArr_returnNULL()
        {
            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arrr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }
    }

    [TestFixture]
    public class TestsChar
    {
        #region Vars
        Found<Char> _found = new Found<Char>();
        Char[] _arrr;
        #endregion

        [Test]
        public void EmptyArr_returnNULL()
        {
            //  arrange
            Char[] _arr = new Char[] { };

            //  act
            var _ans = _found.FoundMax2nd(_arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }

        [Test]
        public void StandartArr_returnb()
        {
            //  arrange
            Char[] _arr = new Char[] { 'a', 'b', 'c' };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 'b');
        }

        [Test]
        public void StandartArrSomeMax_returnb()
        {
            //  arrange
            Char[] _arr = new Char[] { 'a', 'b', 'c', 'c', 'c' };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 'b');
        }


        [Test]
        public void StandartArrSome2ndMax_returnb()
        {
            //  arrange
            Char[] _arr = new Char[] { 'a', 'b', 'b', 'c' };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: 'b');
        }

        [Test]
        public void MinValArr_returnMinVal()
        {
            //  arrange
            Char[] _arr = new Char[] { Char.MinValue, (char)(Char.MinValue + 1), (char)(Char.MinValue + 1), (char)(Char.MinValue + 1), (char)(Char.MinValue + 1) };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: Char.MinValue);
        }


        [Test]
        public void SingleElArr_returnNULL()
        {
            //  arrange
            Char[] _arr = new Char[] { 'a' };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }

        [Test]
        public void IdenticalElArr_returnNULL()
        {
            //  arrange
            Char[] _arr = new Char[] { 'a', 'a', 'a', 'a' };

            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }


        [Test]
        public void NotInitializeArr_returnNULL()
        {
            //  act
            var _ans = _found.FoundMax2nd(inputArray: _arrr);

            //  assert
            Assert.AreEqual(expected: _ans, actual: null);
        }
    }

}