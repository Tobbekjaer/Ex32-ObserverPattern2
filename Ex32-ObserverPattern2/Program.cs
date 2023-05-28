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

            Student s1 = new Student(p, "Jens");
            Student s2 = new Student(p, "Niels");
            Student s3 = new Student(p, "Susan");
            Student s4 = new Student(p, "Tobias");

            //p.Attach(s1);
            //p.Attach(s2);
            //p.Attach(s3);

            p.Students += s1.Update;
            p.Students += s2.Update;
            p.Students += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.Students -= s1.Update;

            p.Message = "Så er der fredagsbar!";

            p.Students += s4.Update;

            p.Message = "Lektiecaféen er åben!";

            Console.WriteLine();

            // Test university and teacher classes
            //University u = new University("UCLA", "Los Angeles Avenue");

            //Teacher t1 = new Teacher(u, "Mads");
            //Teacher t2 = new Teacher(u, "Rallo");
            //Teacher t3 = new Teacher(u, "Oskar");
            //Teacher t4 = new Teacher(u, "Kalle");

            //u.Attach(t1);
            //u.Attach(t2);
            //u.Attach(t3);

            //u.Message = "There's a meeting at the goathouse!"; 

            //u.Detach(t3);

            //u.Attach(t4);

            //u.Message = "Join the Blue Raiders game today at 4 PM!";

            //u.Detach(t2);

            Console.ReadLine();
        }
    }
}