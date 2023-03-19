internal class Program
{
    private static void Main(string[] args)
    {
        int Isfulltime = 1;
        int emp_rate_hour = 20;
        int emphrs = 0;
        int employe_part_time = 2;
        int employeewage = 0;
        Random random = new Random();
        int emcheck = random.Next(1, 3);
        if(emcheck==Isfulltime)
        {
            emphrs = 8;
        }
        else if(employe_part_time==emcheck)
        {
            emphrs = 4;
        }
        else
        {
            emphrs = 0;
        }
        employeewage = emphrs * emp_rate_hour;
        Console.WriteLine("Empwage :" + employeewage);

    }
}