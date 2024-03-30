using System.Text;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region hour
            //Console.WriteLine("Enter hour");
            //int hour=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter minute");
            //int minute = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second");
            //int second = int.Parse(Console.ReadLine());
            //Console.Clear();
            //string a = "Salam";
            // bool b = false;

            //while(true)
            //{
            //    Console.Clear() ;
            //    Console.WriteLine($"{hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}");
            //    second++;
            //    if (second > 59)
            //    {
            //        second = 0;
            //        minute++;
            //    }
            //    if(minute > 59)
            //    {
            //        minute = 0;
            //        hour++;
            //    }
            //   Thread.Sleep(1000);

            //}
            //int name = 9;
            //Console.WriteLine(sizeof(int));
            #endregion
            #region is
            //object at = 5;
            //if (at is string n)
            //{

            //    Console.WriteLine(n);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            #endregion
            #region Single Type Pattern
            //object obj = new MyClass();
            //switch (obj)
            //{
            //    case MyClass myClass :
            //        Console.WriteLine(myClass.Name);
            //        Console.WriteLine(7889709);
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            #region try-catch

            try
            {
                int a = 0, b = 11;
                int c = b / a;
                int dd = int.Parse("askdkmnasd");
                Console.WriteLine(dd);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Number or digit can't divide by zero!!!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("the 'askdkmnasd' can't parse to int!!!  ");
            }
            finally
            {
                Console.WriteLine("Proccess done:)");
            }
            #endregion

            #region Dictionary

            //var map = new Dictionary<int,string>();
            //map[22] = "Salam";
            //map[12] = "Salam2";
            //map[32] = "Salam3";
            //map[52] = "Salam4";
            //map[62] = "Salam5";



            ////  Console.WriteLine(map[22]);

            //foreach (var item in map)
            //{
            //    Console.WriteLine(item);
            //}
            //if(map.ContainsKey(22)) {
            //    Console.WriteLine("22 acari var");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 0; i < map.Count; i++)
            //{
            //    Console.Write(map.ElementAt(i).Key+"=>");
            //    Console.WriteLine(map.ElementAt(i).Value);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //if(map.TryGetValue(112, out string value))
            //{
            //    Console.WriteLine(value);
            //}
            #endregion
            #region Array CreateInstance

            //string[] arr = new string[4]{ "Salam", "Salam2", "Salam3", "Salam4", };

            //Array arr2=Array.CreateInstance(typeof(string),4);


            //arr[2] ="Insanliq";
            //foreach(string i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (string i in arr2)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion
            #region System.Index( ^ ->Circumflex )
            //string[] names = new string[5] { "Atilla", "Movlud", "Isgender", "Ramazan", "Cesur" };
            //Index i = 3;//Ramazan
            //Index ii = ^4;//Movlud
            //Console.WriteLine(names[i]);
            //Console.WriteLine(names[ii]);
            #endregion
            #region System.Range(..)

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //Range r = 3..5;//4,5 -->0 yox 1-den bashlayir(soldan saga) ve 5-ci element daxildir!
            //Range r2 = 3..^2;//4,5,6 -->0 yox 1-den bashlayir(sagdan sola) ve ^2-ci element daxil deyil!!!
            //Range r3 = ^3..^2;//6,7 -->0 yox 1-den bashlayir(sagdan sola,her ikisi) ve hem ^3, hem de ^2-ci element daxildir!!!
            //Range r4 = ..;//arrayin butun elementlerini kopyalayir
            //int[] nums2 = nums[r];
            //int[] nums3 = nums[r2];
            //foreach (int x in nums2)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();
            //foreach (int x in nums3)
            //{
            //    Console.Write(x + " ");
            //}

            #endregion

            #region Lists

            //var newList=new List<string>();
            //newList.Add("Salam");
            //newList.Add(" Olsun");
            //newList.Add(" Insanlara");

            //foreach (var item in newList)
            //{
            //    Console.Write(item);
            //}


            #endregion

            #region Record
            //MyRecord myRecord= new MyRecord()
            //{
            //    MyProperty = "Salam",
            //    Price=19.46D
            //};
            //MyRecord myRecord2 = new()
            //{
            //    MyProperty = myRecord.MyProperty,   ve  -->  var myRecord2=myRecord with { Price=12.99 } ;--> bu eyni sheydir!!!
            //    Price = 12.99
            //};

            #endregion

            #region Garbage Collector
            //Something();
            //GC.Collect();

            #endregion

            #region Files

            // string path = "C:\\Users\\MSI\\OneDrive\\Desktop\\Programming\\C#\\Programming Info\\Text.txt";
            // FileStream fileStream= new(path,FileMode.Append);
            // byte[] buffer = Encoding.Default.GetBytes("Insanliq yashayir!!!");

            // fileStream.Write(buffer, 0, buffer.Length);
            //fileStream.Close();




            #endregion

            #region Exception

            //int a = 20;
            //int b = 0;
            //Console.WriteLine($"a:{a}");
            //Console.WriteLine($"b:{b}");
            //int c = a / b;
            //Console.WriteLine($"c:{c}");

            #endregion
        }
        static void Something() {
            MyClass a = new();
        }

    }
    class MyClass
    {
       
        public string Name { get; set; }


        ~MyClass() {

            Console.WriteLine("Yox edilir...");
           
        }
    }
    record MyRecord
    {
        public string MyProperty { get; init; }
        public double Price { get; init; }
    }
}
