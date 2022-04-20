using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_session
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            list.Add(new Employee(111,"Nilesh",35000,"pune"));
            list.Add(new Employee(222, "Rahul", 14000,"nashik"));
            list.Add(new Employee(333, "ganesh", 37000,"ahmednagar"));
            list.Add(new Employee(444, "vicky", 12000,"aurangabad"));
            list.Add(new Employee(555, "lakhan", 39000,"baramati"));
            list.Add(new Employee(333, "ravi", 41000, "pune"));
            list.Add(new Employee(444, "nikhil", 12000, "aurangabad"));
            list.Add(new Employee(555, "vikas", 39000, "baramati"));
            list.Add(new Employee(333, "dyani", 55000, "ahmednagar"));
            list.Add(new Employee(444, "amir", 61000, "aurangabad"));
            list.Add(new Employee(555, "sachin", 31000, "pune"));

            list.Insert(0, new Employee(444, "vicky", 38000,"aurangabad"));

            Console.WriteLine("-------------condition salary-----------");

            var result = from data in list 
                         where data.EmpSalary >= 15000 && data.EmpSalary<=40000
                         orderby data.EmpName descending
                         select data;
            foreach(Employee emp in result)
            {
                Console.WriteLine(emp);
            }
                         
            Console.WriteLine("________________Condition city_______________________");
            var result1 = from data in list
                          where data.EmpCity.Contains("pune")
                          //orderby data.EmpSalary  //this is by default ascending order
                          orderby data.EmpSalary descending
                          select data;
            foreach(Employee emp1 in result1)
            {
                Console.WriteLine(emp1);
            }
            Console.WriteLine("________________________________________________");
            
            foreach (Employee e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("------------------------------------------");
            for(int i=0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("=================================Product Information==================================");
            
            List<Product> p = new List<Product>();

            p.Add(new Product(111,"Laptop","Electronic products"));
            p.Add(new Product(222, "Sofa","Furniture Products"));
            p.Add(new Product(333, "Bed", "Furniture Products"));
            p.Add(new Product(444, "SONY Tv", "Electronic products"));

            p.Insert(0, new Product(777, "Oven", "Electronic Equipment"));

            foreach (Product pp in p)
            {
                Console.WriteLine(pp);
            }
            Console.WriteLine("------------------------------------------");
            for (int i = 0; i < p.Count; i++)
            {
                Console.WriteLine(p[i]);
            }



        }
    }
}
