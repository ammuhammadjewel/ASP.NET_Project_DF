using AutoMapper;
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
    public class AcademicInfoService
    {
        public static List<AcademicInfoDTO> Get()
        {

            var data = DataAccessFactory.UserAcademicInfoDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AcademicInfo, AcademicInfoDTO>());
            var mapper = new Mapper(config);
            var rs = mapper.Map<List<AcademicInfoDTO>>(data);
            return rs;
        }

        public static AcademicInfoDTO Get(int id)
        {
            var data = DataAccessFactory.UserAcademicInfoDataAccess().GetbyFK(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AcademicInfo, AcademicInfoDTO>());
            var mapper = new Mapper(config);
            var res = mapper.Map<AcademicInfoDTO>(data);
            return res;
        }


        public static bool Add(AcademicInfoDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AcademicInfoDTO, AcademicInfo>());
            var mapper = new Mapper(config);
            var data = mapper.Map<AcademicInfo>(dto);
            var result = DataAccessFactory.UserAcademicInfoDataAccess().Add(data);
            return result;
        }


        public static bool Update(AcademicInfoDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AcademicInfoDTO, AcademicInfo>());
            var mapper = new Mapper(config);
            var data = mapper.Map<AcademicInfo>(dto);
            var result = DataAccessFactory.UserAcademicInfoDataAccess().Update(data);
            return result;

        }

        public static bool Delete(int id)
        {

            var result = DataAccessFactory.UserAcademicInfoDataAccess().Delete(id);
            return result;

        }
    }
}
