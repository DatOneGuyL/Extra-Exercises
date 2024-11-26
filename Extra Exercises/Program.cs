class ExtraExercise
/* 37. Write a C# Sharp program that calculates the smallest gap between numbers in an array of integers. 
Sample Data: ({ 7, 5, 8, 9, 11, 23, 18 }) -> 1
             ({ 200, 300, 250, 151, 162 }) -> 11 */
{
    static void Main()
    {
        Console.Write("Enter numbers spaced apart: ");
        string FirstInput = Console.ReadLine();
        FirstInput = FirstInput.Trim();
        string[] StringSplits = FirstInput.Split(", ");
        int[] ints = Array.ConvertAll(StringSplits, int.Parse);

        smallestGap(ints);
    }

    static void smallestGap(int[] arr)
    {
        int gap = arr[1] - arr[0];
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
}