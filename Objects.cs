




  using System;


  namespace NamespaceName
  {

    class Book{


      private static string title;
      private static string author;
      private static int pages;

      public Book(string aTitle, string aAuthor, int aPages){

          title = aTitle;
          author = aAuthor;
          pages = aPages;
      }

      public string getTitle(){

        return title;
      }

      public string getAuthor(){
        return author;
      }

      public int getPages(){
        return pages;
      }


    }


    class Program1 {

      public static void Main(string[] args)
      {
        string title,author;
        int pages;
        Console.Write("Please enter the title of the book: ");
        title = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Please enter the author's name: ");
        author = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Please enter the number of pages: ");
        pages = Convert.ToInt32(Console.ReadLine());

          Book book = new Book(title,author,pages);

          title = book.getTitle();
          author = book.getAuthor();
          pages = book.getPages();


      Console.WriteLine("NEW BOOK: " + title + " made by " + author + " number of pages " + pages );

      }





    }



  }
