﻿using Online_Store.Domain.Entities;
using Online_Store.Domain;

namespace Online_Store.Service
{
	public static class Extensions
	{
		public static async Task<bool> ValidateUser(string login, string password, DataManager dataManager)
		{

			try
			{
				User user = dataManager.Users.GetUsers().AsEnumerable().FirstOrDefault(u => u.Email.ToLower() == login.ToLower() && SecurePasswordHasher.Verify(password, u.Password));

				if (user != null)
				{
					if (!user.IsActive)
						return false;
					return true;
				}
			}
			catch
			{
				return false;
			}
			return false;
		}
	}
}
