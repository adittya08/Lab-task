using System;

namespace lab_2
{
    class Program
    {
        /*(1)  static void Main(string[] args)
          {
              int n = 100;
              Console.WriteLine("Even Numbers from 1 to " + n + " are: ");
              for (int i = 1; i <= n; i++)
              {

                  if (i % 2 == 0)
                  {
                      Console.WriteLine(i + " ");

                  }

              }

          }*/




        /*(2)  static void Main(string[] args)
          {
              for (int i = 0; i < 4; i++)
              {
                  for (int j = 0; j < 6; j++)
                  {
                      if (i % 2 == 0)
                      {
                          if (j % 2 == 0)
                              Console.Write("X");
                          else
                              Console.Write("0");
                      }

                      else
                      {
                          if (j % 2 == 0)
                              Console.Write("0");
                          else
                              Console.Write("X");
                      }

                  }
                  Console.WriteLine();


              } */

        /*(3)  static void Main(string[] args)
          {
              for (int i = 1; i <= 5; i++)
              {
                  int j = i;
                  int count = 0;
                  while (count < 5)
                  {
                      Console.Write(j);
                      count++;
                      j++;
                  }
                  Console.WriteLine();

          }*/





        /*(4) static void Main(string[] args)
         {
             int i, num=100, odd_sum = 0, even_sum = 0;

             for (i = 1; i <= num; i++)
             {
                 if (i % 2 == 0)
                     even_sum = even_sum + i;
                 else
                     odd_sum = odd_sum + i;
             }
             Console.WriteLine("Sum of all odd numbers  = "+ odd_sum);
             Console.WriteLine("Sum of all even numbers = "+ even_sum);

         } */




       /*(5) static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine(""+i);

            }


        } */


        /* (6) static void Main(string[] args)
         {

             int i, num, fact = 1;
             Console.WriteLine(" Please input the number:");
             num = Convert.ToInt32(Console.ReadLine());
             for (i = 1; i <= num; i++)
             {
                 fact = fact * i;
             }

             Console.WriteLine(" The factorial of " + num + " is= " + fact);

         } */

        /* (7)  static void Main(string[] args)
          {
              for (int i = 1; i <= 5; i++)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write("*");

                  }
                  Console.WriteLine("");

              }


              for (int k = 4; k >= 0; --k)
              {

                  for (int j = 1; j <= k; j++)
                  {
                      Console.Write("*");

                  }
                  Console.WriteLine("");
              }

          } */

    }
}
