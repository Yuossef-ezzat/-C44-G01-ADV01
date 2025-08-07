namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] array = { 5, 2, 9, 1, 5, 6 };
            Helper<int>.bubbleSort(array);
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }
            #endregion 
            #region Q2
            Range<int> range = new Range<int>(1, 10);
            Console.WriteLine($"is in range: {range.IsInRange(14)}");
            Console.WriteLine($"Length of range: {range.Length()}");
            #endregion
            
        }
    }
}
