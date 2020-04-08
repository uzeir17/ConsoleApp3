using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello git!");
        }
    }
}
public class BaseShip 
{
    public BaseShip(int i)
    {
        Console.WriteLine("Вызван конструктор родительского класса.");
    }
    private int _counter;
   
    protected int _speed;
    public string Move(int distance)
    {
        _counter++;

        string result = string.Format("Пройдено километров: {0}", distance);
        return result;
    }
}
public class TransportShip : BaseShip
{
    public TransportShip()
        :base(0)
    {
        Console.WriteLine("Вызван конструктор дочернего класса.");
    }
    public void start()
    {

    }
}

