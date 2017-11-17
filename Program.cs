using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tyler Skulley
//11/10/2017
//M3 Exercise 1
namespace university
{
    public class University
    {

        Departments[] departments = new Departments[4];
        static void Main(string[] args)
        {
            University u = new University();
            u.departments[1].Staff[1] = new Researcher("Ben");
            u.departments[1].Staff[0] = new Dean("John");
        }
        public class Departments
        {
            public String staffName;
            public Staff[] Staff = new Staff[10];
        }
        public class Math : Departments
        {
            Staff[] StaffM = new Staff[10];

        }
        public class English : Departments
        {
            Staff[] StaffE = new Staff[10];
        }
        public class Geography : Departments
        {
            Staff[] StaffG = new Staff[10];
        }
        public class ComputerScience : Departments
        {
            Staff[] StaffC = new Staff[10];
        }
        public class Staff
        {
            public String staffName;
            public double salary;
            public Staff(String staffName)
            {
                this.staffName = staffName;
            }
        }
        public enum ResearchSpecialty
        { WorldHistory, Calculus, Literature, DataProcessing }
        public interface ITeachable {

            void Teach();
        }
        public interface IAdmin
        {
            void Administrate();
        }
        public class Professor : Staff, ITeachable
        {
            public Professor(string staffName) : base(staffName)
            { }
            public void Teach()
            { Console.WriteLine("Teaching"); }
        }
        public class Dean : Staff, IAdmin, ITeachable
        {
            public Dean(string staffName) : base(staffName)
            { }

            public void Teach()
            {
                Console.WriteLine("Teaching");
            }
            public void Administrate()
            {
                Console.WriteLine("Administrate");
            }
        }
        public class Researcher : Staff, ITeachable
        {
            public Researcher(string staffName) : base(staffName)
            { }
            public ResearchSpecialty research;
            public void Teach()
            {
                Console.WriteLine("Teaching"); ;
            }

        }
    } }
