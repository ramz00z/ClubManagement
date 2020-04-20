using AutoMapper;
using ClubManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Business
{
    public static class ObjectMapper
    {
        static ObjectMapper()
        {
            Initialize();
        }

        public static void Initialize()
        {
            Mapper.Initialize(cfg => CreateConfiguration(cfg));
        }

        private static void CreateConfiguration(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Model.Schedule, ScheduleViewModelBase>();
        }

        public static void Map<TOri, TDest>(TOri ori, TDest dest)
        {
            Mapper.Map(ori, dest);
        }

        public static TDest Map<TOri, TDest>(TOri ori)
        {
            return Mapper.Map<TOri, TDest>(ori);
        }
    }
}
