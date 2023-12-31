﻿using BisnessLayer.Abstarct;
using DataAcsesslayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Concrete
{
    public class GuideManager : iGuideServices
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TChangeToFalseGuide(int id)
        {
            _guideDal.ChangeToFalseGuide(id);
        }

        public void TChangeToTrueGuide(int id)
        {
            _guideDal.ChangeToTrueGuide(id);
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public Guide TGetByID(int id)
        {
            return _guideDal.GetByID(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
