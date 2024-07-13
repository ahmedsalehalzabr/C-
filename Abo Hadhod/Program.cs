
//LINQ//LINQ فايدتها تنفيذ مؤجل
// الكويري تتنفذ لما تعمل عليها لوب

using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    /* 
 
     * Quantifiers (All,Any, Contains)
     * Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
     * مثل البحث في قوقل يجيب عدة صفحات
     * Set Operations (Distinct, DistinctBy, Except. exeptBy, Intersect, IntersectBy, Union, UnionBy)
     * Joins (Join, GroupJoen)
     * يربط لك بين ادارتين بال ا دي 
     * Grouping (GroupBy, ToLookup)
     */
    
    
    
    static async Task Main(string[] args)
    {
        //Set Operations
        //Distinct تحذف المكررات
        //Intersect تقاطع
        //Union اتحاد
        var n = new List<int> { 1,1,6,2,5, 5, 6, 2, 9, 7, 4, 8, 10, 11, 12, };
        //var query = n.Distinct().OrderBy(x => x);
        var secondList = new List<int> { 1, 2, 4, 5,45,65,88 };
        // يحذف من اللست اللست الجدبده
        //var query = n.Distinct().Except(secondList).OrderBy(x => x);
        var query = n.Union(secondList).OrderBy(x => x);

        foreach (var x in query)
        {
            Console.WriteLine(x);
        }





        // Quantifiers(All, Any, Contains)
        var number = new List<int> { 1, 5, 6, 2, 9, 7, 4, 8, 10, 11, 12, };
        //var result = number.All(x => x > 0);
        //var result = number.Any(x => x < 0);
        var result = number.Contains(10);
        Console.WriteLine(result);



        //Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
        var num = new int[] { 1,2,3,4, 5, 6,7,8,9,10 };
        // var result2 = num.Skip(4).Take(6);
        //var result2 = num.SkipWhile(x => x  < 7);
        //تقسم اللست الى مجموعات من رقمين
        var result2 = num.Chunk(2);
        foreach (var C in result2)
        {
           foreach(var C2 in C)
            {


                Console.WriteLine(C2);
            }
           Console.WriteLine("-----------");
        }

    }


}


