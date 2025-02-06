public class WritingAssignmnt : Assignment {
    private string _title;

    public WritingAssignmnt(string studentName, string topic, string title) : base (studentName, topic) {
        _title = title;
    }
    public string GetWritingInformation() {
        string StudentName = GetStudentName();
        return $"{_title} by {StudentName}";
    }
}