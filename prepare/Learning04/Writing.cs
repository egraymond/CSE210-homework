public class Writing : Assignment
{
    public string _title;

    public Writing(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = _studentName;
        return $"{_title} by: {studentName}";
    }
}