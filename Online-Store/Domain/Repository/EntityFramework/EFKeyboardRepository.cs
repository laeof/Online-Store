using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFKeyboardRepository: EFProductRepository, IKeyboardRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<EFProductRepository> logger;
        public EFKeyboardRepository(AppDbContext context, ILogger<EFProductRepository> logger) : base(context, logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public override IQueryable<Product> GetProducts()
        {
            return context.Keyboards;
        }
        public override async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await context.Keyboards.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
