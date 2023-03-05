using Sistema2.services;
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

namespace Sistema2
{
    public partial class spicForm : Form
    {
        spicServices spic= new spicServices();

        public spicForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = spic.GetAllSpic();
        }
    }
}
