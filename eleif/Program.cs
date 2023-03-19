namespace mysecondproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<=0||num>100)
            {
                Console.WriteLine("wrong number ");
            }
            else if(num>0&&num<50)
            {
                Console.WriteLine("fail");
            }
            else if(num>=50&&num<60)
            {
                Console.WriteLine("D-Grade");
            }
            else if(num>=60&& num<70)
            {
                Console.WriteLine("C-Grade");
            }
            else if(num>=70&&num<80)
            {
                Console.WriteLine("B-Grade");
            }
            else if(num>=80&&num<=100)
            {
                Console.WriteLine("A-Grade");
            }    
        }
    }
}