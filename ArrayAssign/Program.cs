using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] empArray = new Employee[3];

            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine("Enter EMP ID : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter EMP Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary : ");
                int salary = Convert.ToInt32(Console.ReadLine());

                empArray[i] = new Employee(id, name);

            }

            int max_salary = empArray[0].Salary;
            int flag = 0;
            for (int i = 0; i < empArray.Length; i++)
            {
                if (empArray[i].Salary > max_salary)
                {
                    max_salary = empArray[i].Salary;
                    flag = i;

                }

            }
            Console.WriteLine("Details of highest salary student : ");
            Console.WriteLine("Name : " + empArray[flag].Name);
            Console.WriteLine("Salary : " + empArray[flag].Salary);

            Console.WriteLine();

            Console.WriteLine("Enter ID to search : ");
            int sid = Convert.ToInt32(Console.ReadLine());
            int s_id = 0;
            for (int i = 0; i < empArray.Length; i++)
            {
                if (empArray[i].Id == sid)
                {
                    s_id = empArray[i].Id;
                    break;
                }
            }
            Console.WriteLine("Details of {0} student Id : ", sid);
            Console.WriteLine("Name : " + empArray[s_id].Name);
            Console.WriteLine("Salary : " + empArray[s_id].Salary);


        }



    }

    public class Employee
    {

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int salary;

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Employee(int id = 1, string name = "noname", string email = "noemail", int salary = 0)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}
