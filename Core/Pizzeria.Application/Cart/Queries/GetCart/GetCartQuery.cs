﻿using ErrorOr;
using MediatR;
using Pizzeria.Application.Cart.Queries.ViewModels;
using Pizzeria.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Pizzeria.Application.Cart.Queries.GetCart;

public class GetCartQuery : IRequest<ErrorOr<CartVm>>
{
}
