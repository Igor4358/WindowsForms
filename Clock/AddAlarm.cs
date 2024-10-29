using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AddAlarm : Form
    {
       public Alarm Alarm { get; set; }
        public AddAlarm()
        {
            InitializeComponent();
            Alarm = new Alarm();
        }
        void InitAlarm()
        {
            Alarm.Date = dateTimePickerDate.Value;
            Alarm.Time = dateTimePickerTime.Value;
            Alarm.Filename = labelFilename.Text;
            for (int i = 0; i < checkedListBoxWeek.Items.Count; i++)
            {
                Alarm.Weekdays[i] = (checkedListBoxWeek.Items[i] as CheckBox).Checked;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            InitAlarm();
            this.Close();
        }

        private void checkBoxExactDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked;
        }
    }
}
