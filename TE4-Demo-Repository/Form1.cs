using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TE4_Demo_Repository.DomainModel.Abstract;
using TE4_Demo_Repository.DomainModel.Concrete;

namespace TE4_Demo_Repository
{
    public partial class Form1 : Form
    {
        private IRepository _repo;

        public Form1()
        {
            InitializeComponent();

            button1.Text = "Open Add Car";
            button1.Click += new EventHandler(AddCar);

            //visa en lista med bilar
            _repo = new Repository();
            listBox1.DataSource = _repo.Cars;
        }

        private void AddCar(object sender, EventArgs e)
        {
            AddCar frmAddCar = new AddCar();
            frmAddCar.ShowDialog();
        }
    }
}
