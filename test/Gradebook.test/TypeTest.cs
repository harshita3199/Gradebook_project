using System;
using Xunit;

namespace Gradebook.test
{
    public class TypeTest
    {

        [Fact]
        public void Test1(){
            var x = GetInt();
            SetInt(ref x);

            // Assert.Equal(3, x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z=42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
           var book1 = GetBook ("Book 1");
           GetBookSetName(ref book1, "New Name");  //we can also use out parameter instead of ref

           

           Assert.Equal("New Name",book1.Name);
        
        }

        private void GetBookSetName(ref Book book, string name)     //ref means the first para is passed is by reference i.e., not a copy of the value which is in the variable but a mem locatn

        {
            book = new Book(name);    //constructing a new book object and storing a reference to that object in book variable.
            // book.Name=name;
        }



        [Fact]
        public void CSharpIsPassByValue()
        {
           var book1 = GetBook ("Book 1");
           GetBookSetName(book1, "New Name");

           

           Assert.Equal("Book 1",book1.Name);
        
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);    //constructing a new book object and storing a reference to that object in book variable.
            book.Name=name;
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook ("Book 1");
           var book2 = GetBook ("Book 2");

           Assert.Equal("Book 1",book1.Name);
           Assert.Equal("Book 2",book2.Name);
           Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarscanReferenceSameObject()
        {
           var book1 = GetBook ("Book 1");
           var book2 = book1;   //take the value inside the book1, that value is a pointer i.e. reference to copy that value into book 2 variable so same pointer value

        //    Assert.Equal("Book 1",book1.Name);
        //    Assert.Equal("Book 1",book2.Name);
           Assert.Same(book1, book2);
           Assert.True(object.ReferenceEquals(book1,book2));
        }
        Book GetBook(string name)
        {
            return new Book(name);

        }

    }
}
