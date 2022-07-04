﻿using AutoMapper;
using scratch_collect.Model;
using scratch_collect.Model.Desktop;

namespace scratch_collect.Admin.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // User
            CreateMap<UserDTO, UserVM>()
                .ForMember(dest => dest.UserPhoto, opt => opt.Condition(src => (src.UserPhoto != null && src.UserPhoto.Length > 0)));

            // Merchant
            CreateMap<MerchantDTO, MerchantVM>();
        }
    }
}