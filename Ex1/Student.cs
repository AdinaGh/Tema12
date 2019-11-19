using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Ex1
{
    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string name, string middlename, string lastname, int ssn, string address, int telephonenumber, string email, string course, Specialty specialty, Faculty faculty, University university)// : base(name, age: null)
        {
            this.Name = name;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.Ssn = ssn;
            this.Address = address;
            this.TelephoneNumber = telephonenumber;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string Name { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int Ssn { get; private set; }
        public string Address { get; private set; }
        public int TelephoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Course { get; private set; }
        public Specialty Specialty { get; private set; }
        public Faculty Faculty { get; private set; }
        public University University { get; private set; }

        public object Clone()
        {
            return new Student(this.Name, this.MiddleName, this.LastName, this.Ssn, this.Address, this.TelephoneNumber, this.Email, this.Course, this.Specialty, this.Faculty, this.University);
        }

        public override bool Equals(object param)
        {
            var student = param as Student;
            if (student == null)
                return false;
            if (!Equals(Name, student.Name))
                return false;
            if (!Equals(MiddleName, student.MiddleName))
                return false;
            if (!Equals(LastName, student.LastName))
                return false;
            if (!Equals(Ssn, student.Ssn))
                return false;
            if (!Equals(Address, student.Address))
                return false;
            if (!Equals(TelephoneNumber, student.TelephoneNumber))
                return false;
            if (!Equals(Email, student.Email))
                return false;
            if (!Equals(Course, student.Course))
                return false;
            if (!Equals(Specialty, student.Specialty))
                return false;
            if (!Equals(Faculty, student.Faculty))
                return false;
            if (!Equals(University, student.University))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Ssn.GetHashCode();
        }
        public override string ToString()
        {
            return $"Student: {Name}  {MiddleName} {LastName}  {Ssn}  {Address} {TelephoneNumber}  {Email}  {Course}  {Specialty}  {Faculty}  {University}";
        }
        public static bool operator ==(Student s1, Student s2)
        {
            if (s1 is null || s2 is null)
                return false;
            return s1.Equals(s2);
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }

        public int CompareTo(Student compstud)
        {
            if (Student.Equals(this, compstud))
                return 0;

            return Student.Equals(new Student[] { this, compstud }.OrderBy(student => student.Name).ThenBy(student => student.MiddleName).ThenBy(student => student.LastName).ThenBy(student => student.Ssn).First(), this) ? -1 : 1;
        }

        }
    }

        
    

