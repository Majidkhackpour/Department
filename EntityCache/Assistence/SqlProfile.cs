using AutoMapper;
using EntityCache.Bussines;
using Persistence.Entities;

namespace EntityCache.Assistence
{
    public class SqlProfile : Profile
    {
        public SqlProfile()
        {
            CreateMap<UsersBussines, Users>().ReverseMap();
            CreateMap<CustomerBussines, Customer>().ReverseMap();
            CreateMap<CustomerLogBussines, CustomerLog>().ReverseMap();
            CreateMap<OrderBussines, Order>().ReverseMap();
            CreateMap<OrderDetailBussines, OrderDetail>().ReverseMap();
            CreateMap<ProductBussines, Products>().ReverseMap();
            CreateMap<ReceptionBussines, Reception>().ReverseMap();
            CreateMap<SafeBoxBussines, SafeBox>().ReverseMap();
            CreateMap<SmsLogBussines, SmsLog>().ReverseMap();
            CreateMap<SmsPanelBussines, SmsPanels>().ReverseMap();
            CreateMap<UserLogBussines, UserLog>().ReverseMap();
            CreateMap<SettingsBussines, Settings>().ReverseMap();
            CreateMap<NoteBussines, Note>().ReverseMap();
        }
    }
}
