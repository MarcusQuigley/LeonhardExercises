using LeonhardExercises;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Tests
{
    public class Leonhard1to10Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Problem1Test()
        {
            var result = Leonhard1to10Exercises.Problem1(10);
            Assert.AreEqual(23, result);
        }

        [Test]
        public void Problem1Test2()
        {
            var result = Leonhard1to10Exercises.Problem1(1000);
            Assert.AreEqual(233168, result);
        }

        [Test]
        public void Problem2Test()
        {
            var actual = Leonhard1to10Exercises.Problem2(77);
            Assert.AreEqual(44, actual);
        }

        [Test]
        public void Problem2Test2()
        {
            var actual = Leonhard1to10Exercises.Problem2(4000000);
            Assert.AreEqual(4613732, actual);
        }

        [Test]
        public void Problem3Test()
        {
            var result = Leonhard1to10Exercises.Problem3(120);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Problem3Test2()
        {
           var result =  Leonhard1to10Exercises.Problem3(600851475143);
            
            Assert.AreEqual(6857, result);
        }
    }
}