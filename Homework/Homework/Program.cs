internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        string surname;
        string fullname = "Lorem Ipsum";

        string[] arr = fullname.Split(' ');
        {
            if (!String.IsNullOrEmpty(arr[0]))
            {
                name = arr[0];
                Console.WriteLine("name is" + arr[0]);
            }
            if (!String.IsNullOrEmpty(arr[1]))
                surname = arr[1];
            Console.WriteLine("surname is" +  arr[1]);
        }

    }
}