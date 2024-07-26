// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class A
{
    int x = 69;
    
    
  //  static void Main(string[] args)
   // {
  //      A a = new A();
//        Console.WriteLine(a.x);
 //   }
    
}

public class B : A
{

    int y = 1;
    static void Main(string[] args)
    {
        B b = new B();
        A bruh = new B();

        Console.WriteLine(bruh);
        Console.WriteLine(b.y);
    }

}
