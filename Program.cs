class Insha
{
    int a, b,c;

    void getNum()

    {
        //In  order to get input from user we can 
        //assist with this method 
        Console.WriteLine("Enter The 1st Number:");
        //Console.ReadLine String accept krta hai or humein 
        //isko int ki form mein accept krwana hai. That's why 
//We're using Convert.ToInt32 

        a = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Enter The 2nd Number:");
        b = Convert.ToInt32 (Console.ReadLine());
    }
    void Add()

    {
        c = a + b;
        Console.WriteLine(c);

    }
    void Sub()
    {
        c = a - b;
        Console.WriteLine(c);
    }
    void Multi()

    {
        c = a * b;
        Console.WriteLine(c);

    }
    void Div()
    {
        c = a / b;
        Console.WriteLine(c);
    }

    static void Main()
    {

        //its the syntax to create an object in C#
        Insha obj= new Insha();
        obj.getNum();
        //obj.Add();
        //obj.Sub();
    }


}

