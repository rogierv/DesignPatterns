using Iterator.Implementation;

ReverseContainer<int> reverseContainer = new(3)
{
	1,
	2,
	3
};

foreach (int value in reverseContainer)
{
	Console.WriteLine(value);
}

Console.ReadKey();