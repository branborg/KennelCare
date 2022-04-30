using Kennel.Database.Implementations;

public class Program
{
    public static void Main(string [] Args)
    {
        using (var s = new KennelContext())
        {
            s.Database.EnsureCreated();
           
        }
    }
}