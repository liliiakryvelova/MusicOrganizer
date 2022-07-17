using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

  [TestMethod]
  public void GetName_ReturnsName_String()
  {
    //Arrange
    string artistname = "Madonna";
    Artist newArtist = new Artist(artistname);

    //Act
    string result = newArtist.ArtistName;

    //Assert
    Assert.AreEqual(artistname, result);
  }

  //Test that we can retrieve Artist IDs
  [TestMethod]
  public void GetId_ReturnsArtistId_Int()
  {
    //Arrange
    string artistname = "Madonna";
    Artist newArtist = new Artist(artistname);

    //Act
    int result = newArtist.Id;

    //Assert
    Assert.AreEqual(1, result);
  }

  [TestMethod]
  public void GetAll_ReturnsAllArtistObjects_ArtistList()
  {
    //Arrange
    string name01 = "Madonna";
    string name02 = "Enrique Iglesias";
    Artist newArtist1 = new Artist(name01);
    Artist newArtist2 = new Artist(name02);
    List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };

    //Act
    List<Artist> result = Artist.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

  [TestMethod]
  public void Find_ReturnsCorrectArtist_Artist()
  {
    //Arrange
    string name01 = "Madonna";
    string name02 = "Enrique Iglesias";
    Artist newArtist1 = new Artist(name01);
    Artist newArtist2 = new Artist(name02);

    //Act
    Artist result = Artist.Find(2);

    //Assert
    Assert.AreEqual(newArtist2, result);
  }

  [TestMethod]
  public void AddRecord_AssociatesRecordWithArtist_List()
  {
    //Arrange
    string title = "Walk the dog.";
    Record newRecord = new Record(title);
    List<Record> newList = new List<Record> { newRecord };
    string artistname = "Work";
    Artist newArtist = new Artist(artistname);
    newArtist.AddRecord(newRecord);
    

    //Act
    List<Record> result = newArtist.Records;

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

  }
}