using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1: UserControl
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void dbtestBtn_Click(object sender, EventArgs e)
        {
            var result = await SampleDB.ExecuteQuery();
            await Task.Yield();
            MessageBox.Show(result);
        }
    }
}
