using Core.DataAccess.EntityFramework;
using DataAccess.Abtract;

using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal

    {
        public List<CarDetailDto> GetCarDetails()
        {
           using (ReCapContext context= new ReCapContext() ) 
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join r in context.Colors
                             on c.ColorId equals r.Id
                             select new CarDetailDto 
                             { 
                                BrandName=b.Name,
                                CarName=c.Description,
                                ColorName=r.Name,
                                DailyPrice=c.DailyPrice

                             };

                return result.ToList();
            }
        }
    }
}
