class Teacher : Person
{
    public string TeacherId { get; set; }
    public string Subject { get; set; }

    public Teacher(string name, int age, string teacherId, string subject): base(name, age)
    {
        this.TeacherId = teacherId;
        this.Subject = subject;
    }
}