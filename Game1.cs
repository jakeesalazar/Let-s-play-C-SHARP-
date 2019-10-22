




using System;
using System.Collections.Generic;



namespace NamespaceName
{

  class Game1
  {


   public static string[,] board = new string[20,20];
   public static int xpos = 10;
   public static int ypos = 10;

   public static void initialize(){


     for (int i =0; i<20;i++) {

       for (int j =0; j<20; j++) {
              board[i,j] = " * ";
              if (i == 10 && j ==10)
              board[i,j] = " 0 ";
       }

     }

     for (int i =0; i<20;i++) {

       for (int j =0; j<20; j++) {
         Console.Write(board[i,j]);
       }
       Console.WriteLine();

     }
   }


    public static void display(){

      for (int i =0 ; i<20; i++) {

        for (int j=0; j<20; j++) {

            Console.Write(board[i,j]);
          }
          Console.WriteLine();
      }
    }


    public static void changePos(char x){

      if (x == 'w')
      {
        board[xpos,ypos] = " * ";
        xpos--;
        board[xpos,ypos] = " 0 ";
      }
      else if (x == 'd') {
        board[xpos,ypos] = " * ";
        ypos++;
        board[xpos,ypos] = " 0 ";
      }
      else if (x == 's') {

        board[xpos,ypos] = " * ";
        xpos++;
        board[xpos,ypos] = " 0 ";

      }
      else if (x=='a') {

        board[xpos,ypos] = " * ";
        ypos--;
        board[xpos,ypos] = " 0 ";
      }

      display();

    }



    public static void Main(string[] args)
    {


        Console.Write("press any key to start!: ");
        ConsoleKeyInfo input = Console.ReadKey();
        Console.Clear();

        initialize();

      while(input.KeyChar != '0'){

        input = Console.ReadKey();

        if (input.KeyChar == 'a'){
          Console.Clear();
          changePos(input.KeyChar);
        }
        else if (input.KeyChar == 's'){
          Console.Clear();
          changePos(input.KeyChar);
        }
        else if (input.KeyChar == 'd') {
          Console.Clear();
          changePos(input.KeyChar);
        }
        else if (input.KeyChar == 'w'){
          Console.Clear();
          changePos(input.KeyChar);
        }
      }




    }



  }


}
