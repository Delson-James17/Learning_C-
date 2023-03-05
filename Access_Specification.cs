using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    class Stack //data structure
    {
        internal int a = 10; int b = 20;// if two calles are in same namespace then you can access the variables
                                        // protected int b = 20; // one class has to inherit from the other to access the variable
                                        //fields
        int[] values; //first 1,2,3,4,5,6 last
        int top = 0;

        //methods
        //constructors -- initialization of your variables 

        public Stack() : this(100) // default constructor
        {
            //values = new int[10];
        }
        public Stack(int size)  // parameterized constructor
        {
            values = new int[size];
        }
        //methods
        void push(int val)
        {
            values[top++] = val;
        }
        int pop()
        {
            return values[top--];
        }
        class Program
        {
            static public void Access_specification()
            {
                Stack stack = new Stack();//

                stack.push(1);
                stack.pop();
            }
        }
    }
}
