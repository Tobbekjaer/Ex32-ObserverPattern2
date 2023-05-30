using Ex32_ObserverPattern2.ConcreteObserver;
using Ex32_ObserverPattern2.ConcreteSubject;

namespace Ex32_ObserverPattern2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Test academy and student classes
            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student("Jens");
            Student s2 = new Student("Niels");
            Student s3 = new Student("Susan");
            Student s4 = new Student("Tobias");

            p.MessageChanged += s1.Update;
            p.MessageChanged += s2.Update;

            // Events are kind of protection of delegates
            // You can't set an event equal to something
            // p.MessageChanged = null; // If MessageChanged is null only the messages afterwards will be printed to the console
            
            p.MessageChanged += s3.Update; 

            p.Message = "Så er der julefrokost!";

            p.MessageChanged -= s1.Update;

            p.Message = "Så er der fredagsbar!";

            p.MessageChanged += s4.Update;

            p.Message = "Lektiecaféen er åben!";

            Console.WriteLine();

            //// Test university and teacher classes
            //University u = new University("UCLA", "Los Angeles Avenue");

            //Teacher t1 = new Teacher(u, "Mads");
            //Teacher t2 = new Teacher(u, "Rallo");
            //Teacher t3 = new Teacher(u, "Oskar");
            //Teacher t4 = new Teacher(u, "Kalle");

            //// Calling MessageChanged delegate and adding it with the Update method in the teacher class
            //u.MessageChanged += t1.Update;
            //u.MessageChanged += t2.Update;
            //u.MessageChanged += t3.Update;

            //u.Message = "There's a meeting at the goathouse!";

            //// Calling MessageChanged delegate and removing it from MessageChanged
            //u.MessageChanged -= t3.Update;

            //u.MessageChanged += t4.Update;

            //u.Message = "Join the Blue Raiders game today at 4 PM!";

            //u.MessageChanged -= t2.Update;

            Console.ReadLine();
        }
    }
}