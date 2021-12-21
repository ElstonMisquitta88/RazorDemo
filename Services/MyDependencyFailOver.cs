public class MyDependencyFailOver : IMyDependency
{
    public string WriteMessage(string message)
    {
        return "This is a Message from MyDependency Class FailOver "+ message;
    }
}