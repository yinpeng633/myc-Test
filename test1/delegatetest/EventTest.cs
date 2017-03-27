using System;

namespace test1
{
    public class EventTest
    {
        static void Main(string[] args)
        {
            ChangedDataClass data = new ChangedDataClass();
            data.changed += new changedEventHandler(afterEventHandler);
            data.add(5);
            data.remove(7);
        }

        //观察者观察到事件发生后所做的处理
        static void afterEventHandler(int changedValue)
        {
            Console.WriteLine("值已经改变了{0}", changedValue);
        }
    }

    //微软的规范 委托的名字必须以EventHandler结尾，而事件名字是委托的名字去掉EventHandler
    //我个人理解 委托就是java里 listener.onchanged(Event e); 的方法“onchanged(Event e)”。
    //而事件就是listener。
    public delegate void changedEventHandler(int changedValues);

    public class ChangedDataClass
    {

        public event changedEventHandler changed;//事件的声明
        private int someValue;

        public void add(int v)
        {
            someValue += v;
            if(changed != null)
            {
                changed(someValue);  
            }
        }

        public void remove(int v)
        {
            someValue -= v;
            if(changed != null)
            {
                changed(someValue);
            }
        }
    }

    // public class CustomEventArgs : EventArgs
    // {

    // }
}