using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class fStepJob : Form
    {
        public List<RequestSchedulesDTO> Job { get; set; }
        #region Properties
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dateOfWeek = new List<string>()
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        #endregion 
        public fStepJob()
        {
            InitializeComponent();

            LoadMatrixJob();

            ScheduleBLL bll = new ScheduleBLL();
            Job = bll.GetAll();  // hoặc bll.GetByMonth(DateTime.Now) nếu muốn lọc theo tháng
        }

        void LoadMatrixJob()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };

            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() 
                    {
                        Width = Cons.dateButtonWidth,
                        Height = Cons.dateButtonHeight
                    };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin,
                                             oldBtn.Location.Y);

                    btn.Click += btn_Click;
                    pnMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }

                // Không khai báo lại oldBtn, chỉ gán lại
                oldBtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight)
                };

            }
            SetDefaultDate();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;

            fStepJob2 SJob2 =
                new fStepJob2(new DateTime(dtpkJob.Value.Year, dtpkJob.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            SJob2.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }

        void AddNumbeIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++) 
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if(isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.LightGoldenrodYellow;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aquamarine;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        //Lưu job lại
        private PlanData job;

        bool isEqualDate(DateTime dateA, DateTime dateB) 
        { 
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        private void fStepJob_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkJob.Value = dtpkJob.Value.AddMonths(1);
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for(int j=0; j< Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text =  "";
                    btn.BackColor = Color.White;
                }
            }
        }

        void SetDefaultDate()
        {
            dtpkJob.Value = DateTime.Now;
        }

        private void dtpkJob_ValueChanged(object sender, EventArgs e)
        {
            AddNumbeIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            dtpkJob.Value = dtpkJob.Value.AddMonths(-1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }
    }
}
