using Strategy.Interfaces;

namespace Strategy.Implementation;

internal class SalaryStrategyFactory : ISalaryStrategyFactory
{
	public ISalaryStrategy CreateSalaryStrategy(IEmployee employee)
	{
		return employee.Title switch
		{
			"Director" => new DirectorSalaryStrategy(),
			"Senior Manager" => new SeniorManagerSalaryStrategy(),
			"Senior Software Engineer" => new SeniorSoftwareEngineerSalaryStrategy(),
			_ => throw new NotImplementedException()
		};
	}
}