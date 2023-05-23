using Ex32_ObserverPattern2.ConcreteObserver;
using Ex32_ObserverPattern2.ConcreteSubject;

namespace Ex32_ObserverPattern2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student(p, "Jens");
            Student s2 = new Student(p, "Niels");
            Student s3 = new Student(p, "Susan");
            Student s4 = new Student(p, "Tobias");

            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);

            p.Message = "Så er der julefrokost!";

            p.Detach(s2);

            p.Message = "Så er der fredagsbar!";

            p.Attach(s4);

            p.Message = "Lektiecaféen er åben!";

            Console.ReadLine();
        }
    }
}