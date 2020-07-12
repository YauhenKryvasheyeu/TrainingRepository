﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathObjects;

namespace MathObjectsTest
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        public void ToString_ShouldReturnCorrectString()
        {
            //arrange
            var polynomial1 = new Polynomial(1, 2, 3, 4, 5);
            var polynomial2 = new Polynomial(0, 2, 0, 4, 0);
            var polynomial3 = new Polynomial(1);
            var polynomial4 = new Polynomial(0);
            //act and assert
            Assert.AreEqual(polynomial1.ToString(), "[5x^4 + 4x^3 + 3x^2 + 2x^1 + 1x^0]");
            Assert.AreEqual(polynomial2.ToString(), "[0x^4 + 4x^3 + 0x^2 + 2x^1 + 0x^0]");
            Assert.AreEqual(polynomial3.ToString(), "[1x^0]");
            Assert.AreEqual(polynomial4.ToString(), "[0x^0]");
        }

        [TestMethod]
        public void Equals_WhenEqualPolynomialsProvided_ShouldReturnTrue()
        {
            //arrange
            var polynomial1 = new Polynomial(1, 2, 3, 4, 5);
            var polynomial2 = new Polynomial(1, 2, 3, 4, 5);
            //act and assert
            Assert.AreEqual(polynomial1.Equals(polynomial2), true);
        }

        [TestMethod]
        public void Equals_WhenUnequalPolynomialsProvided_ShouldReturnfalse()
        {
            //arrange
            var polynomial1 = new Polynomial(1, 2, 3, 4, 5);
            var polynomial2 = new Polynomial(1, 2, 3, 4, 4);
            //act and assert
            Assert.AreEqual(polynomial1.Equals(polynomial2), false);
        }

        [TestMethod]
        public void PolynomialAddition_ShouldAddPolynomialsCorrectly()
        {
            //arrange
            var polynomial1 = new Polynomial(5, 3, 4);
            var polynomial2 = new Polynomial(10, 0, 3, 6, 7);
            var polynomial3 = new Polynomial(10, 2);
            var polynomial4 = new Polynomial(3, 2, 5);
            //act
            var result1 = polynomial1 + polynomial2 + polynomial3;
            var result2 = polynomial4 + polynomial1;
            //assert
            Assert.AreEqual(result1, new Polynomial(25, 5, 7, 6, 7));
            Assert.AreEqual(result2, new Polynomial(8, 5, 9));
        }

        [TestMethod]
        public void PolynomialSubtraction_ShouldSubtractPolynomialsCorrectly()
        {
            //arrange
            var polynomial1 = new Polynomial(5, 3, 4);
            var polynomial2 = new Polynomial(10, 3, 2, 8);
            var polynomial3 = new Polynomial(6, 3, 1);
            //act
            var result1 = polynomial1 - polynomial2;
            var result2 = polynomial2 - polynomial1;
            var result3 = polynomial3 - polynomial1;
            //assert
            Assert.AreEqual(result1, new Polynomial(-5, 0, 2, -8));
            Assert.AreEqual(result2, new Polynomial(5, 0, -2, 8));
            Assert.AreEqual(result3, new Polynomial(1, 0, -3));
        }

        [TestMethod]
        public void PolynomialMultiplication_ShouldMultiplyPolynomialsCorrectly()
        {
            //arrange
            var polynomial1 = new Polynomial(2, 3, 4);
            var polynomial2 = new Polynomial(10, 0, 3);
            //act
            var result = vector1 * vector2;
            //assert
            Assert.AreEqual(result, new Vector(9, 25, -30));
        }
    }
}
