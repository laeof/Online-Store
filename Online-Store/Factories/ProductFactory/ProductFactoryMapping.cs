using AutoMapper.Configuration.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using System;
using System.Reflection;

namespace Online_Store
{
    public class CategoryProductTypeMapper
    {
        private DataManager _dataManager { get; set; }
        private readonly Dictionary<Type, IProductFactory> _factories = new Dictionary<Type, IProductFactory>();
        public CategoryProductTypeMapper(DataManager dataManager)
        {
            _dataManager = dataManager;
            RegisterFactories();
        }

        public async Task<Type> GetProductType(Guid categoryId)
        {
            var category = await _dataManager.Categories.GetCategoryByIdAsync(categoryId);
            var product = category.Products.FirstOrDefault();
            if (product != null)
            {
                return product.GetType();
            }

            throw new ArgumentException("Category not found.");
        }

        public void RegisterFactories()
        {
            RegisterFactory<Domain.Entities.Products.Monitor>(new MonitorFactory(_dataManager));
            RegisterFactory<Keyboard>(new KeyboardFactory(_dataManager));
        }

        public void RegisterFactory<TProduct>(IProductFactory factory) where TProduct : Product
        {
            _factories[typeof(TProduct)] = factory;
        }

        public IProductFactory GetFactory(Type productType)
        {
            if (_factories.TryGetValue(productType, out var factory))
            {
                return factory;
            }
            throw new ArgumentException("Factory not found.");
        }
    }
}
