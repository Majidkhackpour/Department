﻿using EntityCache.Core;
using EntityCache.SqlServerPersistence;
using Persistence.Model;

namespace EntityCache.Assistence
{
    public static class UnitOfWork
    {
        private static readonly ModelContext db = new ModelContext();
        private static IUsersRepository _usersRepository;
        private static ICustomerRepository _customerRepository;
        private static ICustomerLogRepository _customerLogRepository;
        private static IOrderRepository _orderRepository;
        private static IOrderDetailRepository _orderDetailRepository;
        private static IProductRepository _productRepository;
        private static IReceptionRepository _receptionRepository;
        private static ISafeBoxRepository _safeBoxRepository;
        private static ISmsLogRepository _smsLogRepository;
        private static ISmsPanelRepository _smsPanelRepository;
        private static IUserLogRepository _userLogRepository;
        private static ISettingsRepository _settingsRepository;
        private static INoteRepository _noteRepository;
        public static void Dispose() => db?.Dispose();
        public static void Set_Save() => db.SaveChanges();

        public static IUsersRepository Users => _usersRepository ??
                                                (_usersRepository =
                                                    new UsersPersistenceRepository(db));


        public static ICustomerRepository Customer => _customerRepository ??
                                                (_customerRepository =
                                                    new CustomerPersistenceRepository(db));


        public static ICustomerLogRepository CustomerLog => _customerLogRepository ??
                                                (_customerLogRepository =
                                                    new CustomerLogPersistenceRepository(db));


        public static IOrderRepository Order => _orderRepository ??
                                                (_orderRepository =
                                                    new OrderPersistenceRepository(db));


        public static IOrderDetailRepository OrderDetail => _orderDetailRepository ??
                                                (_orderDetailRepository =
                                                    new OrderDetailPersistenceRepository(db));


        public static IProductRepository Product => _productRepository ??
                                                 (_productRepository =
                                                     new ProductPersistenceRepository(db));


        public static IReceptionRepository Reception => _receptionRepository ??
                                                (_receptionRepository =
                                                    new ReceptionPersistenceRepository(db));


        public static ISafeBoxRepository SafeBox => _safeBoxRepository ??
                                                (_safeBoxRepository =
                                                    new SafeBoxPersistenceRepository(db));


        public static ISmsLogRepository SmsLog => _smsLogRepository ??
                                                (_smsLogRepository =
                                                    new SmsLogPersistenceRepository(db));


        public static ISmsPanelRepository SmsPanel => _smsPanelRepository ??
                                                (_smsPanelRepository =
                                                    new SmsPanelPersistenceRepository(db));


        public static IUserLogRepository UserLog => _userLogRepository ??
                                                (_userLogRepository =
                                                    new UserLogPersistenceRepository(db));


        public static ISettingsRepository Settings => _settingsRepository ??
                                                    (_settingsRepository =
                                                        new SettingsPersistenceRepository(db));


        public static INoteRepository Note => _noteRepository ??
                                                      (_noteRepository =
                                                          new NotePersistenceRepository(db));
    }
}
