using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Numbers.Models;
using System;

namespace Numbers.Tests
{
  [TestClass]
  public class PrimeTests : IDisposable
  {

    public void Dispose()
    {
      Prime.ClearAll();
    }

    [TestMethod]
    public void PrimeConstructor_ReturnsNumber_Integer()
    {
      // Arrange
      int userInput = 15;
      
      // Act
      Prime newPrime = new Prime(userInput);
      int result = newPrime.UserInput;

      // Assert
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }

    [TestMethod]
    public void CreateArray_ReturnsArray_Array()
    {
      // Arrange
      int userInput = 10;
      Prime testPrime = new Prime(userInput);

      // Act

      // Assert
      Assert.AreEqual(10, testPrime.CreateArray());
      Assert.AreEqual(new)

    }   

  }
}