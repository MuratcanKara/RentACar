using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        
        public IResult Add(Brand brand)
        {

            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {

            // linq sorgusu yazmayı dene
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {

            if (DateTime.Now.Hour == 12)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            
            return new SuccessDataResult<List<Brand>>(Messages.BrandsListed,_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == brandId));
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult();

        }

        IResult IBrandService.Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Brand> IBrandService.GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        IResult IBrandService.Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
