using Strategy.Entities;
using Strategy.Implementation;
using Strategy.Interfaces;

SalaryStrategyFactory salaryStrategyFactory = new();
ISalaryStrategy salaryStrategy = salaryStrategyFactory.CreateSalaryStrategy(new SeniorSoftwareEngineer());
Console.WriteLine($"Senior Software Engineer salary is {salaryStrategy.GetSalary()}");

salaryStrategy = salaryStrategyFactory.CreateSalaryStrategy(new Director());
Console.WriteLine($"Director salary is {salaryStrategy.GetSalary()}");

salaryStrategy = salaryStrategyFactory.CreateSalaryStrategy(new SeniorManager());
Console.WriteLine($"Senior Manager salary is {salaryStrategy.GetSalary()}");

Console.ReadKey();