namespace test1.extend
{
    public abstract class Parent
    {
        // private string myId;

        // public Parent(string myId)
        // {
        //     this.myId = myId;
        // }
        string myId;
        public Parent(string myId)
        {

        }

        //光标放在属性右边 花+. 生成属性构造器
        //public string MyId { get => myId; set => myId = value; }
		public string MyId
		{
			get
			{
				return myId;
			}

			set
			{
				myId = value;
			}
		}

        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return myId + "面积为："+ string.Format("{0:F2}",Area);
        }
    }
}