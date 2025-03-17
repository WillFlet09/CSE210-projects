class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string problems, string textbookSection, string studentName, string topic)
    :base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    } 

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
        
    }
}