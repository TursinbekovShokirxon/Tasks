﻿namespace ADO.NET_LESSON_1.Lesson1.Project.Models
{
    public class Customer:People
    {
        public override string ToString()
        {
            return $"ID - {Id} \nFirstname - {base.FirstName}\nLastName - {base.LastName}\nAge - {base.Age}\nEmail - {base.Email}";
        }
    }
}
