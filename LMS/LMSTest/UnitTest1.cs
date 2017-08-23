using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMS;
using System.Collections.Generic;

namespace LMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddBooksToLibrary_Test()
        {
            List<Books> dummyBookCollection = new List<Books>();
            Library library = new Library();
            Books book = new Books();
            book.Name = "Brida";
            book.Genre = "Fictional";
            Books book1= new Books();
            book1.Name = "The Time Traveller";
            book1.Genre = "Fictional";
            dummyBookCollection.Add(book);
            dummyBookCollection.Add(book1);
            library.AddBooksToLibrary(book);
            library.AddBooksToLibrary(book1);
            Assert.AreEqual(dummyBookCollection[0].Name, library.BookCollection[0].Name);
            Assert.AreEqual(dummyBookCollection[1].Name, library.BookCollection[1].Name);
            Assert.AreEqual(dummyBookCollection[0].Genre, library.BookCollection[0].Genre);
            Assert.AreEqual(dummyBookCollection[1].Genre, library.BookCollection[1].Genre);
        }
        [TestMethod]
        public void IssueBooks_Test()
        {
            Library library = new Library();
            Books book = new Books();
            book.Name = "Brida";
            book.Genre = "Fictional";
            book.Author = "ABC";
            Books book1 = new Books();
            book1.Name = "The Time Traveller";
            book1.Genre = "Fictional";
            book1.Author = "XYZ";
            library.AddBooksToLibrary(book);
            library.AddBooksToLibrary(book1);
            LibraryManagementSystem manageLibrary = new LibraryManagementSystem();
            manageLibrary.IssueBooks(library.BookCollection[0],"Anoj");
            manageLibrary.IssueBooks(library.BookCollection[1],"Rahul");
            Assert.AreEqual(library.BookCollection[0].Author, "ABC");
        }
        [TestMethod]
        public void ToString_Test()
        {
            BookDescription dummyBookInfo = new BookDescription();
            dummyBookInfo.Name = "Brida";
            dummyBookInfo.Genre = "Fictional";
            dummyBookInfo.Author = "XYZ";
            Books book = new Books();
            book.Name = "Brida";
            book.Genre = "Fictional";
            book.Author = "XYZ";
            LibraryManagementSystem manageLibrary = new LibraryManagementSystem();
            BookDescription bookInfo=manageLibrary.ToString(book);
            Assert.AreEqual(dummyBookInfo.Author, bookInfo.Author);
            Assert.AreEqual(dummyBookInfo.Name, bookInfo.Name);
            Assert.AreEqual(dummyBookInfo.Genre, bookInfo.Genre);

        }
    }
}
