using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public class Dependency
        {
            public void DoSomething()
            {
                Console.WriteLine("Did something");
            }

            public void DoSomethingElse()
            {
                Console.WriteLine("Did something else");
            }
        }

        public class Consumer
        {
            private Dependency d;

            public Consumer(Dependency d)
            {
                this.d = d;
            }
            public void DoSomething()
            {
                var d = new Dependency();
                d.DoSomething();
            }

            public void DoSomethingElse()
            {
                var d = new Dependency();
                d.DoSomethingElse();
            }
        }

        public class Dependency1
        {
            public void DoSomething()
            {
                Console.WriteLine("Did something");
            }
        }

        public class Dependency2
        {
            public void DoSomethingElse()
            {
                Console.WriteLine("Did something else");
            }
        }

        public class Consumer2
        {
            public void DoSomething(Dependency1 d)
            {
                //var d = new Dependency1();
                d.DoSomething();
            }

            public void DoSomethingElse(Dependency2 d)
            {
               // var d = new Dependency2();
                d.DoSomethingElse();
            }
        }

        public interface TheirInterface
        {
            List<int> GetNums();
        }

        public interface MyInterface
        {
            IEnumerable<int> GetNums();
        }

        public class MyClass : MyInterface
        {
            public IEnumerable<int> GetNums()
            {
                throw new NotImplementedException();
            }
        }

        // using class adapter
        
        public class MyClassAdapter : MyClass, TheirInterface {
            List<int> TheirInterface.GetNums()
            {
                return GetNums().ToList();
            }
        }

    

            // using object adapter
        public class MyClassAdapter2 : TheirInterface

        {

            private MyClass mc;

            public MyClassAdapter2(MyClass mc)
            {
                this.mc = mc;
            }
            public List<int> GetNums()
            {
                return mc.GetNums().ToList();
            }
        }


    }
}
