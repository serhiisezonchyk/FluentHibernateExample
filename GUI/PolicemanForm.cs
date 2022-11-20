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
    public partial class PolicemanForm : Form
    {
        private ISession session;
        private Form1 parent;

        private bool isAdd;
        private long key;
        public void setIsAdd(bool isAdd)
        {
            this.isAdd = isAdd;
        }
        public PolicemanForm()
        {
            InitializeComponent();
        }
        public void setParent(Form1 parent)
        {
            this.parent = parent;
        }
        public void setSession(ISession session)
        {
            this.session = session;
        }
        public void setKey(long key)
        {
            this.key = key;
        }

        public void setTextBoxFName(string fname) {
            this.textBoxFName.Text = fname;
        }
        public void setTextBoxLName(string lname)
        {
            this.textBoxLName.Text = lname;
        }
        public void setTextBoxAge(string age) {
            this.textBoxAge.Text = age;
        }
        public void setComboBoxSex(Sex sex) {
            DAOFactory dao = new NHibernateDAOFactory(session);
            ISexDAO sexDAO = dao.getSexDAO();
            List<Sex> sexList = sexDAO.GetAll();

            foreach (Sex s in sexList)
            {
                comboBoxSex.Items.Add(s.Id+")"+s.Name);
                if (!isAdd)
                    if (s.Id == sex.Id)
                        comboBoxSex.SelectedIndex = comboBoxSex.Items.Count - 1;
            }

        }
        public void setComboBoxDepartment(Department department) {
            DAOFactory dao = new NHibernateDAOFactory(session);
            IDepartmentDAO departmentDAO = dao.getDepartmentDAO();
            List<Department> departmentList = departmentDAO.GetAll();
            foreach (Department d in departmentList)
            {
                comboBoxDepartment.Items.Add(d.Id + ")" + d.Address+", "+d.City);
                if (!isAdd)
                    if (d.Id == department.Id)
                        comboBoxDepartment.SelectedIndex = comboBoxDepartment.Items.Count-1;
            }
        }
        public void setComboBoxRank(Rank rank) {
            DAOFactory dao = new NHibernateDAOFactory(session);
            IRankDAO rankDAO = dao.getRankDAO();
            List<Rank> rankList = rankDAO.GetAll();
            foreach (Rank r in rankList)
            {
                comboBoxRank.Items.Add(r.Id + ")" + r.Name);
                if (!isAdd)
                    if (r.Id == rank.Id)
                        comboBoxRank.SelectedIndex = comboBoxRank.Items.Count-1;
            }
        }
        public void setLabels()
        {
            if (isAdd)
            {
                buttonPol.Text = "Add policeman";
            }
            else
            {
                buttonPol.Text = "Update policeman";
            }
        }

        private void buttonPol_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                DAOFactory dao = new NHibernateDAOFactory(session);
                IPolicemanDAO policemanDAO = dao.getPolicemanDAO();

                ISexDAO sexDAO = dao.getSexDAO();
                IDepartmentDAO departmentDAO = dao.getDepartmentDAO();
                IRankDAO rankDAO = dao.getRankDAO();

                Policeman policeman = new Policeman();

                policeman.FirstName = textBoxFName.Text;
                policeman.LastName = textBoxLName.Text;
                policeman.Age = Convert.ToInt32(textBoxAge.Text);

                int pointSex = comboBoxSex.SelectedItem.ToString().IndexOf(")");
                Sex sex = sexDAO.GetById(Convert.ToInt32(comboBoxSex.SelectedItem.ToString().Substring(0, pointSex)));
                policeman.Sex = sex;

                int pointDepartment = comboBoxDepartment.SelectedItem.ToString().IndexOf(")");
                Department department = departmentDAO.GetById(Convert.ToInt32(comboBoxDepartment.SelectedItem.ToString().Substring(0, pointDepartment)));
                policeman.Department = department;

                int pointRank = comboBoxRank.SelectedItem.ToString().IndexOf(")");
                Rank rank = rankDAO.GetById(Convert.ToInt32(comboBoxRank.SelectedItem.ToString().Substring(0, pointRank)));
                policeman.Rank = rank;

                policemanDAO.SaveOrUpdate(policeman);
                parent.fillDataGridViewPoliceman();
                this.Visible = false;
            }
            else {
                DAOFactory dao = new NHibernateDAOFactory(session);
                IPolicemanDAO policemanDAO = dao.getPolicemanDAO();

                ISexDAO sexDAO = dao.getSexDAO();
                IDepartmentDAO departmentDAO = dao.getDepartmentDAO();
                IRankDAO rankDAO = dao.getRankDAO();

                Policeman policeman = policemanDAO.GetById(key);
                policeman.FirstName = textBoxFName.Text;
                policeman.LastName = textBoxLName.Text;
                policeman.Age = Convert.ToInt32(textBoxAge.Text);

                int pointSex = comboBoxSex.SelectedItem.ToString().IndexOf(")");
                Sex sex = sexDAO.GetById(Convert.ToInt32(comboBoxSex.SelectedItem.ToString().Substring(0, pointSex)));
                policeman.Sex = sex;

                int pointDepartment = comboBoxDepartment.SelectedItem.ToString().IndexOf(")");
                Department department = departmentDAO.GetById(Convert.ToInt32(comboBoxDepartment.SelectedItem.ToString().Substring(0, pointDepartment)));
                policeman.Department = department;

                int pointRank = comboBoxRank.SelectedItem.ToString().IndexOf(")");
                Rank rank = rankDAO.GetById(Convert.ToInt32(comboBoxRank.SelectedItem.ToString().Substring(0, pointRank)));
                policeman.Rank = rank;

                policemanDAO.SaveOrUpdate(policeman);
                this.Visible = false;
                parent.fillDataGridViewPoliceman();
            }
        }
    }
}
