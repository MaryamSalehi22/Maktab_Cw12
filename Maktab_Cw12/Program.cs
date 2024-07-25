namespace Maktab_Cw12
{
    internal class Program
    {
        delegate int del(int x, int y);
        static void Main(string[] args)
        {
            var studentQueue = new MyQueue<IStudent>();
            var queue = new MyQueue<Student>();
            //var stringQueue = new MyQueue<string>();
            //var ienumerableQueue = new MyQueue<IEnumerable<int>>();
            studentQueue.EnQueue(new Student("Maryam", "Salehi"));
            studentQueue.EnQueue(new Student("Pedram", "Soltani"));
            studentQueue.EnQueue(new Student("Hassan", "Askari"));
            studentQueue.EnQueue(new Student("Parniya", "Minae"));
            studentQueue.EnQueue(new Student("Milad", "Nazari"));
            Func<int, int, int> func = Minus;
            del myDelegate = Minus;
            Console.WriteLine(func(10 , 20));

        }
        public static int Multiple(int x , int y)
        {
            Console.WriteLine(x * y);
            return x * y;
        }
        public static int Minus(int x , int y)
        {
            Console.WriteLine(y - x);
            return y - x;
        }
        public static int Add(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }
    }
}
