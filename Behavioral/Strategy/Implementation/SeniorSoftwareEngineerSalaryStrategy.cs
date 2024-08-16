using Strategy.Interfaces;

namespace Strategy.Implementation;

internal class SeniorSoftwareEngineerSalaryStrategy : ISalaryStrategy
{
	private readonly decimal _currentSalary = 70000;

	public decimal GetSalary()
	{
		return _currentSalary;
	}
}