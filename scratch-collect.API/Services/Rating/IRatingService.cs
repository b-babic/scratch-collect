﻿using scratch_collect.Model;
using scratch_collect.Model.Report;
using System.Collections.Generic;

namespace scratch_collect.API.Services
{
    public interface IRatingService
    {
        RatingDTO Rate(RatingRequest request);
    }
}