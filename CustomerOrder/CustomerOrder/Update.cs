using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerOrder
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            input_Updates.Text = "";
            //get update data
            for(int i = 0; i < Updates.NumberOfUpdates; i++)
            {
                input_Updates.Text += "["+Updates.Users[i] + "]: " + Updates.UpdateInputs[i] + Environment.NewLine + Environment.NewLine;
            }
        }

        private void input_Updates_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
