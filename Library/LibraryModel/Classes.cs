using System;
using System.Collections.Generic;

namespace LibraryModel
{
    public class Student
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NumberOfTicket { get; set; }
        public DateTime Vidacha { get; set; }
        public DateTime Sdacha { get; set; }

        //public override string ToString()
        //{
        //    string str = String.Format("{0,-20} \t{1,5:N1}", (Name + " " + Surname), NumberOfTicket) + $"\t{Vidacha.ToString("d")}    Выдано до {Sdacha.ToString("d")}";
        //    return str;
        //    //return $"{Name} {Surname} \t\t{Group} \t{Vidacha.ToString("d")}    Выдано до {Sdacha.ToString("d")}";
        //}
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Town { get; set; }
        public string Izdatelstvo { get; set; }
        public int YearOfPublic { get; set; }
        public string ISBN { get; set; }
        public int SumOfBooks { get; set; }
        public int CountOfStudent { get; set; }
        public List<Student> student { get; set; }
    }
}
