using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain
{
	public class DataManager
	{
		public IUserRepository Users { get; set; }
		public IRoleRepository Roles { get; set; }
		public IUserRoleRepository UserRoles { get; set; }
		public IOrderRepository Orders { get; set; }
		public IProductRepository Products { get; set; }
		public IProductImagesRepository ProductImages { get; set; }
		public DataManager(IUserRepository Users,
						   IRoleRepository Roles,
						   IUserRoleRepository UserRoles,
						   IOrderRepository Orders,
						   IProductRepository Products,
						   IProductImagesRepository ProductImages) 
		{
			this.Users = Users;
			this.Roles = Roles;	
			this.UserRoles = UserRoles;
			this.Orders = Orders;
			this.Products = Products;
			this.ProductImages = ProductImages;
		}
	}
}
