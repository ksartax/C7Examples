using static System.Console;

namespace C7Examples
{
    public class ConditionalSwitch
    {
        public ConditionalSwitch()
        {
            Run();
        }

        public void Run()
        {
            Employee employee = new VicePresident() {
                Name = "Adam",
                PeoplesCount = 100
            };

            switch (employee)
            {
                case VicePresident vice when vice.PeoplesCount > 100:
                    WriteLine($"Vice : {vice.Name} : {vice.PeoplesCount}");

                    break;

                case VicePresident vice when vice.PeoplesCount <= 100:
                    WriteLine($"Vice : {vice.Name} : {vice.PeoplesCount}");

                    break;

                case VicePresident vice :
                    WriteLine($"Vice : {vice.Name} : {vice.PeoplesCount}");

                    break;

                case Manager m:
                    WriteLine($"Manager : {m.Name} : {m.ProjectsCount}");
                    break;

                case Employee e:
                    WriteLine($"Employee : {e.Name}");
                    break;

                default:
                    break;
            }
        }

        class Employee
        {
            public string Name { get; set; }
        }

        class VicePresident : Employee
        {
            public int PeoplesCount { get; set; }
        }

        class Manager : Employee
        {
            public int ProjectsCount { get; set; }
        }
    }
}
