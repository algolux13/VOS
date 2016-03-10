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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        FamilyMemberForm familyMemberForm;
        AidForm aidForm;
        HonorsForm honorForm;
        IPRForm iprForm;
        ShVTSForm shvtsForm;
        ContribForm contribForm;

        private void button3_Click(object sender, EventArgs e)
        {
            if (familyMemberForm == null || familyMemberForm.IsDisposed)
            {
                familyMemberForm = new FamilyMemberForm();
                familyMemberForm.Show();
            }
            else
            {
                familyMemberForm.Activate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (aidForm == null || aidForm.IsDisposed)
            {
                aidForm = new AidForm();
                aidForm.Show();
            }
            else
            {
                aidForm.Activate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (honorForm == null || honorForm.IsDisposed)
            {
                honorForm = new HonorsForm();
                honorForm.Show();
            }
            else
            {
                honorForm.Activate();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (iprForm == null || iprForm.IsDisposed)
            {
                iprForm = new IPRForm();
                iprForm.Show();
            }
            else
            {
                iprForm.Activate();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (shvtsForm == null || shvtsForm.IsDisposed)
            {
                shvtsForm = new ShVTSForm();
                shvtsForm.Show();
            }
            else
            {
                shvtsForm.Activate();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (contribForm == null || contribForm.IsDisposed)
            {
                contribForm = new ContribForm();
                contribForm.Show();
            }
            else
            {
                contribForm.Activate();
            }
        }
    }
}
