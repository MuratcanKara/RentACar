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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        
        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 12)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            
            return new SuccessDataResult<List<Color>>(Messages.ColorsListed,_colorDal.GetAll());
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c=>c.Id == colorId);
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            
            
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        IDataResult<List<Color>> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Color> IColorService.GetById(int colorId)
        {
            throw new NotImplementedException();
        }

        IResult IColorService.Add(Color color)
        {
            throw new NotImplementedException();
        }

        IResult IColorService.Update(Color color)
        {
            throw new NotImplementedException();
        }

        IResult IColorService.Delete(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
