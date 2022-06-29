class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager(new BirinciMevzuat());
        customerManager.Add();
        Console.ReadLine();
    }
}

class CustomerManager
{
    private IMevzuat _mevzuat;

    public CustomerManager(IMevzuat mevzuat)
    {
        _mevzuat = mevzuat;
    }

    public void Add()
    {
        _mevzuat.IslemYap();
        // int mevzuat = 0
        // if birinci mevzuat=1 bla bla kod.
        // if ikinci mevzuat=2 bla bla kod.
        //eğer interface yapmasaydık kod uzayacaktı ve spagetti kod diye adlandırılan karışık bir kod olacaktı.
    }
}

interface IMevzuat
{
    void IslemYap();
}

class BirinciMevzuat : IMevzuat
{
    public void IslemYap()
    {
        Console.WriteLine("Birinci mevzuata göre eklendi.");
    }
}

class IkinciMevzuat : IMevzuat
{
    public void IslemYap()
    {
        Console.WriteLine("İkinci mevzuata göre eklendi.");
    }
}