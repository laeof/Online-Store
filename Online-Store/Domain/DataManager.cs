using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain
{
	public class DataManager
	{
		public IUserRepository Users { get; set; }
		public IRoleRepository Roles { get; set; }
		public IUserRoleRepository UserRoles { get; set; }
		public IOrdersRepository Orders { get; set; }
		public DataManager(IUserRepository Users,
						   IRoleRepository Roles,
						   IUserRoleRepository UserRoles,
						   IOrdersRepository Orders) 
		{
			this.Users = Users;
			this.Roles = Roles;	
			this.UserRoles = UserRoles;
			this.Orders = Orders;
		}
	}
}
