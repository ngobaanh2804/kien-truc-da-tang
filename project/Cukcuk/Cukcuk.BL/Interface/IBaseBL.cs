﻿using Cukcuk.EntityModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cukcuk.BL.Interface
{
    public interface IBaseBL<T>
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);
        object InsertData(Employee employee);
    }
}
