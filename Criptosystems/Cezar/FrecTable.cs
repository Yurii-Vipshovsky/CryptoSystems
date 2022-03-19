using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cezar
{
    public partial class FrecTable : Form
    {
        public FrecTable(KeyValuePair<string, int>[] data)
        {
            InitializeComponent();
            dataGridView1.DataSource = data;
        }
    }
}
