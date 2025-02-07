﻿using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ApplyService
    {
        public static List<ApplicationsDTO> Get()
        {

            var data = DataAccessFactory.JobApplyDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Apply, ApplicationsDTO>());
            var mapper = new Mapper(config);
            var app = mapper.Map<List<ApplicationsDTO>>(data);
            return app;
        }


        public static ApplicationsDTO Get(int id)
        {
            var data = DataAccessFactory.JobApplyDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Apply, ApplicationsDTO>());
            var mapper = new Mapper(config);
            var app = mapper.Map<ApplicationsDTO>(data);
            return app;
        }



        public static ApplicationsDTO IsExistsApplication(int id1, int id2)
        {
            string uid = id2.ToString();
            var data = DataAccessFactory.JobApplyDataAccess().Get(id1, uid);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Apply, ApplicationsDTO>());
            var mapper = new Mapper(config);
            var app = mapper.Map<ApplicationsDTO>(data);
            return app;
        }

        public static bool Add(int nid, int jid)
        {


            var userdata = UserDetailService.Get(nid);
            Apply jap = new Apply();
            jap.FK_Nid = nid;
            jap.Date = DateTime.Now;
            jap.Name = userdata.Name;

            var resp = DataAccessFactory.JobApplyDataAccess().Add(jap);
            return resp;

        }


        public static bool Delete(int id)
        {
            var result = DataAccessFactory.JobApplyDataAccess().Delete(id);
            return result;
        }
    }
}
