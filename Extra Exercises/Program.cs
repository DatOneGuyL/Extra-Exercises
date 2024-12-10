using System.Runtime.Serialization.Formatters;

class ExtraExercise
/* 
37. Write a C# Sharp program that calculates the smallest gap between numbers in an array of integers. 
Sample Data: ({ 7, 5, 8, 9, 11, 23, 18 }) -> 1
             ({ 200, 300, 250, 151, 162 }) -> 11
40. Write a C# Sharp program that takes an array of integers and finds the smallest positive integer that is not present in that array. 
Sample Data: ({ 1,3,2,5,7,6}) -> 4 
             ({-1, -2, 0, 1, 3, 4, 5, 6}) -> 2
41. Write a C# Sharp program to find two numbers in an array of integers whose product is equal to a given number. 
Sample Data: ({10, 18, 39, 75, 100}, 180) -> {10, 18} 
             ({10, 18, 39, 75, 100}, 200) -> {} 
             ({10, 18, 39, 75, 100}, 702) -> {18, 39}
*/

{
    static void Main()
    {
        Console.Write("Enter numbers spaced apart: ");
        string FirstInput = Console.ReadLine();
        FirstInput = FirstInput.Trim();
        string[] StringSplits = FirstInput.Split(", ");
        int[] ints = Array.ConvertAll(StringSplits, int.Parse);

        findComponentsOfProduct(ints);
    }

    static void findComponentsOfProduct(int[] arr)
    {
        Console.Write("Choose product: ");
        int prod = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            if (prod % arr[i] == 0)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] * arr[j] == prod)
                    {
                        Console.WriteLine($"{arr[i]}, {arr[j]}");
                        Environment.Exit(0);
                    }
                }
            }
        }
        Console.WriteLine("There exists none.");
    }

    static void smallestGap(int[] arr)
    {
        int gap = Math.Abs(arr[1] - arr[0]);
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                int tempGap = Math.Abs(arr[i] - arr[j + 1]);
                if (tempGap < gap)
                {
                    gap = tempGap;
                }
            }
        }
        Console.WriteLine(gap);
    }

    static int[] sort(int[] arr)
    {
        //selection sorting by finding smallest element
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int index = i;
            int min = arr[i];

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[index])
                {
                    index = j;
                    min = arr[j];
                }
            }
            int temp = arr[index];
            arr[index] = arr[i];
            arr[i] = temp;
        }

        return arr;
    }
    static void smallestMissingPositiveInt(int[] arr)
    {
        sort(arr);
        int result = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] > 1 && arr[i - 1] + 1 > 0)
            {
                result = arr[i - 1] + 1;
            }
        }
        Console.WriteLine(result);
    }


}
