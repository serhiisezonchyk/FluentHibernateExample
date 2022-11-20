﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentHibernateTest.dao
{
    public class GenericDAO<T>:IGenericDAO<T>
    {
        protected ISession session;
        public GenericDAO() { }
        public GenericDAO(ISession session)
        {
            this.session = session;
        }
        public void SaveOrUpdate(T item)
        {
            ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(item);
            transaction.Commit();
        }
        public T GetById(long id)
        {
            return session.Get<T>(id);
        }
        public List<T> GetAll()
        {
            return new List<T>(session.CreateCriteria(typeof(T)).List<T>());
        }
        public void Delete(T item)
        {
            ITransaction transaction = session.BeginTransaction();
            session.Delete(item);
            transaction.Commit();
        }
    }
}
