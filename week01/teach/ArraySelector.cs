public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // Create a new array of integers. The size of this new array depends on the length of the array 'select'
        var result = new int[select.Length];

        // Set the indexes of list 1 and list 2 to ZERO
        var l1Index = 0;
        var l2Index = 0;

        // Create a for loop that will loop through the selector array
        for (var i = 0; i < select.Length; i++) {
            if (select[i] == 1) {
                result[i] = list1[l1Index++];
            }

            else {
                result[i] = list2[l2Index++];
            }
        }

        return result;
    }
}