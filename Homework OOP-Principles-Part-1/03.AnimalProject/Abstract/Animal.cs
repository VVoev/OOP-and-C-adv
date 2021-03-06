﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1._03.AnimalProject.Abstract
{
    public abstract class Animal : ISound,IEnumerable
    {
        //fields 
        private int age;
        private string name;
        private Sex sex;

        //properties
        public int Age { get { return this.age; } set { this.age = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public Sex Sex { get { return this.sex; } set { this.sex = value; } }

        //Constructor
        public Animal(int age,string name,Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public abstract string Sound();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
