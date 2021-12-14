using System;
using System.Collections.Generic;
using System.Text;

namespace MTDhruvRajpara
{
    public abstract class Person
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private String _name;


        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(int id, String name)
        {
            Id = id;
            Name = name;
        }


    }
}
