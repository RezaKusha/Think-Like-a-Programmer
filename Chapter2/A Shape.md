this is shape of 'A' i created.

```
      #
     # #
    #   #
   #     #
  # # # # #
 #         #
#           #

```
the first line is Console.WriteLine("      #");
the line 2 - 3 - 4 is for loop;
the 5th line is Console.WriteLine("  # # # # #");
the line 6 - 7 is for loop;

```
First loop:

1 2 3   row = i
5 4 3   space = 6 - i
1 1 1   # = i * 0 + 1
1 3 5   midSpace = i2 - 1
1 1 1   # = i * 0 + 1

Second loop:

1 2     row = i
1 0     space = 2 - i
1 1     # = i * 0 + 1
9 11    midSpace = i2 + 7
1 1     # = i * 0 + 1

```
```
internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("      #");
            for (int i = 1; i <= 3; i++)
            {
                for (int space = 1; space <= 6-i; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 1; column <= i*0 + 1; column++)
                {
                    Console.Write("#");
                }
                for (int space = 1; space <= (i*2)-1; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 1; column <= i*0 + 1; column++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine("  # # # # #");
            for (int i = 1; i <= 2; i++)
            {
                for (int space = 1; space <= 2-i; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 1; column <= i*0 + 1; column++)
                {
                    Console.Write("#");
                }
                for (int space = 1; space <= (i*2)+7; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 1; column <= i*0 + 1; column++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
```