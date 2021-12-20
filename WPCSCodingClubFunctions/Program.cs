public class Program
{
    public static void Main(string[] args)
    {
        //Solution for using functions (methods) to clean up repeat code
        Console.WriteLine("1. Add \n" +
            "2. Subtract");
        int selection = GetNumber();

        if (selection == 1)
        {
            //A Function call is always denoted by a set of () parentheses
            int a = GetNumber();
            int b = GetNumber();
            int solution = a + b;
            Console.WriteLine(solution);
        }

        //Object creation. The "new" keyword is what gives it away
        Cadet newCadet = new Cadet("Joe", "C/Capt", null, 123456, "Cadet Commander");
        //You can directly access a member variable if it is public
        Console.WriteLine(newCadet.name);
        //Or if it is private, you need to use an accessor function (getters and setters)
        Console.WriteLine(newCadet.getRank());

        Circle circle = new Circle();
        double area = circle.Area();
        Console.WriteLine(area);

        //Arrays are collections of common things. Remember we start counting from 0 in programming!
        string[] array = new string[] {"a", "b", "c"};
        string choice = array[0];
        Console.WriteLine(choice);
        }

    //A simple function to get and convert a number from the console
    public static int GetNumber()
    {
        string temp = Console.ReadLine();
        int result = int.Parse(temp);
        return result;
    }

    //This function doesnt work becasue it has the same name!
    //public static double GetNumber()
    //{
    //    string temp = Console.ReadLine();
    //    double result = double.Parse(temp);
    //    return result;
    //}
}

//A sample class. Remember that a class object has 3 parts: member vairables, constructors, and functions
//i.e. What you want it to hold, how to build it, and what it should do
public class Cadet
{
    //Pay attention to public vs private
    public string name;
    private string rank;
    private string[] ribbons;
    private int capid;
    private string staffPosition;

    //A setter and getter for a private field. If you dont have a getter for a private field, you won't be able to see the data
    public void setRank(string newRank)
    {
        this.rank = newRank;
    }

    public string getRank()
    {
        return this.rank;
    }

    //Constructors. Remember Polymorphism - the constructors have the same name and it knows which one to choose based on the number of inputs
    public Cadet()
    {

    }

    public Cadet(string name, string rank, int capid)
    {
        this.name = name;
        this.rank = rank;
        this.capid = capid;
    }

    public Cadet(string name, string rank, string[] ribbons, int capid, string staffPosition)
    {
        this.name =name;
        this.rank = rank;
    }
}