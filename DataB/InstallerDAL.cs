using System;
using System.Collections.Generic;
using System.Text;
using DAL.DataMapper;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class InstallerDAL : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OrdinaceAndel;Trusted_Connection=True;MultipleActiveResultSets=true");

            container.Register(Component.For<DatabaseContext>()
                    .UsingFactoryMethod(() => new DatabaseContext(builder.Options))
                    .LifestyleTransient(),

                Component.For<BicycleMapper>()
                    .LifestyleTransient(),
                Component.For<CustomerMapper>()
                    .LifestyleTransient(),
                Component.For<EmployeeMapper>()
                    .LifestyleTransient(),
                Component.For<PaymentMapper>()
                    .LifestyleTransient(),
                Component.For<ReservationMapper>()
                    .LifestyleTransient(),
                Component.For<ReservationMapper>()
                    .LifestyleTransient());
        }


    }
}
}
