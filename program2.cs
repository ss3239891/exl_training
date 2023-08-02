using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Student
    {
        public int score = 0;
        
        
    }
    internal class program2
    {
        static void Main(string[] args)
        {
            Student paul = new Student();
            Student casselyn = new Student();
            Student andika = new Student();

            paul.score = 10;
            casselyn.score = 20;
            andika.score = paul.score + casselyn.score;

         
            Student herman = andika;
            herman.score = 100;

            Console.WriteLine("Paul " +paul.score);
            Console.WriteLine("casselyn " + casselyn.score);
            Console.WriteLine("andika " + andika.score);
            Console.WriteLine("herman " + herman.score);

        }
    }
}
