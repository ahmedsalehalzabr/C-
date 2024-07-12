//// Generics معناها نوع عام داخل < >
//// يساعدني في اني احقق مبدا الريوزبلتي وتقلل الكود وتسهله

//using System.Collections;
//using System.Numerics;

//public class Program
//{


//    static async Task Main(string[] args)
//    {
//        // من الابجكت خذ ضيف فيه اي نوع من البيانات 
//        //var arrayList = new ArrayList();
//        //arrayList.Add(true);
//        //arrayList.Add(1);
//        //arrayList.Add(2.5);
//        //arrayList.Add("test");
//        //arrayList.Add(DateTime.Now);
//        //arrayList.Add(new Employee());

//        //var genList = new List<int>();
//        //genList.Add(1);

//        //var genList2 = new List<bool>();
//        //genList2.Add(true);
//        Console.WriteLine(Add(5, 9));
//        Console.WriteLine(Add(5.5, 10));
//        Console.WriteLine(Add(4, -15));

//        var list = new GenericList<int>();
//        list.Add(1);
//        list.Add(2);
//        list.Add(3);
//        list.Add(4);
//        list.Remove(4);
//        var count = list.Count;

//        Console.WriteLine(count);

//    }

//    // لكي يقبل T  بالارقام نعمل where T : INumber<T>
//    public static T Add<T>(T num1, T num2) where T : INumber<T>
//    {
//        return num1 + num2;
//    }
//    public static int Add(int num1, int num2) => num2 + num1;
//    public static double Add(double num1, double num2) => num1 + num2;
//    public static decimal Add(decimal num1, decimal num2) => num1 + num2;


//    // <T> علي الكلاس نكتب اي رمز ولما ناخذ انستانس منه نعمل نوع الداتا تايب
//    public class GenericList<T>
//    {
//        private readonly List<T> _items = new();

//        public void Add(T item) { _items.Add(item); }
//        public void Remove(T item) { _items.Remove(item); }

//        public int Count => _items.Count;

//    }
//}




