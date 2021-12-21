public class MyDependency : IMyDependency
{
    public string WriteMessage(string message)
    {
        return "This is a Message from MyDependency Class 1 "+ message;
    }
}