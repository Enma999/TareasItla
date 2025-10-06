// See https://aka.ms/new-console-template for more information
using MyHema;
using MyHema.Entities;

Console.WriteLine("Hello, World!");

var obj1 = new CommunityMember();
obj1.Id = 1;
obj1.Name = "John";
obj1.LastName = "Doe";
obj1.Age = 30;
obj1.Role = "Teacher";
obj1.Email = "johndoe@gmail.com";
obj1.Phone = 1234567890;
obj1.Address = "123 Main St, City, Country";
obj1.MemberId = 1001;
obj1.MemberAge = 5;

Console.WriteLine($"Name: {obj1.Name} {obj1.LastName}, Age: {obj1.Age}, Role: {obj1.Role}, Email: {obj1.Email}, Phone: {obj1.Phone}, Address: {obj1.Address}, Member ID: {obj1.MemberId}, Member Age: {obj1.MemberAge}");

var obj2 = new Employee();
obj2.Id = 1;
obj2.Name = "Jane";
obj2.LastName = "Smith";
obj2.EmployeeAge = 28;  
obj2.Position = "Administrator";

Console.WriteLine($"Employee: {obj2.Name} {obj2.LastName}, Age: {obj2.EmployeeAge}, Position: {obj2.Position}");

var obj3 = new Teacher();
obj3.TeacherId = 1;
obj3.Name = "Alice";
obj3.LastName = "Johnson";
obj3.TeacherAge = 35;
obj3.Subject = "Mathematics";

Console.WriteLine($"Teacher: {obj3.Name} {obj3.LastName}, Age: {obj3.TeacherAge}, Subject: {obj3.Subject}");

var obj4 = new Administrator();
obj4.AdminId = 1;
obj4.Name = "Bob";
obj4.LastName = "Brown";
obj4.AdminAge = 40;
obj4.Role = "Principal";
obj4.AdminDepartment = "Administration";

Console.WriteLine($"Administrator: {obj4.Name} {obj4.LastName}, Age: {obj4.AdminAge}, Role: {obj4.Role}, Department: {obj4.AdminDepartment}");

var obj5 = new Student();
obj5.StudentId = 1;
obj5.Name = "Charlie";
obj5.LastName = "Davis"; 
obj5.StudentAge = 20;
obj5.Major = "Computer Science";

Console.WriteLine($"Student: {obj5.Name} {obj5.LastName}, Age: {obj5.StudentAge}, Major: {obj5.Major}");

var obj6 = new ExStudent();
obj6.ExStudentId = 1;
obj6.Name = "Eve";
obj6.LastName = "Wilson";
obj6.ExStudentAge = 22;
obj6.GraduationYear = 2022;
Console.WriteLine($"Ex-Student: {obj6.Name} {obj6.LastName}, Age: {obj6.ExStudentAge}, Graduation Year: {obj6.GraduationYear}");

var obj7 = new Student();
obj7.StudentId = 2;
obj7.Name = "Frank";
obj7.LastName = "Miller";
obj7.StudentAge = 21;
obj7.Major = "Biology";

Console.WriteLine($"Student: {obj7.Name} {obj7.LastName}, Age: {obj7.StudentAge}, Major: {obj7.Major}");

var obj8 = new ExStudent();
obj8.ExStudentId = 2;
obj8.Name = "Grace";
obj8.LastName = "Taylor";
obj8.ExStudentAge = 23;
obj8.GraduationYear = 2021;

Console.WriteLine($"Ex-Student: {obj8.Name} {obj8.LastName}, Age: {obj8.ExStudentAge}, Graduation Year: {obj8.GraduationYear}");

var obj9 = new CommunityMember();
obj9.Id = 2;
obj9.Name = "Hank";
obj9.LastName = "Anderson";
obj9.Age = 45;
obj9.Role = "Volunteer";
obj9.Email = "hankanderson@gmail.com";
obj9.Phone = 987654321;
obj9.Address = "456 Another St, City, Country";
obj9.MemberId = 1002;
obj9.MemberAge = 10;

Console.WriteLine($"Name: {obj9.Name} {obj9.LastName}, Age: {obj9.Age}, Role: {obj9.Role}, Email: {obj9.Email}, Phone: {obj9.Phone}, Address: {obj9.Address}, Member ID: {obj9.MemberId}, Member Age: {obj9.MemberAge}");

Console.ReadKey();