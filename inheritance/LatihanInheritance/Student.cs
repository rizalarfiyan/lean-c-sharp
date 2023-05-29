class Student : Person
{
    public string StudentId { get; set; }
    public string Email { get; set; }

    public Student(string name, int age, string studentId, string email) : base(name, age)
    {
        this.StudentId = studentId;
        this.Email = email;
    }
}