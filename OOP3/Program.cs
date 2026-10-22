namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            IKrediManager tasitKrediManager = new TasitKrediManager();          
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();               
            IKrediManager konutKrediManager = new KonutKrediManager();
            //IKrediManager esnafkredisi = new EsnafKredisi();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DataBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisi(), new List<ILoggerService>() { fileLoggerService, databaseLoggerService });

          // List<ILoggerService> loggers = new List<ILoggerService>() { new DataBaseLoggerService(), new FileLoggerService() };
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
// Inheretance: Inheritance is a fundamental concept in object-oriented programming (OOP) that allows
// a class (called a derived or child class) to inherit properties and behaviors (methods) from
// another class (called a base or parent class). This promotes code reusability and establishes
// a hierarchical relationship between classes. In C#, inheritance is implemented using the colon (:) syntax.


//Interface: An interface in C# is a contract that defines a set of methods, properties, events,
//or indexers that a class must implement. It allows for defining capabilities without specifying
//how they are implemented. Classes can implement multiple interfaces, enabling polymorphism and promoting loose
//coupling between components. Interfaces are declared using the 'interface' keyword.
