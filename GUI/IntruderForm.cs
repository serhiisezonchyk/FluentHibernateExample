using FluentHibernateTest.dao;
using FluentHibernateTest.domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentHibernateTest.GUI
{
    public partial class IntruderForm : Form
    {
        private ISession session;
        private Form1 parent;

        private bool isAdd = true;
        private long key;

        private long policeKey;
        public IntruderForm()
        {
            InitializeComponent();
        }
        public void setParent(Form1 parent)
        {
            this.parent = parent;
        }
        public void setIsAdd(bool isAdd)
        {
            this.isAdd = isAdd;
        }
        public void setSession(ISession session)
        {
            this.session = session;
        }
        public void setKey(long key)
        {
            this.key = key;
        }
        public void setPoliceKey(long key)
        {
            this.policeKey = key;
        }

        public void setTextBoxFName(string fname)
        {
            this.textBoxFName.Text = fname;
        }
        public void setTextBoxLName(string lname)
        {
            this.textBoxLName.Text = lname;
        }
        public void setTextBoxAge(string age)
        {
            this.textBoxAge.Text = age;
        }
        public void setTextBoxDescription(string description)
        {
            this.textBoxDescription.Text = description;
        }
        public void setTextBoxPhone(string phone)
        {
            this.textBoxPhone.Text = phone;
        }
        public void setComboBoxSex(Sex sex)
        {
            DAOFactory dao = new NHibernateDAOFactory(session);
            ISexDAO sexDAO = dao.getSexDAO();
            List<Sex> sexList = sexDAO.GetAll();

            foreach (Sex s in sexList)
            {
                comboBoxSex.Items.Add(s.Id + ")" + s.Name);
                if (!isAdd)
                    if (s.Id == sex.Id)
                        comboBoxSex.SelectedIndex = comboBoxSex.Items.Count - 1;
            }

        }
        public void setComboBoxPoliceman(Policeman policeman)
        {
            DAOFactory dao = new NHibernateDAOFactory(session);
            IPolicemanDAO policemanDAO = dao.getPolicemanDAO();
            List<Policeman> policemanList = policemanDAO.GetAll();
            foreach (Policeman p in policemanList)
            {
                comboBoxPoliceman.Items.Add(p.Id + ")" + p.FirstName + " " + p.LastName + ", " + p.Department.City );
                if (p.Id == policeman.Id)
                    comboBoxPoliceman.SelectedIndex = comboBoxPoliceman.Items.Count - 1;
            }
        }
        public void setLabels()
        {
            if (isAdd)
            {
                buttonIntr.Text = "Add policeman";
            }
            else
            {
                buttonIntr.Text = "Update policeman";
            }
        }

        private void buttonIntr_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                DAOFactory dao = new NHibernateDAOFactory(session);
                IIntruderDAO intruderDAO = dao.getIntruderDAO();

                ISexDAO sexDAO = dao.getSexDAO();
                IPolicemanDAO policemanDAO = dao.getPolicemanDAO();

                Intruder intruder = new Intruder();

                intruder.FirstName = textBoxFName.Text;
                intruder.LastName = textBoxLName.Text;
                intruder.Age = Convert.ToInt32(textBoxAge.Text);
                intruder.Description = textBoxDescription.Text;
                intruder.Phone = textBoxPhone.Text;

                int pointSex = comboBoxSex.SelectedItem.ToString().IndexOf(")");
                Sex sex = sexDAO.GetById(Convert.ToInt32(comboBoxSex.SelectedItem.ToString().Substring(0, pointSex)));
                intruder.Sex = sex;

                int pointPol = comboBoxPoliceman.SelectedItem.ToString().IndexOf(")");
                Policeman policeman = policemanDAO.GetById(Convert.ToInt32(comboBoxPoliceman.SelectedItem.ToString().Substring(0, pointPol)));
                intruder.Policeman = policeman;

                intruderDAO.SaveOrUpdate(intruder);
                parent.fillDataGridViewIntruder(policeKey);
                this.Visible = false;
            }
            else
            {
                DAOFactory dao = new NHibernateDAOFactory(session);
                IIntruderDAO intruderDAO = dao.getIntruderDAO();

                ISexDAO sexDAO = dao.getSexDAO();
                IPolicemanDAO policemanDAO = dao.getPolicemanDAO();

                Intruder intruder = intruderDAO.GetById(key);
                intruder.FirstName = textBoxFName.Text;
                intruder.LastName = textBoxLName.Text;
                intruder.Age = Convert.ToInt32(textBoxAge.Text);
                intruder.Description = textBoxDescription.Text;
                intruder.Phone = textBoxPhone.Text;

                int pointSex = comboBoxSex.SelectedItem.ToString().IndexOf(")");
                Sex sex = sexDAO.GetById(Convert.ToInt32(comboBoxSex.SelectedItem.ToString().Substring(0, pointSex)));
                intruder.Sex = sex;

                int pointPoliceman = comboBoxPoliceman.SelectedItem.ToString().IndexOf(")");
                Policeman policeman = policemanDAO.GetById(Convert.ToInt32(comboBoxPoliceman.SelectedItem.ToString().Substring(0, pointPoliceman)));
                intruder.Policeman = policeman;

                intruderDAO.SaveOrUpdate(intruder);
                this.Visible = false;
                parent.fillDataGridViewIntruder(policeKey);
            }
        }
    }
}
