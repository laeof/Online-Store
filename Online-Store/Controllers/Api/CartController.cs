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

            var product = await _dataManager.Products.GetProductByIdAsync((Guid)model.ProductId);

            //if product does not exist

            if (product == null)
                return BadRequest();

            //get user

            var user = await _dataManager.Users.GetUserByIdAsync((Guid)model.UserId);

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
        [HttpGet("getcart")]
        public async Task<IActionResult> GetCart(Guid id)
        {
            //get user

            var user = await _dataManager.Users.GetUserByIdAsync(id);

            //if user does not exist

            if (user == null)
                return BadRequest();

            //get cart

            Cart cart = await _dataManager.Carts.GetCartByIdAsync(user.CartId);

            //if cart does not exist

            if (cart == null)
                return BadRequest();

            List<CartItems>? cartItems = _dataManager.CartItems.GetCartItems()
                .Where(cid => cid.CartId == cart.Id)
                .Select(ci => new CartItems
                {
                    Id = ci.Id,
                    ProductId = ci.ProductId,
                    ProductAmount = ci.ProductAmount,
                    ProductPrice = ci.ProductPrice,
                    CartId = cart.Id
                }).ToList();

            return Ok(cartItems);
        }
        [HttpPost("deletefromcart")]
        public async Task<IActionResult> DeleteCartItem(CartItemsViewModel cart)
        {
            if (cart == null)
                return BadRequest();

            if (cart.Id == null)
                return BadRequest();

            var cartitem = await _dataManager.CartItems.GetCartItemByIdAsync(cart.Id);

            if(cartitem == null) 
                return BadRequest();

            await _dataManager.CartItems.DeleteCartItemAsync(cartitem);

            return Ok();
        }
        [HttpPost("minusfromcart")]
        public async Task<IActionResult> MinusCartItem(CartItemsViewModel cart)
        {
            if (cart == null)
                return BadRequest();

            if (cart.Id == null)
                return BadRequest();

            var cartitem = await _dataManager.CartItems.GetCartItemByIdAsync(cart.Id);

            if (cartitem == null)
                return BadRequest();

            if (cartitem.ProductAmount < 2)
            {
                await DeleteCartItem(cart);
            }
            else
            {
                cartitem.ProductAmount--;
                await _dataManager.CartItems.SaveCartItemAsync(cartitem);
            }
            return Ok();
        }
        [HttpPost("addcartitem")]
        public async Task<IActionResult> AddCartItem(CartItemsViewModel cart)
        {
            if (cart == null)
                return BadRequest();

            if (cart.Id == null)
                return BadRequest();

            var cartitem = await _dataManager.CartItems.GetCartItemByIdAsync(cart.Id);

            if (cartitem == null)
                return BadRequest();

            cartitem.ProductAmount++;

            await _dataManager.CartItems.SaveCartItemAsync(cartitem);

            return Ok();
        }
    }
}
