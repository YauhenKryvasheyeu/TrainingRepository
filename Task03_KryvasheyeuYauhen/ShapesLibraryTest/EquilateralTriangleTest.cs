﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibraryTest
{
    [TestClass]
    public class EquilateralTriangleTest
    {
        [TestMethod]
        public void ConstructorWithOneParameter_WhenCorrectDataProvided_ShouldInitializePropertyCorrectly()
        {
            //arrange and act
            EquilateralTriangle triangle = new PaperEquilateralTriangle(10);
            //assert
            Assert.AreEqual(triangle.Side, 10);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorWithOneParameter_WhenInCorrectDataProvided_ShouldThrowExeption()
        {
            EquilateralTriangle triangle = new PaperEquilateralTriangle(0);
        }

        [TestMethod]
        public void ConstructorWithTwoParameters_WhenCorrectDataProvided_ShouldInitializePropertyCorrectly()
        {
            //arrange
            PaperRectangle targetRectangle = new PaperRectangle(11, 21);
            targetRectangle.Paint(Colors.Red);
            //act
            EquilateralTriangle triangle = new PaperEquilateralTriangle(10, targetRectangle);
            //assert
            Assert.AreEqual(triangle.Side, 10);            
            Assert.AreEqual(((IPaperShape)triangle).Color, Colors.Red);
        }

        [TestMethod]
        public void PaperEquilateralTriangleToString_ShouldReturnCorrectString()
        {
            //arrange
            PaperEquilateralTriangle targetTriangle = new PaperEquilateralTriangle(11);
            targetTriangle.Paint(Colors.Red);
            //act and assert
            Assert.AreEqual(targetTriangle.ToString(), "[PaperEquilateralTriangle: Side = 11; Color = Red]");
        }

        [TestMethod]
        public void FilmEquilateralTriangleToString_ShouldReturnCorrectString()
        {
            //arrange
            FilmEquilateralTriangle targetTriangle = new FilmEquilateralTriangle(11);
            //act and assert
            Assert.AreEqual(targetTriangle.ToString(), "[FilmEquilateralTriangle: Side = 11]");
        }

        [TestMethod]
        public void Equals_WhenEqualTriangleProvided_ShouldReturnTrue()
        {
            //arrange
            FilmEquilateralTriangle filmTriangle1 = new FilmEquilateralTriangle(10);
            FilmEquilateralTriangle filmTriangle2 = new FilmEquilateralTriangle(10);
            PaperEquilateralTriangle paperTriangle1 = new PaperEquilateralTriangle(10);
            PaperEquilateralTriangle paperTriangle2 = new PaperEquilateralTriangle(10);
            //act and assert
            Assert.AreEqual(filmTriangle1.Equals(filmTriangle2), true);
            Assert.AreEqual(paperTriangle1.Equals(paperTriangle2), true);
        }

        [TestMethod]
        public void Equals_WhenUnequalTriangleProvided_ShouldReturnFalse()
        {
            //arrange
            FilmEquilateralTriangle filmTriangle1 = new FilmEquilateralTriangle(10);
            PaperEquilateralTriangle paperTriangle1 = new PaperEquilateralTriangle(10);
            PaperEquilateralTriangle paperTriangle2 = new PaperEquilateralTriangle(15);
            //act and assert
            Assert.AreEqual(filmTriangle1.Equals(paperTriangle1), false);
            Assert.AreEqual(filmTriangle1.Equals(paperTriangle2), false);
        }

        [TestMethod]
        public void GetArea_ShouldCalculateAreaCorrectly()
        {
            //arrange
            EquilateralTriangle triangle  = new FilmEquilateralTriangle(10);
            //act and assert
            Assert.AreEqual(triangle.GetArea().ToString(), "43,3012701892219");
        }

        [TestMethod]
        public void GetPerimeter_ShouldCalculatePerimeterCorrectly()
        {
            //arrange
            EquilateralTriangle triangle = new FilmEquilateralTriangle(10);
            //act and assert
            Assert.AreEqual(triangle.GetPerimeter(), 30);
        }
    }
}
