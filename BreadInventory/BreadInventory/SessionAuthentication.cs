using BreadInventory;

public static class SessionAuthentication
{
	public static User AuthenticatedUser { get; private set; }

	public static void Login(User user)
	{
		AuthenticatedUser = user;
	}

	public static void Logout()
	{
		AuthenticatedUser = null;
	}

	public static bool IsAuthenticated => AuthenticatedUser != null;
}
