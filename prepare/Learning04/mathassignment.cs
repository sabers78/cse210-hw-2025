public class MathAssignment : Assignment
{
    private string _textboockSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textboockSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"SEction {_textboockSection} Problems: {_problems}";
    }

}