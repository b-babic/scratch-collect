﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using scratch_collect.API.Database;
using scratch_collect.API.Exceptions;
using scratch_collect.Model;
using scratch_collect.Model.Report;
using scratch_collect.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace scratch_collect.API.Services
{
    public class ReportService : IReportService
    {
        private readonly ScratchCollectContext _context;
        private readonly IMapper _mapper;

        public ReportService(ScratchCollectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<SuccessOffer> SuccessOffers(SuccessOffersRequest request)
        {
            var query = _context
                .UserOffers
                .Include(x => x.Offer)
                .ThenInclude(x => x.Category)
                .Where(x => x.Offer.Category.Id == request.CategoryId)
                .AsQueryable();

            if (request?.CategoryId != null)
            {
                query = query.Where(x => x.Offer.CategoryId == request.CategoryId);
            }

            if (!string.IsNullOrEmpty(request.TimeFrom) && string.IsNullOrEmpty(request.TimeTo))
            {
                DateTime from = DateTime.Parse(request.TimeFrom);

                query = query.Where(s => s.PlayedOn >= from);
            }
            else if (string.IsNullOrEmpty(request.TimeFrom) && !string.IsNullOrEmpty(request.TimeTo))
            {
                DateTime to = DateTime.Parse(request.TimeTo);

                query = query.Where(s => s.PlayedOn <= to);
            }
            else if (!string.IsNullOrEmpty(request.TimeFrom) && !string.IsNullOrEmpty(request.TimeTo))
            {
                DateTime from = DateTime.Parse(request.TimeFrom);
                DateTime to = DateTime.Parse(request.TimeTo);

                query = query.Where(s => s.PlayedOn >= from && s.PlayedOn <= to);
            }

            var results = query
                          .ToList()
                          .GroupBy(r => r.Offer)
                          .Select(gr => new
                          {
                              Offer = gr.Key,
                              TimesWon = gr.Count(a => a.Won)
                          })
                          .Where(a => a.TimesWon > 0)
                          .OrderByDescending(a => a.TimesWon)
                          .ToList();

            List<SuccessOffer> test = new List<SuccessOffer>();
            foreach (var metric in results)
            {
                test.Add(new SuccessOffer
                {
                    Id = metric.Offer.Id,
                    Name = metric.Offer.Title,
                    Category = metric.Offer.Category.Name,
                    TimesWon = metric.TimesWon,
                });
            }

            return _mapper.Map<List<SuccessOffer>>(test);
        }
    }
}