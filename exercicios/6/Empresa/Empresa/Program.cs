namespace Empresa;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employee = new List<Employee>();
        Console.Write("How many employees will be registered?: ");
        int employeeNumerber = int.Parse(Console.ReadLine());

        for (int i = 0; i < employeeNumerber; i++)
        {
             
            Console.WriteLine($"Employee {i + 1}:");
            Console.Write("Id: ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Salary: ");
            double Salary = double.Parse(Console.ReadLine());

            Employee employeeTemp = new Employee(Id, Name, Salary);

            employee.Add(employeeTemp);

        }

        Console.Write("Enter the employee Id that will have salary increase: ") ;
        int idIncrease = int.Parse(Console.ReadLine());


        foreach(Employee emp in employee)  // eu estava colocando foreach(obj emp in employee)
        {
            if (emp.Id == idIncrease)
            {
                Console.Write("Enter the percentag(%): ");
                int percentege = int.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentege);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
        }

        /* NO GABARITO ELE APLICA DESSA FORMA: 
        
        Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

        UTILIZA O .FIND PARA PORCURAR DENTRO DA LISTA O ID E DEPOIS FAZ A CONDICIONAL
        */


        Console.WriteLine("Update list od employees: ");
        foreach (Employee obj in employee)
        {
            Console.WriteLine(obj);
        }
    }
}