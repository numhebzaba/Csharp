using System;
using System.Collections.Generic;

namespace Class_start
{
    class Swordman
    {
        public int HP ;

        public int EXP ;

        public int Atk ;

        public int Level;

        public string status;

        public Swordman()
        {
            HP = 5000;
            EXP = 0;
            Atk = 20;
            Level = 1;
            status = "Alive";
        }

        public void Walk() {
            Console.WriteLine("Walk");
        }
        public void Sit()
        {
            Console.WriteLine("Sit");
        }
        public void Attack()
        {
            Console.WriteLine("Attack");
        }
        public void Dead()
        {
            Console.WriteLine("Dead");
        }

       

    }
    class Animal {
        public string name;
        public string birthDate;
        public string gender;
    }
    class Student
    {
        public string firstName;
        public string lastName;
        public string grade;

        public Student(string valuefirstName, string valuelastName, string valueGrade)
        {
            
        }
    }
    class Movie {
        public int ID;
        public string name;

        public Movie(int valueID, string valueName)
        {
            ID = valueID;
            name = valueName;
        }
    }
    class User {
        public string name;
        private List<Movie> movies;

          public User(string valueName)
        {
            name = valueName;
            movies = new List<Movie>();
        }

        public void addlist(Movie movie) {
            movies.Add(movie);
        }

        public void getMovies() {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.name);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Swordman Man1 = new Swordman();

            //Console.WriteLine(Man1.HP);
            //Console.WriteLine(Man1.EXP);
            //Console.WriteLine(Man1.Atk);
            //Console.WriteLine(Man1.Level);
            //Console.WriteLine(Man1.status);

            //Animal dog = new Animal();
            //dog.name = "G";
            //dog.birthDate = "03/08/63";
            //dog.gender = "Male";
            //Console.WriteLine(dog.name);

            //Student jj = new Student();
            //jj.firstName = "Jane";
            //jj.lastName = "Jo";
            //jj.grade = "A";

            //Student student = new Student("Jane", "Jo", "A");
            //changeGrade(student);
            //Console.WriteLine(student.grade);

            //List<Movie> movies = new List<Movie>();

            //Movie loki = new Movie(1, "Loki");
            //Movie starwars = new Movie(2, "Star wars");
            //Movie avengers = new Movie(3, "Avengers");

            //movies.Add(loki);
            //movies.Add(starwars);
            //movies.Insert(0, avengers);
            //movies.Remove(loki);

            //foreach(Movie movie in movies)
            //{
            //    Console.WriteLine(movie.name);
            //}

            User jane = new User("Jame");

            Movie loki = new Movie(1, "Loki");
            Movie starwars = new Movie(2, "StarWars");

            jane.addlist(loki);
            jane.addlist(starwars);

            jane.getMovies();
        }
        static void changeGrade(Student student) {
            student.grade = "F";
        }
    }
}
