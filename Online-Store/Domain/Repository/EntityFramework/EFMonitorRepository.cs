using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Repository.Abstract;
using System.Data.Common;

namespace Online_Store.Domain.Repository.EntityFramework
{
    public class EFMonitorRepository: EFProductRepository, IMonitorRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<EFProductRepository> logger;
        public EFMonitorRepository(AppDbContext context, ILogger<EFProductRepository> logger): base(context, logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public override IQueryable<Product> GetProducts()
        {
            return context.Monitors;
        }
        public override async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await context.Monitors.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
