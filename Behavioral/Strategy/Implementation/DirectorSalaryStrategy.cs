using Strategy.Interfaces;

namespace Strategy.Implementation;

internal class DirectorSalaryStrategy : ISalaryStrategy
{
	private readonly decimal _currentSalary = 120000;

	public decimal GetSalary()
	{
		return _currentSalary;
	}
}