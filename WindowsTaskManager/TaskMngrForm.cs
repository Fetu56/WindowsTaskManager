using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTaskManager
{
    public partial class TaskMngrForm : Form
    {
        public TaskMngrForm()
        {
            InitializeComponent();
            refreshBtn.Click += RefreshBtn_Click;
            ProcessKillBtn.Click += ProcessKillBtn_Click;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void ProcessKillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                    Process.GetProcessesByName((string)dataGridView1.SelectedRows[0].Cells[0].Value).ToList().ForEach(x => x.Kill());
            }
            catch(Exception ex)
            {}
            
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            List<CheckBox> boxes = new List<CheckBox>();
            List<TaskProcess> tasks = Process.GetProcesses().ToList().ConvertAll<TaskProcess>(x => new TaskProcess(x));
            
            dataGridView1.DataSource = tasks;

            GC.Collect();
        }

    }
}
