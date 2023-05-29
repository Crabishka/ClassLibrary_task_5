namespace ClassLibrary
{
    public interface Paper
    {
        string data { get; set; }
        void append(string text);
        string readLine(int number);
    }
}