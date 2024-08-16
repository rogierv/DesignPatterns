using ChainOfResponsibility.Entities;
using ChainOfResponsibility.Implementation;

try
{
	TokenStorage tokenStorage = new();
	IEnumerable<ResourceType> resourceTypes = Enum.GetValues(typeof(ResourceType)).Cast<ResourceType>();
	foreach (ResourceType resourceType in resourceTypes)
	{
		var accessToken = tokenStorage.GetAccessToken(resourceType);
		DisplayAccessToken(resourceType, accessToken);
	}
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

Console.WriteLine("Please enter any key to exit...");
Console.ReadKey();

/// <summary>
/// Displays the name of corporation together with
/// access token.
/// </summary>
/// <param name="resourceType"></param>
/// <param name="accessToken"></param>
static void DisplayAccessToken(ResourceType resourceType, string accessToken)
{
	Console.WriteLine("This is a {0} access token {1}", resourceType, accessToken);
}