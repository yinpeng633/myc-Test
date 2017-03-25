namespace test1.virtualtest
{
    // c#虚方法相关 虚方法究竟有什么用，允许子类修改父类的方法？
    public class Virtualtest
    {
        // static void Main(string[] args)
        // {
        //     Child p = new Child();
        //     Parent pc = (Parent)p; //强转成父类？？？
        //     System.Console.WriteLine(pc.p1()); //c1
        //     System.Console.WriteLine(pc.p2()); //p2
        //     System.Console.WriteLine(pc.p3()); //p3
        // }
    }


    public class Parent
    {
        public virtual string p1()
        {
            return "p1";
        }
        public virtual string p2()
        {
            return "p2";
        }
        public virtual string p3()
        {
            return "p3";
        }
    }

    public class Child : Parent
    {
        public override string p1()
        {
            // base.p1; //这里同super
            return "c1";
        }

        public new string p2()
        {
            return "c2";
        }

        public string p3()
        {
            return "c3";
        }
    }


}