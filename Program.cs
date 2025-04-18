using System;

class Program
{
    static string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        char[] word = input.ToCharArray(); 
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            // Swap characters
            char temp = word[left];
            word[left] = word[right];
            word[right] = temp;

            left++;
            right--;
        }

        return new string(word);  
    }

    static void Main()
    {
        Console.WriteLine("Enter Your String");
        string original = Console.ReadLine();
        string reversed = ReverseString(original);
        Console.WriteLine("Original: " + original);
        Console.WriteLine("Reversed: " + reversed);

        Console.ReadKey();
    }
}
