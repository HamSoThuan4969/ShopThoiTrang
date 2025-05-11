using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fStepJob2 : Form
    {

        private DateTime date;
        private List<RequestSchedulesDTO> _job;

        public DateTime Date { get => date; set => date = value; }
        public List<RequestSchedulesDTO> Job { get => _job; set => _job = value; }


        public fStepJob2(DateTime selectedDate, List<RequestSchedulesDTO> jobs)
        {
            InitializeComponent();
            date = selectedDate;
            _job = jobs;

            LoadJobs();
        }

        private void LoadJobs()
        {
            // Lọc danh sách theo ngày, ví dụ:
            var jobsInDay = _job.Where(j => j.RequestDate.Date == date.Date).ToList();

            foreach (var job in jobsInDay)
            {
                var uc = new UserControlAJob(job, dtpDate);
                pnJob.Controls.Add(uc);
            }
        }

        //public fStepJob2(DateTime date, List<RequestSchedulesDTO> jobs)
        //{
        //    InitializeComponent();

        //    this.Date = date;
        //    _job = jobs;

        //    FlowLayoutPanel fPanel = new FlowLayoutPanel();
        //    pnJob.Controls.Add(fPanel);


        //    if (Job != null && Job. != null)
        //    {
        //        for (int i=0; i<Job.Job.Count; i++)
        //        {
        //            UserControlAJob aJob = new UserControlAJob(Job.Job[i], dtpDate);
        //            fPanel.Controls.Add(aJob);
        //        }
        //    }

        //    dtpDate.Value = Date;


        //}

        private void fStepJob2_Load(object sender, EventArgs e)
        {
            ShowJobByDate(dtpDate.Value);
        }

        void ShowJobByDate(DateTime date)
        {

            FlowLayoutPanel fPanel = new FlowLayoutPanel();
            fPanel.Width = pnJob.Width;
            fPanel.Height = pnJob.Height;
            fPanel.Dock = DockStyle.Fill;
            fPanel.AutoScroll = true;
            pnJob.Controls.Add(fPanel);

            ScheduleBLL bll = new ScheduleBLL();
            var jobList = bll.GetByDate(date);  // 👈 Lấy từ CSDL

            if (jobList != null && jobList.Any())
            {
                foreach (var job in jobList)
                {
                    var aJob = new UserControlAJob(job, dtpDate);
                    fPanel.Controls.Add(aJob);
                }
            }
            else
            {
                MessageBox.Show("Không có công việc nào cho ngày này.");
            }
        }

        //List<RequestSchedulesDTO> GetJobByDay(DateTime date)
        //{
        //    //return Jon.Job.Where()
        //}




        private void dtpDate_VisibleChanged(object sender, EventArgs e)
        {
            //ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void fStepJob2_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate(dtpDate.Value);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(1);
        }
    }
}
