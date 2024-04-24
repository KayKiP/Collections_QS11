namespace Collection_Qs11
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            NumCollection<int> intNum = new NumCollection<int>();
            intNum.AddNum(1);
            intNum.AddNum(2);
            intNum.AddNum(3);
            intNum.AddNum(4);
           
            Console.WriteLine("Last Number is: " + intNum.GetNum(3));
            
            List<int> sortCollection = intNum.DescNum();
            Console.WriteLine("Sorted numbers in descending order:");
            foreach (var num in sortCollection)
            {
                Console.WriteLine(num);
            }
        }
    }
}
