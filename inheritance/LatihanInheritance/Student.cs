class Student : Person
{
    public string StudentId { get; set; }
    public string Email { get; set; }

    public Student(string name, int age, string studentId, string email) : Person(name, age)
    {
        this.StudentId = studentId;
        this.Email = email;
    }
}