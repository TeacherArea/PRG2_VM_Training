using System;
using System.Collections.Generic;
using System.Text;

namespace VM_Training.Model
{
    abstract class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
    internal class Student : Person
    {
        private char _grade;
        public Student (string name, int age) : base(name, age)
        {
        }

        public char Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                this._grade = value;
            }
        }
    }
}