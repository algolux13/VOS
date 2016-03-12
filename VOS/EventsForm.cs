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
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        EventMemberForm eventMemberForm;
        PositionForm positionForm;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addEventMemberButton_Click(object sender, EventArgs e)
        {
            if (eventMemberForm == null || eventMemberForm.IsDisposed)
            {
                eventMemberForm = new EventMemberForm();
                eventMemberForm.Show();
            }
            else
            {
                eventMemberForm.Activate();
            }
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            if (positionForm == null || positionForm.IsDisposed)
            {
                positionForm = new PositionForm();
                positionForm.Show();
            }
            else
            {
                positionForm.Activate();
            }
        }
    }
}
