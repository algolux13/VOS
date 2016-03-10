using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MemberForm memberForm;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (memberForm == null || memberForm.IsDisposed)
            {
                memberForm = new MemberForm();
                memberForm.Show();
            }
            else
            {
                memberForm.Activate();
            }
        }
    }
}
