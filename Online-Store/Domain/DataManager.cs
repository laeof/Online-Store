using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain
{
	public class DataManager
	{
		public IUserRepository Users { get; set; }
		public IRoleRepository Roles { get; set; }
		public IOrderRepository Orders { get; set; }
		public IProductRepository Products { get; set; }
		public IProductImagesRepository ProductImages { get; set; }
		public ICategoryRepository Categories { get; set; }
		public IMonitorRepository Monitors { get; set; }
		public IKeyboardRepository Keyboards { get; set; }
		public DataManager(IUserRepository Users,
						   IRoleRepository Roles,
						   IOrderRepository Orders,
						   IProductRepository Products,
						   IProductImagesRepository ProductImages,
						   ICategoryRepository Categories,
						   IMonitorRepository Monitors,
						   IKeyboardRepository Keyboards) 
		{
			this.Users = Users;
			this.Roles = Roles;
			this.Orders = Orders;
			this.Products = Products;
			this.ProductImages = ProductImages;
			this.Categories = Categories;
			this.Monitors = Monitors;
			this.Keyboards = Keyboards;
		}
	}
}
