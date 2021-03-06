﻿using Domain;

namespace Domain.Service.Interfaces
{
   public interface IShoppingCartService
   {
      ShoppingCart GetShoppingCart();

      void DeserializeShoppingCart(string jsonData);

      string SerializeShoppingCart();
   }
}
