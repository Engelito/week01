namespace teach_01;

public static class ArraySelector
{ 
    public static void Run()
    { 
        
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}

        var l3 = new[] { 'A', 'A', 'A', 'A', 'A'};
        var l4 = new[] { 'B', 'B', 'B', 'B', 'B'};
        select = new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2};
        var charResult = ListSelector(l3, l4, select);
        Console.WriteLine("<char[]>{" + string.Join(", ", charResult) + "}"); // <char[]>{A, B, A, B, A, B, A, B, A, B}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var newInt = new int[select.Length];
        var array1Index = 0;
        var array2Index = 0;
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
                newInt[i] = list1[array1Index++];
            else
                newInt[i] = list2[array2Index++];
        }
        return newInt;
    }

    private static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        var newInt = new Char[select.Length];
        var array1Index = 0;
        var array2Index = 0;
        for (int i = 0; i < select.Length; i++)
        {
            newInt[i] = select[i] == 1 ? list1[array1Index++] : list2[array2Index++];
        }
            return newInt;
    }
}