using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    public class SingletonHelloWorld
    {
        private static SingletonHelloWorld instance;

        private SingletonHelloWorld() { }

        public static SingletonHelloWorld GetInstance()
        {
            if(instance == null)
            {
                instance = new SingletonHelloWorld();

            }

            return instance;
        }
    }
}
