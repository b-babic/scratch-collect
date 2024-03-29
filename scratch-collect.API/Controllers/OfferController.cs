using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using scratch_collect.API.Services;
using scratch_collect.Model;
using scratch_collect.Model.Requests;
using System.Collections.Generic;

namespace scratch_collect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private IOfferService _offerService;
        private IRatingService _ratingService;

        public OfferController(IOfferService offerService, IRatingService ratingService)
        {
            _offerService = offerService;
            _ratingService = ratingService;
        }

        [HttpGet]
        public List<OfferDTO> Get([FromQuery] OfferSearchRequest request)
        {
            return _offerService.Get(request);
        }

        [HttpGet("{id:int}")]
        public OfferDTO GetById(int id)
        {
            return _offerService.GetById(id);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public OfferDTO Insert(OfferUpsertRequest request)
        {
            return _offerService.Insert(request);
        }

        [AllowAnonymous]
        [HttpPut("{id:int}")]
        public OfferDTO Update(int id, OfferUpsertRequest request)
        {
            return _offerService.Update(id, request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            _offerService.Delete(id);
        }

        // User offers
        [Authorize(Roles = "Administrator, Client")]
        [HttpPost("buy/{id:int}")]
        public UserOfferDTO Buy(int id, UserOfferUpsertRequest request)
        {
            request.OfferId = id;

            return _offerService.BuyOffer(request);
        }

        [Authorize(Roles = "Administrator, Client")]
        [HttpPost("archive/{id:int}")]
        public UserOfferDTO Archive(int id, UserOfferUpsertRequest request)
        {
            request.OfferId = id;

            return _offerService.ArchiveOffer(request);
        }

        [AllowAnonymous]
        [HttpPost("play")]
        public UserOfferDTO Play(UserOfferPlayRequest request)
        {
            return _offerService.Play(request);
        }

        // Ratings
        [AllowAnonymous]
        [HttpPost("rate")]
        public RatingDTO Rate([FromBody] RatingRequest request)
        {
            return _ratingService.Rate(request);
        }
    }
}