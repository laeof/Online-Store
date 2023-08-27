using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Models;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly DataManager _dataManager;
        public CartController(DataManager dataManager) 
        {
            _dataManager = dataManager;
        }
        [HttpPost("addtocart")]
        public async Task<IActionResult> AddCartItem(CartViewModel model)
        {
            //get product

            var product = await _dataManager.Products.GetProductByIdAsync(model.ProductId);

            //if product does not exist

            if (product == null)
                return BadRequest();

            //get user

            var user = await _dataManager.Users.GetUserByIdAsync(model.UserId);

            //if user does not exist

            if (user == null)
                return BadRequest();

            //get cart

            var cart = await _dataManager.Carts.GetCartByIdAsync(user.CartId);

            //if cart does not exist

            if (cart == null)
                return BadRequest();

            //get cartitem from carts

            CartItems? cartItem = cart.CartItems.Where(x => x.ProductId == model.ProductId).FirstOrDefault();

            //if cartitem does not exist in cart

            if (cartItem == null)
            {
                cartItem = new CartItems
                {
                    CartId = user.CartId,
                    ProductId = product.Id,
                    ProductPrice = product.Price,
                };
            }

            //add amount of this product

            cartItem.ProductAmount++;

            await _dataManager.CartItems.SaveCartItemAsync(cartItem);

            return Ok();
        }
    }
}
