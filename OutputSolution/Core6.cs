//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OutputSolution
//{
//    class MyClass
//    {
//        char chrs = 'A';
//        public IEnumerator GetEnumerator()
//        {
//            for (int i = 20; i >= 0; --i)
//                if (i == 10) yield break;
//            yield return (char)((chrs + i));
//        }
//    }
//    class Core6
//    {
//        static void Main(string[] args)
//        {
//            MyClass mc = new MyClass();
//            foreach (char ch in mc)
//                Console.Write(ch + " ");
//            Console.WriteLine();
//            Console.ReadLine();
//        }
//    }
//}
