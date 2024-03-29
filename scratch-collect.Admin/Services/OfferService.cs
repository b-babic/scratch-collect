﻿using AutoMapper;
using scratch_collect.Admin.Utilities;
using scratch_collect.Model;
using scratch_collect.Model.Requests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace scratch_collect.Admin.Services
{
    public class OfferService
    {
        private static string _baseUrl = System.Configuration.ConfigurationManager.AppSettings["BASE_API_URL"] + "offer";
        private static IMapper _mapper = ObjectMapper.GetMapper();

        public OfferService()
        {
        }

        public static string TruncateWithEllipsis(string s, int length)
        {
            //there may be a more appropiate unicode character for this
            const string Ellipsis = "...";

            if (Ellipsis.Length > length)
                throw new ArgumentOutOfRangeException("length", length, "length must be at least as long as ellipsis.");

            if (s.Length > length)
                return s.Substring(0, length - Ellipsis.Length) + Ellipsis;
            else
                return s;
        }

        public static async Task<List<OfferDTO>> GetAll(string? categoryId = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(categoryId))
                parameters["CategoryId"] = categoryId;

            try
            {
                var offers = await BaseService.GetAsync<List<OfferDTO>>(_baseUrl, parameters);

                foreach (var offer in offers)
                {
                    offer.Title = TruncateWithEllipsis(offer.Title, 30);
                    offer.Description = TruncateWithEllipsis(offer.Description, 50);
                }

                return _mapper.Map<List<OfferDTO>>(offers);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<OfferDTO> GetById(int id)
        {
            try
            {
                OfferDTO offer = await BaseService.GetAsync<OfferDTO>(_baseUrl + string.Format("/{0}", id));

                // Map to VM
                return _mapper.Map<OfferDTO>(offer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<OfferDTO> Insert(OfferUpsertRequest request)
        {
            try
            {
                var created = await BaseService.PostAsync<OfferDTO, OfferUpsertRequest>(_baseUrl, request);

                return _mapper.Map<OfferDTO>(created);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<OfferDTO> Update(OfferUpsertRequest request)
        {
            try
            {
                var updated = await BaseService.PutAsync<OfferDTO, OfferUpsertRequest>(_baseUrl + string.Format("/{0}", request.Id), request);

                return _mapper.Map<OfferDTO>(updated);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<bool> Delete(int id)
        {
            try
            {
                var response = await BaseService.DeleteAsync(_baseUrl + string.Format("/{0}", id));

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}