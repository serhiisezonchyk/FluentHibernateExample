using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentHibernateTest.GUI
{
    public partial class ConnectionForm : Form
    {
        private ISessionFactory factory;

        private ISession session;

        private Form1 parent;
        public ConnectionForm()
        {
            InitializeComponent();
        }
        public void setParent(Form1 parent)
        {
            this.parent = parent;
        }
        private ISession openSession(String host, int port, String database, String user, String pass)
        {
            ISession session = null;
            Assembly mappingsAssemly = Assembly.GetExecutingAssembly();
            if (factory == null)
            {
                factory = Fluently.Configure()
                .Database(PostgreSQLConfiguration
                .PostgreSQL82.ConnectionString(c => c
                .Host(host)
                .Port(port)
                .Database(database)
                .Username(user)
                .Password(pass)))
                .Mappings(m => m.FluentMappings
                .AddFromAssembly(mappingsAssemly))
                .BuildSessionFactory();
            }
            //Открытие сессии
            session = factory.OpenSession();
            return session;
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            session = openSession(this.textBoxHost.Text,Convert.ToInt32(this.textBoxPort.Text),this.textBoxDataBase.Text, this.textBoxUser.Text, this.textBoxPass.Text);
            this.Visible = false;
            parent.setSession(session);
            parent.fillDataGridViewPoliceman();
        }
    }
}
