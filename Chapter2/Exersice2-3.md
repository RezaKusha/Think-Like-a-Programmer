```
0 1 2 3   rows = i
0 1 2 3   space = i
1 2 3 4   # = i + 1
12 8 4 0  midSpace = 12 - i4
1 2 3 4   # = i + 1
----------------------------------
4 5 6 7   rows = j
3 2 1 0   space = 7 - j
4 3 2 1   # = 8 - j
0 4 8 12  midSpace = j4 - 16
4 3 2 1   # = 8 - j
----------------------------------
```
```
#            #
 ##        ##
  ###    ###
   ########
   ########
  ###    ###
 ##        ##
#            #

```

```
internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int space = 0; space < i; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 0; column < i + 1; column++)
                {
                    Console.Write("#");
                }
                for (int space = 0; space < 12 - i * 4; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 0; column < i + 1; column++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            
            for (int j = 4; j < 8; j++)
            {
                for (int space = 0; space < 7 - j; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 0; column < 8 - j; column++)
                {
                    Console.Write("#");
                }
                for (int space = 0; space < j * 4 - 16; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 0; column < 8 - j; column++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }

```