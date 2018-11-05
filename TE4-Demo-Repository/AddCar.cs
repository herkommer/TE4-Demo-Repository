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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();

            button1.Text = "Add Car";
            button1.Click += new EventHandler(SaveCar);
        }

        private void SaveCar(object sender, EventArgs e)
        {
            IRepository repo = new Repository();
            repo.Add(new Car()
            {
                Make=textBox1.Text,
                Model = textBox2.Text,
                Color = textBox3.Text,
                Milage = int.Parse(textBox4.Text)

            });

            this.Close();
        }
    }
}
