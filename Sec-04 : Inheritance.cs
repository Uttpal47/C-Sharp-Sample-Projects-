using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//InterFace-1
/*public interface ISeri
{
    int getNext();
    int getNext2();
    void Reset();
    void SetStart(int x);
}
//Interface implement
class kudos: ISeri
{
    int s;
    int val;

    public kudos()
    {
        s = 2;
        val = 2;
    }
    public int getNext()
    {
        val += 10;
        return val;
    }
    public int getNext2()
    {
        val += 5;
        return val;
    }

    public void Reset()
    {
        val = s;
    }

    public void SetStart(int x)
    {
        s = x;
        val = s;
    }

}
class Program
{
    public static void Main(string[] args)
    {
        kudos ob = new kudos();
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Next Value : { ob.getNext()}");
        }
        Console.WriteLine("\nReSet...");
        ob.Reset();
        //After Reset, depends on s value....
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Next Value : { ob.getNext2()}");
        }

        Console.WriteLine("\n....Starting From A defined val....");
        ob.SetStart(50);
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Next Value : { ob.getNext()}");
            Console.WriteLine($"Next Value : { ob.getNext2()}");
        }
    }
}

//Inter-2
public interface Ip
{
    void scan();
}
public interface Is
{
    void print();
}

class MultiFunc : Ip, Is
{
    public void print()
    {
        Console.WriteLine("Printing....");
    }
    public void scan()
    {
        Console.WriteLine("Scanning....");
    }
    public void dope()
    {
        Console.WriteLine("Not included in interfaces");
    }

}
class Program
{
    public static void Main(string[] args)
    {
        MultiFunc m = new MultiFunc();
        Console.WriteLine("Prog Initialized\n");
        m.scan();
        m.print();
        m.dope();
        Console.WriteLine("\nProg Ended");

    }
}

// InterFace - 3

public interface Ip
{
    void Method1();
    //void scan();
}
public interface Is : Ip
{
    void Method7();
    //void print();
}

class Myclass : Is
{
    public void Method1()
    {
        Console.WriteLine("Implement 1");
    }
    public void Method7()
    {
        Console.WriteLine("Implement 7");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Myclass m = new Myclass();
        Is ist = m;
       
        Console.WriteLine("Prog Initialized\n");
        ist.Method1();
        ist.Method7();
        //m.scan();
        //m.print();
        Console.WriteLine("\nProg Ended");

    }
}*/


// Interface-4
interface Ip
{
    //void Method1();
    void scan();
}
interface Is
{
    //void Method7();
    void print();
}

class MultiFunc : Ip, Is
{
    void Is.print()
    {
        Console.WriteLine("Printing....");
    }
    void Ip.scan()
    {
        Console.WriteLine("Scanning....");
    }
    public void dope()
    {
        Console.WriteLine("Not included in interfaces");
    }

}

class Program
{
    public static void Main(string[] args)
    {
        MultiFunc m = new MultiFunc();
       
        Console.WriteLine("Prog Initialized\n");
        //m.print();  ///Error -> which process to call

        Is s = m;
        s.print();
        Ip p = m;
        p.scan();
        Console.WriteLine("\nProg Ended");

    }
}
