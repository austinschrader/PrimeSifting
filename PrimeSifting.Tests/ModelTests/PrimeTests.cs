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
    public void GetNumber_ReturnsNumber_Integer()
    {
      Prime newPrime = new Prime(15);
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   // Arrange
    //   string description = "Walk the dog.";
    //   Prime newPrime = new Prime(description);

    //   // Act
    //   string result = newPrime.Description;

    //   // Assert
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   // Arrange
    //   string description = "Walk the dog.";
    //   Prime newPrime = new Prime(description);

    //   // Act
    //   string updatedDescription = "Do the dishes";
    //   newPrime.Description = updatedDescription;
    //   string result = newPrime.Description;

    //   // Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_PrimeList()
    // {
    //   // Arrange
    //   List<Prime> newList = new List<Prime> { };

    //   // Act
    //   List<Prime> result = Prime.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnPrimes_PrimeList()
    // {
    //   // Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Prime newPrime1 = new Prime(description01);
    //   Prime newPrime2 = new Prime(description02);
    //   List<Prime> newList = new List<Prime> { newPrime1, newPrime2 };

    //   // Act
    //   List<Prime> result = Prime.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}