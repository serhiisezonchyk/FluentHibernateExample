using FluentHibernateTest.dao;
using FluentHibernateTest.domain;
using FluentHibernateTest.GUI;
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

namespace FluentHibernateTest
{
    public partial class Form1 : Form
    {
        private ISession session;
        public Form1()
        {
            InitializeComponent();
        }
        public void setSession(ISession session)
        {
            this.session = session;
        }

        public ConnectionForm getFormConnect()
        {
            ConnectionForm formConnect = new ConnectionForm();
            formConnect.setParent(this);
            return formConnect;
        }
        public IntruderForm getFormIntruderCU()
        {
            IntruderForm formIntruder = new IntruderForm();
            formIntruder.setParent(this);
            return formIntruder;
        }

        public PolicemanForm getFormPolicemanCU()
        {
            PolicemanForm formPoliceman = new PolicemanForm();
            formPoliceman.setParent(this);
            return formPoliceman;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getFormConnect().Visible = true;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session.Close();
            dataGridViewPoliceman.Rows.Clear();
            dataGridViewIntruder.Rows.Clear();
        }

        //Метод по заполнению dataGridView1
        public void fillDataGridViewPoliceman()
        {
            dataGridViewPoliceman.Rows.Clear();
            DAOFactory dao = new NHibernateDAOFactory(session);
            IPolicemanDAO policemanDAO = dao.getPolicemanDAO();
            List<Policeman> policemanList = policemanDAO.GetAll();
            foreach (Policeman p in policemanList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell celliD = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellFirstName = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellLastName = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellAge = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellSex = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellDepartment = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellRank = new DataGridViewTextBoxCell();

                celliD.ValueType = typeof(long);
                celliD.Value = p.Id;
                cellFirstName.ValueType = typeof(string);
                cellFirstName.Value = p.FirstName;
                cellLastName.ValueType = typeof(string);
                cellLastName.Value = p.LastName;
                cellAge.ValueType = typeof(int);
                cellAge.Value = p.Age;
                cellSex.ValueType = typeof(string);
                cellSex.Value = p.Sex.Id + ") " +p.Sex.Name;
                cellDepartment.ValueType = typeof(string);
                cellDepartment.Value = p.Department.Id + ") "+ p.Department.Address+ "," + p.Department.City;
                cellRank.ValueType = typeof(string);
                cellRank.Value = p.Rank.Id+") "+ p.Rank.Name;

                row.Cells.Add(celliD);
                row.Cells.Add(cellFirstName);
                row.Cells.Add(cellLastName);
                row.Cells.Add(cellAge);
                row.Cells.Add(cellSex);
                row.Cells.Add(cellDepartment);
                row.Cells.Add(cellRank);

                dataGridViewPoliceman.Rows.Add(row);
            }
        }

        public void fillDataGridViewIntruder(long key)
        {
            dataGridViewIntruder.Rows.Clear();
            DAOFactory dao = new NHibernateDAOFactory(session);
            IPolicemanDAO policemanDAO = dao.getPolicemanDAO();
            //Получение студентов заданной группы
            IList<Intruder> intruderList = policemanDAO.getAllIntruderOfPoliceman(key);
            foreach ( Intruder i in intruderList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cellIdIntruder = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellFirstName = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellLastName = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellAge = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellSex = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellDescription = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellPhone = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cellPoliceman = new DataGridViewTextBoxCell();

                cellIdIntruder.ValueType = typeof(long);
                cellIdIntruder.Value = i.Id;
                cellFirstName.ValueType = typeof(string);
                cellFirstName.Value = i.FirstName;
                cellLastName.ValueType = typeof(string);
                cellLastName.Value = i.LastName;
                cellAge.ValueType = typeof(int);
                cellAge.Value = i.Age;
                cellSex.ValueType = typeof(string);
                cellSex.Value = i.Sex.Id +") "+i.Sex.Name;
                cellDescription.ValueType = typeof(string);
                cellDescription.Value = i.Description;
                cellPhone.ValueType = typeof(string);
                cellPhone.Value = i.Phone;
                cellPoliceman.ValueType = typeof(string);
                cellPoliceman.Value = i.Policeman.Id + ") "+i.Policeman.FirstName + " "+ i.Policeman.LastName;

                row.Cells.Add(cellIdIntruder);
                row.Cells.Add(cellFirstName);
                row.Cells.Add(cellLastName);
                row.Cells.Add(cellAge);
                row.Cells.Add(cellSex);
                row.Cells.Add(cellDescription);
                row.Cells.Add(cellPhone);
                row.Cells.Add(cellPoliceman);
                dataGridViewIntruder.Rows.Add(row);
            }
        }

        private void dataGridViewPoliceman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDataGridViewIntruder(Convert.ToInt32(dataGridViewPoliceman.Rows[dataGridViewPoliceman.CurrentCell.RowIndex].Cells[0].Value));
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolicemanForm form = getFormPolicemanCU();
            form.setSession(session);
            form.setIsAdd(true);
            form.setLabels();
            form.Visible = true;
            form.setTextBoxFName("");
            form.setTextBoxLName("");
            form.setTextBoxAge("");
            form.setComboBoxSex(null);
            form.setComboBoxDepartment(null);
            form.setComboBoxRank(null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewPoliceman.SelectedCells[0].RowIndex;
            long key = Convert.ToInt32(dataGridViewPoliceman.Rows[selectedRow].Cells[0].Value);
            DAOFactory dao = new NHibernateDAOFactory(session);
            IPolicemanDAO policemanDAO = dao.getPolicemanDAO();
            Policeman policeman = policemanDAO.GetById(key);

            PolicemanForm form = getFormPolicemanCU();
            form.setSession(session);
            form.setIsAdd(false);
            form.setLabels();
            form.Visible = true;
            form.setKey(key);
            form.setTextBoxFName(policeman.FirstName);
            form.setTextBoxLName(policeman.LastName);
            form.setTextBoxAge(Convert.ToString(policeman.Age));
            form.setComboBoxSex(policeman.Sex);
            form.setComboBoxDepartment(policeman.Department);
            form.setComboBoxRank(policeman.Rank);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAOFactory dao = new NHibernateDAOFactory(session);
            IPolicemanDAO policemanDAO = dao.getPolicemanDAO();
            int selectedRow = dataGridViewPoliceman.SelectedCells[0].RowIndex;
            long key = Convert.ToInt32(dataGridViewPoliceman.Rows[selectedRow].Cells[0].Value);
            DialogResult dr = MessageBox.Show("Delete policeman?", "Delete form",
            MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    policemanDAO.Delete(policemanDAO.GetById(key));
                    this.fillDataGridViewPoliceman();
                }
                catch (Exception)
                {
                }
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DAOFactory dao = new NHibernateDAOFactory(session);
            IPolicemanDAO policemanDAO = dao.getPolicemanDAO();

            int selectedRow = dataGridViewPoliceman.SelectedCells[0].RowIndex;
            long key = Convert.ToInt32(dataGridViewPoliceman.Rows[selectedRow].Cells[0].Value);
            IntruderForm form = getFormIntruderCU();
            form.setSession(session);
            form.setIsAdd(true);
            form.setLabels();
            form.Visible = true;
            form.setPoliceKey(key);
            form.setTextBoxFName("");
            form.setTextBoxLName("");
            form.setTextBoxAge("");
            form.setTextBoxPhone("");
            form.setTextBoxDescription("");
            form.setComboBoxSex(null);
            form.setComboBoxPoliceman(policemanDAO.GetById(key));

        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewIntruder.SelectedCells[0].RowIndex;
            long key = Convert.ToInt32(dataGridViewIntruder.Rows[selectedRow].Cells[0].Value);
            DAOFactory dao = new NHibernateDAOFactory(session);
            IIntruderDAO intruderDAO = dao.getIntruderDAO();
            Intruder intruder = intruderDAO.GetById(key);

            IntruderForm form = getFormIntruderCU();
            form.setSession(session);
            form.setIsAdd(false);
            form.setLabels();
            form.Visible = true;
            form.setKey(key);
            form.setPoliceKey(intruder.Policeman.Id);
            form.setTextBoxFName(intruder.FirstName);
            form.setTextBoxLName(intruder.LastName);
            form.setTextBoxAge(Convert.ToString(intruder.Age));
            form.setTextBoxDescription(intruder.Description);
            form.setTextBoxPhone(intruder.Phone);
            form.setComboBoxSex(intruder.Sex);
            form.setComboBoxPoliceman(intruder.Policeman);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DAOFactory dao = new NHibernateDAOFactory(session);
            IIntruderDAO intruderDAO = dao.getIntruderDAO();
            int selectedRow = dataGridViewIntruder.SelectedCells[0].RowIndex;
            long key = Convert.ToInt32(dataGridViewIntruder.Rows[selectedRow].Cells[0].Value);
            DialogResult dr = MessageBox.Show("Delete intruder?", "Delete form",
            MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int polSelectedRow = dataGridViewPoliceman.SelectedCells[0].RowIndex;
                    long polKey = Convert.ToInt32(dataGridViewPoliceman.Rows[polSelectedRow].Cells[0].Value);
                    intruderDAO.Delete(intruderDAO.GetById(key));
                    this.fillDataGridViewIntruder(polKey);
                }
                catch (Exception)
                {
                }
            }
        }

        private void infoPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(getInfoPageString(), "Info form");
        }
        private string getInfoPageString() {

            DAOFactory dao = new NHibernateDAOFactory(session);
            IPolicemanDAO policemanDAO = dao.getPolicemanDAO();
            List<Policeman> policemanList = policemanDAO.GetAll();
            IDepartmentDAO departmentDAO = dao.getDepartmentDAO();
            List<Department> departmentList = departmentDAO.GetAll();
            IIntruderDAO intruderDAO = dao.getIntruderDAO();
            List<Intruder> intruderList = intruderDAO.GetAll();

            string str = "Department details\n";
            string nameMax = "", nameMin = "";
            int maxCountOfPolicemen = int.MinValue, minCountOfPolicemen = int.MaxValue;
            foreach(Department d in departmentList)
            {
                if (d.PolicemenList.Count > maxCountOfPolicemen)
                {
                    nameMax = d.Address + ", " + d.City;
                    maxCountOfPolicemen = d.PolicemenList.Count;
                }
                if(d.PolicemenList.Count < minCountOfPolicemen)
                {
                    nameMin = d.Address + ", " + d.City;
                    minCountOfPolicemen = d.PolicemenList.Count;
                }
            }
            str += " The biggest department " + nameMax + "have " + maxCountOfPolicemen+"\n";
            str += " The smallest department " + nameMin + "have " + minCountOfPolicemen + "\n";
            str += "\nPoliceman details\n";

            int totalAge = 0, maxCountOfIntruders = int.MinValue;
            string name = "";
            foreach (Policeman p in policemanList) {
                totalAge += p.Age;
                if (maxCountOfIntruders < p.IntrudersList.Count)
                {
                    name = p.Rank.Name+" " + p.FirstName + " " + p.LastName;
                    maxCountOfIntruders = p.IntrudersList.Count;
                }
            }
            totalAge /= policemanList.Count;
            str += " Average age of policemen " + totalAge + "\n Most successful policeman: \n " + name + " have " + maxCountOfIntruders + " intruders\n" ;
            str += "\nIntruder details\n";

            int femalesCount = 0, malesCount = 0;
            totalAge = 0;
            foreach (Intruder i in intruderList)
            {
                totalAge += i.Age;
                if (i.Sex.Name == "male")
                    malesCount++;
                else femalesCount++;
            }
            totalAge /= intruderList.Count;
            str += " Average age of intruder " + totalAge + "\n males:  " + malesCount + "\n females " + femalesCount + "\n";
            return str;
        }
    }
}
