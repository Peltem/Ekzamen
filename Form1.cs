using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekz_3
{
    public partial class Form1 : Form
    {
        private Dannie dannie;
        public Form1()
        {
            InitializeComponent();
            dannie = new Dannie();
            dannie.Initialize();
            DataBase.DataSource = dannie.Base;
            
            
        }

        private void Poisk_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Poisk.Text)) { DataBase.DataSource = dannie.Base; return; }
                DataBase.DataSource = dannie.Base
                    .Where(t => t.recept.ToLower().Contains(Poisk.Text.ToLower()))
                    .ToList();
            }
        }
    }

