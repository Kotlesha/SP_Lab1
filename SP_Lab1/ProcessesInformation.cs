using System.Diagnostics;

namespace SP_Lab1
{
    public partial class ProcessesInformation : Form
    {
        private Process[] processes;
        public ProcessesInformation()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            ProcessesTable.Rows.Clear();
            processes = Process.GetProcesses();
            ProcessesCount.Text = processes.Length.ToString();

            foreach (Process process in processes)
            {
                ProcessesTable.Rows.Add(
                    process.Id,
                    process.ProcessName,
                    Math.Round(process.PagedMemorySize64 / Math.Pow(1024.0, 2), 2),
                    GetUserName(process),
                    process.BasePriority);
            }
        }

        private void Update_Click(object sender, EventArgs e) => Fill();

        private void ProcessesTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ThreadsTable.Rows.Clear();
            Process process = processes[e.RowIndex];
            ThreadsCount.Text = process.Threads.Count.ToString();

            foreach (ProcessThread thread in process.Threads)
            {
                ThreadsTable.Rows.Add(thread.Id, thread.CurrentPriority);
            }
        }

        private string GetUserName(Process process) => process.SessionId == 0 ? "яхярелю" : Environment.UserName;
    }
}