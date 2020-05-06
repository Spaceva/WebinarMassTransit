﻿using System;
using System.Collections.Generic;
using WebinarMassTransit.Contracts;

namespace WebinarMassTransit.Core
{
    public class CoffeeInMemoryRepository : ICoffeeRepository
    {
        private readonly Dictionary<Guid, Coffee> Data = new Dictionary<Guid, Coffee>();

        public void AddToppings(Guid coffeeId, IReadOnlyCollection<Topping> toppings)
        {
            var coffee = Get(coffeeId);
            if (toppings == null)
                throw new System.ArgumentNullException(nameof(toppings));
            coffee.Toppings.AddRange(toppings);
        }

        public void Create(Guid coffeeId, CoffeeType coffeeType, bool noTopping)
        {
            Data.Add(coffeeId, new Coffee { Id = coffeeId, Type = coffeeType, Toppings = new List<Topping>(), Done = noTopping });
        }

        public Coffee Get(Guid coffeeId)
        {
            if (!Data.TryGetValue(coffeeId, out Coffee coffee))
                throw new System.ArgumentOutOfRangeException(nameof(coffeeId));
            return coffee;
        }

        public IReadOnlyCollection<Coffee> GetAll()
        {
            return Data.Values;
        }
    }
}
