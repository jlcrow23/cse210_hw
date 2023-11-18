using System;

namespace Week_3
{
    public class Person
        {
            private string _title;
            private string _firstName;
            private string _lastName;

            public string GetInformalSignature()
            {
                return "Thanks, " + _firstName;
            }

            public string GetFormalSignature()
            {
                return "Sincerely, " + GetFullName();
            }
            private string GetFullName()
            {
                return _title + " " + _firstName + " " + _lastName;
            }

            public string GetFirstName()
            {
                return _firstName;
            }

            public void SetFirstName(string firstName)
            {
                _firstName = firstName;
            }

            public Person() // default name for any person created without information
            {
                _title = "";
                _firstName = "Anonymous";
                _lastName = "Unknown";
            }

            public Person(string first, string last) // values for first and last names (no title)
            {
                _title = "";
                _firstName = first;
                _lastName = last;
            }

            public Person(string title, string first, string last) // values for title, first, and last name
            {
                _title = title;
                _firstName = first;
                _lastName = last;
            }
        }
}