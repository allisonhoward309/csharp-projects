using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }


        public override string ToString()
        {
            return "Course: {Topic}, Teacher: {Instructor}";
        }

        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != GetType())
            {
                return false;
            }

            Course theCourse = toBeCompared as Course;
            return theCourse.Instructor == Instructor && theCourse.Topic == Topic;
        }


    }
}
