﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITokenRepo<CLASS, ID, RET>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RET Add(CLASS obj);
        bool Delete(CLASS obj);
        RET Update(CLASS obj);

    }
}
