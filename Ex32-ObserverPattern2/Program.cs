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

            // Ændret, så academy instansen kalder PropertyChanged eventet istedet for MessageChanged
            p.PropertyChanged += s1.Update;
            p.PropertyChanged += s2.Update;

            // Events are kind of protection of delegates
            // You can't set an event equal to something
            // p.MessageChanged = null; // If MessageChanged is null only the messages afterwards will be printed to the console
            
            p.PropertyChanged += s3.Update; 

            p.Message = "Så er der julefrokost!";

            p.PropertyChanged -= s1.Update;

            p.Message = "Så er der fredagsbar!";

            p.PropertyChanged+= s4.Update;

            p.Message = "Lektiecaféen er åben!";

            Console.WriteLine();

            // Test university and teacher classes
            University u = new University("UCLA", "Los Angeles Avenue");

            // Teachers constructor changed since it only takes one argument (Name)
            // It gets the object that raises the event, from the object sender parameter
            Teacher t1 = new Teacher("Mads");
            Teacher t2 = new Teacher("Rallo");
            Teacher t3 = new Teacher("Oskar");
            Teacher t4 = new Teacher("Kalle");

            // Calling PropertyChanged event and adding it with the Update method in the teacher class
            u.PropertyChanged += t1.Update;
            u.PropertyChanged += t2.Update;
            u.PropertyChanged += t3.Update;

            u.Message = "There's a meeting at the goathouse!";

            // Calling PropertyChanged event and removing it from MessageChanged
            u.PropertyChanged -= t3.Update;

            u.PropertyChanged += t4.Update;

            u.Message = "Join the Blue Raiders game today at 4 PM!";

            u.PropertyChanged -= t2.Update;

            Console.ReadLine();
        }
    }
}