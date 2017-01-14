namespace TestApp.Action
{
    internal class Cat
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Cat(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}