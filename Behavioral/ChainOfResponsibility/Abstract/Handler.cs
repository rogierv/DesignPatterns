using ChainOfResponsibility.Entities;

namespace ChainOfResponsibility.Abstract;

/// <summary>
/// This constructor is responsible for setting successor.
/// </summary>
/// <param name="successor">The successor.</param>
internal abstract class Handler(Handler successor)
{
	private readonly Handler _successor = successor;

	/// <summary>
	/// This method is responsible for getting access token
	/// for specific corporation.
	/// </summary>
	/// <param name="resourceType">The type of resource which was requested by user.</param>
	/// <returns>Access token.</returns>
	internal abstract string GetAccessToken(ResourceType resourceType);

	/// <summary>
	/// This method is responsible for getting access token
	/// from the next link if it is possible, if it is not
	/// possible the method will throw an exception.
	/// </summary>
	/// <param name="resourceType">The type of resource which was requested by user.</param>
	/// <returns>Access token.</returns>
	protected string GetAccessTokenFromNextLink(ResourceType resourceType)
	{
		if (_successor != null)
		{
			return _successor.GetAccessToken(resourceType);
		}
		else
		{
			var exceptionMessage = $"The {resourceType} resource type cannot be handled by current successors.";
			throw new Exception(exceptionMessage);
		}
	}
}