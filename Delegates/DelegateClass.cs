namespace Delegates;

public class DelegateClass
{

    public delegate void DelegateClassDelegate();
    DelegateClassDelegate delegateClassDelegate;
    delegate void MeDelegate(int x, int y);
   

    public DelegateClass()
    {
        DelegateClassDelegate asd = new DelegateClassDelegate(firstMethod);

        MeDelegate meDelegate = new MeDelegate((int x, int y) => { });
        meDelegate(2,3);
        delegateClassDelegate = firstMethod;
        delegateClassDelegate += secondMethod;
    }

    public void AddDelegate(DelegateClassDelegate method)
    {
        delegateClassDelegate = method;
    }

    public void CallDelegate()
    {
        delegateClassDelegate += () => { };
    }

    private void firstMethod()
    {
        Console.WriteLine("1");
    }

    private void secondMethod()
    {
        Console.WriteLine("2");
    }
}
