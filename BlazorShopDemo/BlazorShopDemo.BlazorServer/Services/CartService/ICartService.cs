﻿using BlazorShopDemo.Domain.Models;

namespace BlazorShopDemo.BlazorServer.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;

        Task AddToCart(CartItem cartItem);

        Task<List<CartItem>> GetCartItems();

        Task DeleteItem(CartItem item);

        Task EmptyCart();
    }
}