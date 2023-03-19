using System.Net.Http.Headers;

namespace switchcasestatement
{
    internal class Program
    {
        public const int full_time = 1;
        public const int PART_time = 2;
        static void Main(string[] args)
        {
            
            int emp_rate_hour = 20;
            int emphrs = 0;
            int employeewage = 0;
            Random random = new Random();
            int emcheck = random.Next(1, 3);
            switch (emcheck)
            {
                case full_time:
                    emphrs = 8;
                    break;
                case PART_time:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            employeewage = emphrs * emp_rate_hour;
            Console.WriteLine("Empwage :" + employeewage);
        }
    }
}