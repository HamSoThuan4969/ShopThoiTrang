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
using BLL;

namespace GUI
{
    public partial class UserControlAJob : UserControl
    {
        private RequestSchedulesDTO job;
        private DateTimePicker _dtpDate;

        internal RequestSchedulesDTO Job { get => job; set => job = value; }
        //public UserControlAJob(RequestSchedulesDTO job, DateTimePicker dtpDate)
        //{
        //    InitializeComponent();

        //    this.Job = job;
        //    _dtpDate = dtpDate;

            
        //}

        //TEST
        public UserControlAJob(RequestSchedulesDTO job, DateTimePicker dtp)
        {
            InitializeComponent();

            _dtpDate = dtp; // gán lại nếu bạn dùng chung DateTimePicker để sửa

            cbbRequest.Text = job.Request;
            cbbShift.Text = job.Shift;
            _dtpDate.Value = job.RequestDate;

            
        }


        private void btnAddJob_Click(object sender, EventArgs e)
        {
            RequestSchedulesDTO req = new RequestSchedulesDTO
            {
                Request = cbbRequest.Text,
                Shift = cbbShift.Text,
                RequestDate = _dtpDate.Value,
                Status = "waiting"
            };

            ScheduleBLL bll = new ScheduleBLL();
            bll.CreateRequest(req);

            MessageBox.Show("Lưu thành công!");
        }

    }
}
