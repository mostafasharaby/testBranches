namespace Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> sqr = x => x * x;
            //Console.WriteLine(sqr(3));

            //Expression<Func<int, bool>> IsEven = x => x % 2 == 0;
            //ParameterExpression parameterExpression = IsEven.Parameters[0];
            //Console.WriteLine(parameterExpression.Name + " dd " + parameterExpression.Type);
            //BinaryExpression binaryExpression = (BinaryExpression)IsEven.Body;
            //Console.WriteLine(binaryExpression.Left);
            //Console.WriteLine(binaryExpression.Right);
            //Console.WriteLine(binaryExpression.NodeType);


            //var classroom = new Classroom();
            //Console.WriteLine(classroom[0]); // Output: Alice
            //classroom[0] = "David";
            //Console.WriteLine(classroom[0]);

        }
    }
    //public class Classroom
    //{
    //    private string[] students = { "Alice", "Bob", "Charlie" };

    //    public string this[int index]
    //    {
    //        get { return students[index]; }
    //        set { students[index] = value; }
    //    }
    //}
}
