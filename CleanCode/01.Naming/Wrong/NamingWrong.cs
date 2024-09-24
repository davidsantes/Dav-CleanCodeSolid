namespace CleanCode._01.Naming.Wrong;

// ¿Te gustaría enfrentare a este código? el código compila correctamente.
public class P
{
    public int x;
    public int y;
}

public class A
{
    public List<P> Get()
    {
        List<P> l = new List<P>();
        P p1 = new P { x = 1, y = 2 };
        P p2 = new P { x = 3, y = 4 };
        l.Add(p1);
        l.Add(p2);
        return l;
    }
}

public class B
{
    public void Print(List<P> l)
    {
        foreach (var p in l)
        {
            Console.WriteLine($"x: {p.x}, y: {p.y}");
        }
    }
}

class Init
{
    static void Start()
    {
        A a = new A();
        List<P> l = a.Get();

        B b = new B();
        b.Print(l);
    }
}
