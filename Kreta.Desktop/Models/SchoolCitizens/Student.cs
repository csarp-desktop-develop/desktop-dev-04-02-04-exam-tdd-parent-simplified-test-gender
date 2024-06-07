using Kreta.Desktop.Models;
using System;

namespace Kreta.Desktop.SchoolCitizens
{
    public class Student 
    {
        public Student(Guid id, string firstName, string lastName, DateTime birthsDay, bool isWooman, string placeOfBirth, int schoolYear, SchoolClassType schoolClass, string educationLevel)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthsDay;
            PlaceOfBirth = placeOfBirth;
            IsWoman = isWooman;
            Grade = schoolYear;
            SchoolClassType = schoolClass;
            EducationLevel = educationLevel;
        }

        public Student()
        {
            Id = Guid.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDay = new DateTime();
            PlaceOfBirth = string.Empty;
            IsWoman = false;
            Grade = 9;
            SchoolClassType = SchoolClassType.ClassA;
            EducationLevel = string.Empty;
            PlaceOfBirth = string.Empty;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }
        public bool IsWoman { get; set; }
        public int Grade { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
        public string EducationLevel { get; set; }
        public bool HasId => Id != Guid.Empty;
        public bool IsMan => !IsWoman;
        public string HungarianName => $"{LastName} {FirstName}";

        public void Set(Student student)
        {
            Id = student.Id;
            FirstName= student.FirstName;
            LastName= student.LastName;
            BirthDay= student.BirthDay;
            PlaceOfBirth = student.PlaceOfBirth;
            IsWoman = student.IsWoman;
            SchoolClassType= student.SchoolClassType;
            Grade = student.Grade;
            PlaceOfBirth= student.PlaceOfBirth;
        }
        public override string ToString()
        {
            string woman = IsWoman ? "nő" : "férfi";
            return $"{HungarianName} {woman} ({Grade}.{SchoolClassType}) - ({String.Format("{0:yyyy.MM.dd.}", BirthDay)}) ({EducationLevel})";
        }


    }
}
