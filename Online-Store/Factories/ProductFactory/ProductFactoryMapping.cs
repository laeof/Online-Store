using Online_Store.Domain.Entities;

namespace Factories
{
    public static class ProductFactoryMapping
    {
        public static class CategoryProductTypeMapper
        {
            private static Dictionary<Guid, Type> _categoryProductTypes = new Dictionary<Guid, Type>();
            private static Dictionary<Type, Func<ProductFactory<Product>>> _categoryFactories = new Dictionary<Type, Func<ProductFactory<Product>>>();

            public static void RegisterCategoryType(Guid categoryId, Type productType, Func<ProductFactory<Product>> factoryFunc)
            {
                _categoryProductTypes[categoryId] = productType;
                _categoryFactories[productType] = factoryFunc;
            }

            public static Type GetProductType(Guid categoryId)
            {
                if (_categoryProductTypes.TryGetValue(categoryId, out Type productType))
                {
                    return productType;
                }

                throw new ArgumentException("Category not found.");
            }

            public static ProductFactory<Product> GetProductFactory(Type productType)
            {
                if (_categoryFactories.TryGetValue(productType, out Func<ProductFactory<Product>> factoryFunc))
                {
                    return factoryFunc();
                }

                throw new ArgumentException("Factory not found.");
            }
        }
    }
}
