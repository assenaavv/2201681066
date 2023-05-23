using System;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Valio", 30);
            Console.WriteLine(person.Name); 
            Console.WriteLine(person.Age); 
            
            FootballPlayer player = new FootballPlayer("Svetlio", 10, 25, 1.89);
            Console.WriteLine(player.Name); 
            Console.WriteLine(player.Number); 
            Console.WriteLine(player.Age);
            Console.WriteLine(player.Height); 

            Goalkeeper goalkeeper = new Goalkeeper("Nikola", 2, 23, 1.93);
            Console.WriteLine(goalkeeper.Name);
            Console.WriteLine(goalkeeper.Number);
            Console.WriteLine(goalkeeper.Age);
            Console.WriteLine(goalkeeper.Height);

            Defender defender = new Defender("Mihail", 3, 22, 1.85);
            Console.WriteLine(defender.Name);
            Console.WriteLine(defender.Number);
            Console.WriteLine(defender.Age);
            Console.WriteLine(defender.Height);

            Midfield midfield = new Midfield("George", 4, 45, 1.98);
            Console.WriteLine(midfield.Name);
            Console.WriteLine(midfield.Number);
            Console.WriteLine(midfield.Age);
            Console.WriteLine(midfield.Height);

            Striker striker = new Striker("Petko", 5, 33, 1.76);
            Console.WriteLine(striker.Name);
            Console.WriteLine(striker.Number);
            Console.WriteLine(striker.Age);
            Console.WriteLine(striker.Height);

            Coach coach = new Coach("Roberto", 56);
            Console.WriteLine(coach.Name);
            Console.WriteLine(coach.Age);

            Referee referee = new Referee("Maikal", 76);
            Console.WriteLine(referee.Name);
            Console.WriteLine(referee.Age);

      
            
        }
    }
}
