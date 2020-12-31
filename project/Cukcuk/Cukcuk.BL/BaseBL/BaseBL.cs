using Cukcuk.BL.Interface;
using Cukcuk.DL.Base;
using Cukcuk.EntityModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cukcuk.BL.BaseBL
{
    public class BaseBL<T> where T: class
    {
        private readonly BaseDL<T> _baseDL;

        public BaseBL()
        {
            this._baseDL = new BaseDL<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _baseDL.GetAll();
        }

        public T GetById(Guid id)
        {
            return _baseDL.GetById(id);
        }

        public bool InsertData(T data)
        {
            return _baseDL.InsertData(data);
        }

        public bool UpdateData(T data)
        {
            return _baseDL.UpdateData(data);
        }

        public bool DeleteData(Guid id)
        {
            return _baseDL.DeleteData(id);
        }
    }
}
