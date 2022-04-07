﻿using System;
using System.Collections.Generic;
using CoffeeMassTransit.Contracts;

namespace CoffeeMassTransit.Core.DAL;

public interface ICoffeeRepository
{
    void Create(Guid coffeeId, Guid orderId, CoffeeType coffeeType, bool noTopping);
    void AddToppings(Guid coffeeId, IReadOnlyCollection<Topping> toppings);
    Coffee Get(Guid coffeeId);
    IReadOnlyCollection<Coffee> GetAll();
}
