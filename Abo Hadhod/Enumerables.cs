//// Enumerables ابجكت قابل للعد اقدر اعمل عليه لوب اي حاجه بتقدر تعمل عليه لوب  مثال الاري
//// throw يستخدم لرمي استثناء اكسبشن عند حدوث خطا او حاله غير متوقعه
////عمله يوقف تنفيذ الداله يتم استخدامه لرمي استثناء من نوع name هو null

////IEnumerator عداد يراقب الطريق مثل اللست لما توصل لنهايتها





//public class Program
//{


//    static async Task Main(string[] args)
//    {
//        var employee = new Employee();
//        employee.AddPayItem("Bisic salary", 1000);
//        employee.AddPayItem("Housing", 500);
//        employee.AddPayItem("Transportation", 200);
//        employee.AddPayItem("Insurance", -300);

//        foreach (var payItem in employee)
//            Console.WriteLine($"{payItem.Name} = {payItem.Value}");
//    }


//}

//public class Employee
//{
//    private readonly List<PayItem> _payItems = new();

//    public string Name { get; set; }

//    public void AddPayItem(string name, int value)
//    {
//        if (string.IsNullOrEmpty(name))
//            throw new ArgumentNullException("name");
//        _payItems.Add(new PayItem { Name = name, Value = value });
//    }

//    public IEnumerator<PayItem> GetEnumerator()
//    {
//        return _payItems.GetEnumerator();
//    }
//}

//public class PayItem
//{
//    public string Name { set; get; }
//    public int Value { set; get; }
//}


