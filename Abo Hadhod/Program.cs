
using System;

namespace Abo

{
class clsPerson
{
    //fileds
    public string FirstName;
    public string LastName;

    //method 
    public string FullName()
    {
        return FirstName + ' ' + LastName;
    }
}


    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Setting.DayNumber);
            Console.WriteLine(Setting.DayName );
            Setting.Project = "ahmedahmed";
            Console.WriteLine(Setting.Project);


            clsEmployee employee = new clsEmployee();
            employee.ID = 1;
            employee.Name = "Ahmed Alzabr";

            Console.WriteLine("\n employee");
            Console.WriteLine(employee.ID);
            Console.WriteLine(employee.Name);
            




            clsD D = new clsD();

            D.x1 = 10;
           clsD.x2 = 20;

            Console.WriteLine("\n Beb");
            Console.WriteLine( D.x1);
            Console.WriteLine( clsD.x2);
            Console.WriteLine( D.Method1());
           Console.WriteLine( clsD.Method2());



            clsPerson Person1 = new clsPerson();

            Console.WriteLine("Ahmed Alzabr");
            Person1.FirstName = "Mohmed";
            Person1.LastName = "Alzaber Saleh";

            Console.WriteLine(Person1.FullName());

            //Create object from class
            clsA A = new clsA();

            //all public members are accessable and internal 
            Console.WriteLine("All public members are accessable");
            Console.WriteLine("x1={0}", A.x1);
            Console.WriteLine("result of fun1={0}", A.fun10());

            //you cannot access private members in the folling line.
            //Console.WriteLine("x2={0}", A.x2);

            //you cannot access protected members in the folling line.
            // Console.WriteLine("x3={0}", A.x3);

            //you cannot access private members in the folling line.
            // Console.WriteLine("result of fun2={0}", A.fun2());

            //you cannot access protected members in the folling line.
            // Console.WriteLine("result of fun3={0}", A.fun3());

            clsB B = new clsB();
            Console.WriteLine("\nObjects from class B expose all public members from the base class");
            Console.WriteLine("x1={0}", B.x1);
            Console.WriteLine("result of fun1={0}", B.fun4());

            //you cannot access private members in the folling line.
            //Console.WriteLine("x2={0}", B.x2);
            // Console.WriteLine("result of fun1={0}", B.fun2());

            //you cannot access protected members in the folling line.
            // Console.WriteLine("x3={0}", B.x3);
            //Console.WriteLine("result of fun3={0}", B.fun3());

            Console.ReadKey();



        }
    }

    class clsA
    {
        public int x1 = 10;
        private int x2 = 20;
        protected int x3 = 30;

        public int fun1()
        {
            return 100;
        }

        private int fun2()
        {
            return 200;
        }

        protected int fun3()
        {
            return 300;
        }

        internal int fun10()
        {
            return x1 + x2 - x3;
        }
        
    }

    class clsB : clsA
    {
        public int fun4()
        {
            //x1 is public and x3 is protected in the base class so you can access them.
            //You cannot access any private members of the base class.
            return x1 + x3;
        }

    }

    class clsD
    {
        public int x1;
        public static int x2;

        public int Method1()
        {
            return x1 + x2;
        }

        public static int Method2()
        {
            return x2;

        }
    }

    class clsEmployee
    {
        //filed
        private int _ID;
        private string _Name = string.Empty;

        //properties
        public int ID
        {
            get
            {
                return _ID;
            }
            // عند حذف ال set لا نستطيع التعديل على ال id 
            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }
    }


    static class Setting
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }
        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }
        public static string Project { get; set; }
    }
  

    class clsPersons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPersons()
        {
            Id = -1;
            Name = "Empty";
            Age = 0;
        }

    }
}