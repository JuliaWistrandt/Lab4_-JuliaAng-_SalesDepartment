namespace CEO_Manager_Accountant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> salesDepartment = new List<string>();
            //add the elements in the list
            salesDepartment.Add(new Manager().GetPosition());
            salesDepartment.Add(new CEO().GetPosition());
            salesDepartment.Add(new Accountant().GetPosition());

            //show positions
            Console.WriteLine("Sales Department:");
            foreach (var i in salesDepartment)
            {
                Console.WriteLine(i);
            }

        }
    }
}