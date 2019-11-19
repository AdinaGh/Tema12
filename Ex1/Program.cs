using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
     public enum Faculty { Informatica, Matematica, Sport,Psihologie, Economie };
     public enum Specialty { Calculatoare, Automatica, FinanteSiBanci,Management, Matematica };
     public enum University { AlexandruIoanCuza, Politehnica };
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mihai", "Andrei", "Ionescu", 2871001, "Iasi", 0744566766, "Mihai.Andrei.Ionescu@gmail.com", "Mathemathics", Specialty.Matematica, Faculty.Matematica, University.AlexandruIoanCuza);
            Student s2 = new Student("Mirel", "Anton", "Popescu", 2871002, "Iasi", 0744579966, "Mirel.Anton.Popescu@gmail.com", "Informatics", Specialty.Calculatoare, Faculty.Informatica, University.Politehnica);
            Student s3 = new Student("Mihai", "Andrei", "Ionescu", 2871001, "Iasi", 0744566766, "Mihai.Andrei.Ionescu@gmail.com", "Mathemathics", Specialty.Matematica, Faculty.Matematica, University.AlexandruIoanCuza);
            if (s1 == s3)
                Console.WriteLine("Acelasi student");
            else
                Console.WriteLine("Studenti diferiti");
            Console.WriteLine(s1!=s2);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s1.CompareTo(s2));
            var s4 = (Student)s2.Clone();
            Console.WriteLine(s2.CompareTo(s4));
            Console.WriteLine(s1.CompareTo(s2));
            var mihaela = new Person("Mihaela Gabor", 54);
            var ionut = new Person("Ionut Vasile");
            var ex = mihaela.IsValid();
            if(!ex.valid)
                Console.WriteLine(ex.error);

            Console.WriteLine("{0}\n{1}", mihaela, ionut);
        }
    }
}
