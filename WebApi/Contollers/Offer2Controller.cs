﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealtService.Application.Offers.Queries.GetOfferDetails;
using RealtService.Application.Offers.Queries.GetOfferList;
using RealtService.WebApi.Controllers;

namespace RealtService.WebApi.Contollers
{
    [Route("api/[controller]")]
    public class Offer2Controller : BaseController
    {
        private readonly IMapper _mapper;
        public Offer2Controller(IMapper mapper) => _mapper = mapper;
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetOfferListQuery { }));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OfferDetailsVm>> Get(int id)
        {
            var query = new GetOfferDetailsQuery
            {
                Id = id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
    }
}