class MiExcepcion:Exception
{
    public MiExcepcion(string message): base(message)//
    {

    }
    public MiExcepcion():this("Error")//
    {

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        try 
        {
                throw new NotImplementedException("Error");
        }
        catch(MiExcepcion e)
        {
            Console.WriteLine(e.Message);
        }
        

    }
}