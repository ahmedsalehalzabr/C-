
//using System;

//namespace Abo

//{
//    class clsPerson
//    {
//        //fileds
//        public string FirstName;
//        public string LastName;

//        //method 
//        public string FullName()
//        {
//            return FirstName + ' ' + LastName;
//        }
//    }


//    internal class Program
//    {
//        static void Main(string[] args)
//        {



//            Console.WriteLine(Setting.DayNumber);
//            Console.WriteLine(Setting.DayName);
//            Setting.Project = "ahmedahmed";
//            Console.WriteLine(Setting.Project);


//            clsEmployee employee = new clsEmployee();
//            employee.ID = 1;
//            employee.Name = "Ahmed Alzabr";

//            Console.WriteLine("\n employee");
//            Console.WriteLine(employee.ID);
//            Console.WriteLine(employee.Name);





//            clsD D = new clsD();

//            D.x1 = 10;
//            clsD.x2 = 20;

//            Console.WriteLine("\n Beb");
//            Console.WriteLine(D.x1);
//            Console.WriteLine(clsD.x2);
//            Console.WriteLine(D.Method1());
//            Console.WriteLine(clsD.Method2());



//            clsPerson Person1 = new clsPerson();

//            Console.WriteLine("Ahmed Alzabr");
//            Person1.FirstName = "Mohmed";
//            Person1.LastName = "Alzaber Saleh";

//            Console.WriteLine(Person1.FullName());

//            //Create object from class
//            clsA A = new clsA();

//            //all public members are accessable and internal 
//            Console.WriteLine("All public members are accessable");
//            Console.WriteLine("x1={0}", A.x1);
//            Console.WriteLine("result of fun1={0}", A.fun1());

//            //you cannot access private members in the folling line.
//            //Console.WriteLine("x2={0}", A.x2);

//            //you cannot access protected members in the folling line.
//            // Console.WriteLine("x3={0}", A.x3);

//            //you cannot access private members in the folling line.
//            // Console.WriteLine("result of fun2={0}", A.fun2());

//            //you cannot access protected members in the folling line.
//            // Console.WriteLine("result of fun3={0}", A.fun3());

//            clsB B = new clsB();
//            Console.WriteLine("\nObjects from class B expose all public members from the base class");
//            Console.WriteLine("x1={0}", B.x1);
//            Console.WriteLine("result of fun1={0}", B.fun1());

//            //you cannot access private members in the folling line.
//            //Console.WriteLine("x2={0}", B.x2);
//            // Console.WriteLine("result of fun1={0}", B.fun2());

//            //you cannot access protected members in the folling line.
//            // Console.WriteLine("x3={0}", B.x3);
//            //Console.WriteLine("result of fun3={0}", B.fun3());

//            Console.ReadKey();



//        }
//    }

//    class clsA
//    {
//        public int x1 = 10;
//        private int x2 = 20;
//        protected int x3 = 30;

//        public int fun1()
//        {
//            return 100;
//        }

//        private int fun2()
//        {
//            return 200;
//        }

//        protected int fun3()
//        {
//            return 300;
//        }

//        internal int fun10()
//        {
//            return x1 + x2 - x3;
//        }

//    }

//    class clsB : clsA
//    {
//        public int fun4()
//        {
//            //x1 is public and x3 is protected in the base class so you can access them.
//            //You cannot access any private members of the base class.
//            return x1 + x3;
//        }

//    }

//    class clsD
//    {
//        public int x1;
//        public static int x2;

//        public int Method1()
//        {
//            return x1 + x2;
//        }

//        public static int Method2()
//        {
//            return x2;

//        }
//    }

//    class clsEmployee
//    {
//        //filed
//        private int _ID;
//        private string _Name = string.Empty;

//        //properties
//        public int ID
//        {
//            get
//            {
//                return _ID;
//            }
//            // عند حذف ال set لا نستطيع التعديل على ال id 
//            set
//            {
//                _ID = value;
//            }
//        }

//        public string Name
//        {
//            get
//            {
//                return _Name;
//            }

//            set
//            {
//                _Name = value;
//            }
//        }
//    }


//    static class Setting
//    {
//        public static int DayNumber
//        {
//            get
//            {
//                return DateTime.Today.Day;
//            }
//        }
//        public static string DayName
//        {
//            get
//            {
//                return DateTime.Today.DayOfWeek.ToString();
//            }
//        }
//        public static string Project { get; set; }
//    }


//    class clsPersons
//    {

//        // 1- Parameterless Constructor
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public clsPersons()
//        {
//            Id = -1;
//            Name = "Empty";
//            Age = 0;
//        }
//        // opject => clsPersons cls = new clsPersons();
//    }

//    class clsPerson2
//    {

//        //4- Multiple Constructors
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public clsPerson2()
//        {
//            this.Id = -1;
//            this.Name = "Empty";
//            this.Age = 0;
//        }

//        public clsPerson2(int Id, string Name, short Age)
//        {
//            this.Id = Id;
//            this.Name = Name;
//            this.Age = Age;
//        }
//    }

//    class clsPersons2
//    {

//        // 2- Parameterized Constructor
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public clsPersons2(int Id, string Name, int Age)
//        {
//            this.Id = Id;
//            this.Name = Name;
//            this.Age = Age;
//        }

//    }
//    // opject => clsPersons2 cls = new clsPersons2(10,"Ahmed",28);

//    // 3- Default Constructor في كلاس موجود غير ظاهر وبدون برميتر
//    class clsPersons3
//    {

//        // 5- Static Constructor
//        //بدون براميتر عى مستوى الكلاس فقط 
//        static clsPersons3()
//        {

//        }

//    }


//    // لا ناخذ ابجكت من الكلاس الي محتواه ستاتك لان الي شي استاتك يعتبر شرد ناخذة باسم الكلاس فقط

//    // private constructor or static class  يمنعنا من اخذ ابجكت من الكلاس

//    // function overloading فانكشن بنفس الاسم باختلاف البيانات والبراميتر

//    // Destructor هدم او الغاء الابجكت



//    // inhertence

//    class Ahmed
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public Ahmed(int Id, string Name, int Age)
//        {
//            this.Id = Id;
//            this.Name = Name;
//            this.Age = Age;
//        }
//    }

//    class Saleh : Ahmed
//    {
//        public int Salary { get; set; }
//        public string job { get; set; }

//        public Saleh(int Id, string Name, int Age, int Salary, string job) : base(Id, Name, Age)
//        {
//            this.Salary = Salary;
//            this.job = job;


//        }
//    }


//    // Method override  Inheritance + Base Keyword
//    // في البيس كلاس تكون فرشول وفي تشايلد كلاس تكون اوفررايد
//    //يتم طباعت الي تم التعديل عليها 

//    public class B1
//    {
//        public virtual void Part()
//        {
//            Console.WriteLine("hi");

//        }
//        public virtual void Part2()
//        {
//            Console.WriteLine("hi");

//        }
//    }

//    public class B2 : B1
//    {
//        //تم الغا الي فوق
//        public override void Part()
//        {
//            base.Part();
//            Console.WriteLine("hi beb");
//        }

//        //  Method Hiding
//        public new void Part2()
//        {

//        }
//    }


//    // Abstract Class & Methods الكلاس يكون للتوريث ماينفع اخذ منة ابجكت

//    // ال implemention تكون بين كلاس وانترفيس 



//    // Implementing Multiple Interfaces
//    // الانتر فيس مثل العقد يلزمك تكنب كل الي موجود فيه 

//    public interface IAhmed
//    {
//        public int Age { get; set; }
//        public string Name { get; set; }

//        public void Game();


//    }
//    public interface IAli
//    {
//        public string job { get; set; }
//        public void Job();
//    }

//    public class Zabr : IAhmed, IAli
//    {
//        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        public string job { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public void Game()
//        {
//            throw new NotImplementedException();
//        }

//        public void Job()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    // Nested class كلاس داخله كلاس

//    public class A1
//    {
//        public string job { get; set; }
//        public A1(string job)
//        {
//            this.job = job;
//        }

//        public class A2
//        {
//            public int salary { get; set; }

//            public A2(int salary)
//            {
//                this.salary = salary;
//            }
//        }
//    }
//    // الابجكت => A1.A2 inner = new A1.A2();


//    // Composition تعمل ابجكت لكلاس داخل كلاس اخر

//    // Sealed Class عمل قفل للكلاس ماتقدر تورث منة

//    // Partial class جز من كلاس الكمبايلر يدمج الثنان منهPartial Methods لاتستخدم الا في كلاس بارشل

//    // Polymorphism تعدد الاشكال 1- الاوفر لودنق 

//    // class library
//    //namespace مجموعه فيها عدة كلاسات


//    // Delegate





//    /// DDD domain driven design
//    /// يعمل على ازالة التعقيدات ويعمل على تحسين التواصل بينك وبين الناس بتوع البزنز 
//    /// تزيل التعقيدات ومصممه للبرامج الكبيره
//    /// يسهل العمل ك تيم
//    /// معنا الدومين توجيه السفت وير تبعي كيف يمشي 
//    /// فايدته يقسم المشروع الى مديولات وتكون فاهم الدومين والكور تبعة وتكون عارف متى اتخلص 
//    /// زيادة المرونة والقدرة على التكيف

//    /// DDD phases => 

//    /// 1-Tactical 
//    /// value objects
//    /// entities
//    /// aggregates
//    /// domain services 
//    /// domain events
//    /// repositories
//    /// CQRS

//    /// 2- Strategic
//    /// -subdomains في problem space
//    //////Sub domain دومين يتقسم الى عدة دومينات
//    //////Categories Subdomain
//    //////1-core Domain وكل سب يكن يتجزاء
//    //////2- Supporting Domain هذا يخدم الكور مثل النتفكايشن سستيم
//    //////3- Generic Domain => solved problem مشكله محلوله

//    /// -bounded contexts في problem solution
//    ////// سياق محدد, تحل به مشكله التواصل او الشغل مع الفريق

//    /// -ubiquitous language اللغة المشتركه في problem solution
//    ////// جسر للتواصل بين فريق البزنس والتقنيين تقلل سوء الفهم تحسن التواصل توجيه التصميم
//    /// context maps
//    /// shared kernel
//    /// anticorruption layer
//    /// up and dpwn streams
//    /// 


//}