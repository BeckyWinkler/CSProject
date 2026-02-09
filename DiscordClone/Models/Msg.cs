public class Msg
{
    private static int _counter = 0;
    public int ID {get;}
    public string Content {get;set;}

    public Msg(string c)
    {
        _counter++;
        ID = _counter;
        Content = c;
    }
    public string toString()
    {
        return ID + " " + Content;
    }
}