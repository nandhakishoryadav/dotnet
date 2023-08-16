using InheritanceSample3;

HighSchollStudents hss = new HighSchollStudents
{
    Name = "Akash",
    Address = "Mangalore",
    Age = 18,
    SchoolId = 100,
    ExtraCaricularActivities = "Dance",
    Gpa = 8,
    GradeLevel = "First"
};

CollegeStudents cs = new CollegeStudents
{
    Name = "Mathew",
    Address = "Mangalore",
    Age = 18,
    SchoolId = 102,
    Major = "ABCS",
    Minor = "Avsb",
    GradeLevel = "First"
};


HighSchoolTeacher hst = new HighSchoolTeacher
{
    Name = "Anu",
    Address = "Bangalore",
    Age = 25,
    EmployeeId = 2001,
    Department = "Science",
    SubjectTaught = "Physics",
};

CollegeProfessor cp = new CollegeProfessor
{
    Name = "Lakshmi",
    Address = "Bangalore",
    Age = 25,
    EmployeeId = 2002,
    Department = "CSE",
    Publications = "Image Detection",
    ReasearchAreas="AIML"
};

hss.SName();
hss.Contact();
hss.Grades();
hss.Enroll();
hss.Transcript();
hss.Letters();
Console.WriteLine();
cs.SName();
cs.Contact();
cs.Grades();
cs.Enroll();
cs.Exam();
cs.Graduation();
Console.WriteLine();
hst.Tname();
hst.Contact();
hst.VSchedule();
hst.EnterGrade();
hst.Lesson();
hst.Schedule();
Console.WriteLine();
cp.Tname();
cp.Contact();
cp.VSchedule();
cp.EnterGrade();
cp.Grants();
cp.Schedule();


