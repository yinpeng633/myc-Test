namespace test1.structtest
{
    //参考 https://msdn.microsoft.com/zh-cn/library/aa288471(v=vs.71).aspx
    public class StructTest
    {
        // static void Main(string[] args)
        // {
        //     // SimpleStruct ss = new SimpleStruct();
        //     // ss.X = 100;
        //     // System.Console.WriteLine("结构体里的值为：{0}", ss.X);

        //     // //还是和类一样啊
        //     // SimpleStruct ss1 = new SimpleStruct();
        //     // System.Console.WriteLine("看看结构体的值有没有被修改？结构体里的值为：{0}", ss1.X);



        //     SimpleStruct ss2 = new SimpleStruct();
        //     ss2.X = 1;

        //     SimpleClass ss3 = new SimpleClass();
        //     ss3.X = 1;

        //     processStruct(ss2);
        //     processClass(ss3);

        //     //结构体的值为何没有被修改？？？本示例的输出表明：当向 classtaker 方法传递类实例时，只更改了类字段的值。但是向 structtaker 方法传递结构实例并不更改结构字段。这是因为向 structtaker 方法传递的是结构的副本，而向 classtaker 方法传递的是对类的引用。
        //     System.Console.WriteLine("看看结构体的值process后有没有被修改？结构体里的值为：{0}", ss2.X); //1

        //     System.Console.WriteLine("看看类的值process后有没有被修改？结构体里的值为：{0}", ss3.X); //500 ?
        // }

        public static void processStruct(SimpleStruct s)
        {
            s.X = 500;
        }

        public static void processClass(SimpleClass c)
        {
            c.X = 500;
        }
    }

    //相同点：结构体和类差不多，一个属性、一个方法和一个私有字段
    //不同点：首先，类为引用类型，而结构为值类型。在类上调用“新建”(New) 运算符时，它将在堆上进行分配。但是，当实例化结构时，将在堆栈上创建结构。这样将产生性能增益。而且，您不会像对待类那样处理对结构实例的引用。您将直接对结构实例进行操作。鉴于此原因，向方法传递结构时，结构将通过值传递，而不是作为引用传递。
    public struct SimpleStruct
    {
        private int xval;
        public int X
        {
            get
            {
                return xval;
            }

            set
            {
                xval = value;
            }
        }
    }

    public class SimpleClass
    {
        private int xval;
        public int X
        {
            get
            {
                return xval;
            }

            set
            {
                xval = value;
            }
        }
    }
}