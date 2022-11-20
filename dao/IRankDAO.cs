﻿using FluentHibernateTest.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentHibernateTest.dao
{
    public interface IRankDAO: IGenericDAO<Rank>
    {
        IList<Policeman> getAllPolicemanOfRank(string name);
    }
}
