using System;

namespace hw62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("salary: ");
            double salary, tax;
            salary = double.Parse(Console.ReadLine());
            
            if (salary < 150001)
            {
                tax = salary;
            }
            else if (salary < 300001)
            {
                tax = (salary * 5) / 100;
            }
            else if (salary < 500001)
            {
                tax = (salary * 10) / 100;
            }
            else if (salary < 750001)
            {
                tax = (salary * 15) / 100;
            }
            else if (salary < 1000001)
            {
                tax = (salary * 20) / 100;
            }
            else if (salary < 2000001)
            {
                tax = (salary * 25) / 100;
            }
            else if (salary < 5000001)
            {
                tax = (salary * 30) / 100;
            }
            else
            {
                tax = (salary * 35) / 100;
            }
            Console.WriteLine("Your tax is:{0}", tax);
        }
    }
}
