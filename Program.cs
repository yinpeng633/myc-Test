using System;

namespace test1
{
    class Program
    {


        private String name = "dapeng";

        private int age = 18;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // public abstract string AbsName
        // {
        //     get;
        // }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return Name + "---" + Age;
        }
        static String dd = "大棚";
        static String[] ddArray = { "大胖", "大棚1", "大鹏" };

        static String[] testArray;

        // static void Main(string[] args)
        // {
        //     if (dd.Equals("大棚"))
        //     {
        //         Console.WriteLine(dd);


        //         // Console.WriteLine("{0} is {1}", "dddadadc", "stupiddd!");

        //         // Console.WriteLine("dddadadc" + "dadadzvzvara {0}", dd);

        //         // //foreach 循环
        //         // foreach (string item in ddArray)
        //         // {
        //         //     Console.WriteLine(item);
        //         // }
        //         Program p = new Program();

        //         p.Age = 56;

        //         p.age = 67;

        //         Console.WriteLine(p.ToString() + p.Age);


        //     }
        // }
    }
}
