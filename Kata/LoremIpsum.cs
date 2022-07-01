namespace Kata;

using System;

public static class LoremIpsum
{
    private static void printWord(Random rand, bool first)
    {
        int numberOfChar = rand.Next(2, 7);
        char c;

        for (int i = 0; i < numberOfChar; i++) {
            if (first && i == 0)
                c = (char)('A' + rand.Next(0, 26));
            else
                c = (char)('a' + rand.Next(0, 26));
            Console.Write(c);
        }
    }

    public static void printText()
    {
        var rand = new Random();

        for (int i = 0; i < 100; i++) {
            int numberOfCount = rand.Next(3, 8);

            for (int j = 0; j < numberOfCount; j++) {
                printWord(rand, j == 0);
                if (!(j + 1 == numberOfCount))
                    Console.Write(' ');
            }
            Console.Write(". ");
            if (rand.Next(0, 10) <= 5)
                Console.Write('\n');
        }
    }
}