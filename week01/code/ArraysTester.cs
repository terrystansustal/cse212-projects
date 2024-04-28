public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // The first step is to initialize the array to store the multiples (somewhat similar to the ArraySelector.cs assignment)
        // The size of this new array will be equal to the length and the array will store the multiples of "number"
        double[] multiples = new double[length];

        // The second step is to create a for loop. This step is very crucial because we need our program to interate a number of times (length).
        // The index of the for loop will start at 0 until it reaches the length by adding 1 (i++)
        for (int i = 0; i < length; i++) {

            // for each interation inside the for loop, the function will calculate the given "numbers" by multiplying it by (i + 1).
            multiples[i] = number * (i + 1);
        }

        // The last step will return the results of the multiples array.
        return multiples;
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    /// 

    private static void RotateListRight(List<int> data, int amount)
    {
        // The first step is to normalize the rotation amount. Using the modulo(%) makes sure the rotation amount doesn't exceed the length of my list
        // This method is a great way to handle programs where the rotation amount might be greater than the size of the list
        amount %= data.Count;
        if (amount == 0)
            return;
        
        // The second step is to set up the index
        // The index will calculate to determine which point in the last from the data that will move to the right
        // This method is executed by subtracting the "amount" from the total of numbers in the list
        int index = data.Count - amount;

        // A new list called the temporaryList will store the rearranged list
        // The two parameters from the data.GetRange indicates the starting index from where the range should begin in the list
        // and amount should specify the number of data to include in the range starting from the index
        List<int> temporaryList = new List<int>(data.GetRange(index, amount));
        temporaryList.AddRange(data.GetRange(0, index));

        // This for loop will update the original list with the content of the temporaryList
        for (int i = 0; i < data.Count; i++)
        {
            data[i] = temporaryList[i];
        }
    }

}
