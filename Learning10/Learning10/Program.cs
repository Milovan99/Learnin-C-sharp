using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Collections;

using System.Data.SqlClient;

using System.Data;

using System.Diagnostics;



namespace Learning10

{
    class Wrapper //Wrapper Class

    {
        private class InnerClass //Inner Class

        {
            public Int32 ProcessData(int Val)

            {

                return Val + 1;

            }

        }

        public Int32 CallRapper()

        {
            Wrapper.InnerClass wpr = new Wrapper.InnerClass(); // Internally call to Wrapper class.
            return wpr.ProcessData(100);
        }

    }
    class Program

    {
        static void Main(string[] args)

        {
            Wrapper w = new Wrapper();
            Console.WriteLine("Data Process by inner class and show by Wrapper Class:" + w.CallRapper());
            Console.ReadLine();
        }
    }
}