﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MasterGenerator.Data.Entity;
using MasterGenerator.Model.Model;

namespace MasterGenerator.Data.Helper  
{
     public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
            //CreateMap<AppUser, UserModel>();
            CreateMap<Project, ProjectModel>().ReverseMap();
        }
}
}