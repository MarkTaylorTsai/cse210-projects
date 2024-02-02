public class WriteAssignment : Assignment
{
    private string title;

    public WriteAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        this.title = title;
    }

    public string GetWritingInformation()
    {
        return $"{title} by {GetSummary()}";
    }
}