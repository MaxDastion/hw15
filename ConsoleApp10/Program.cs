
interface InterfaceBiba<T>
{
    void MethodA(T obj);
}

interface InterfaceBoba<U>
{
    void MethodB(U obj);
}

class MyClass<T, U> : InterfaceBiba<T>, InterfaceBoba<U>
{
    public void MethodA(T obj)
    {
        Console.WriteLine( obj);
    }

    public void MethodB(U obj)
    {
        Console.WriteLine(obj);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass<int, string> myClass = new MyClass<int, string>();

        myClass.MethodA(10);

        myClass.MethodB("Биб и боб");
    }
}
