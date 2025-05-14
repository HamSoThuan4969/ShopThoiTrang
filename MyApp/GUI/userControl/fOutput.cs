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
using DTO;
using BLL;

namespace GUI.userControl
{
    public partial class fOutput : UserControl
    {
        public OutputBLL outputBLL = new OutputBLL();

        public fOutput()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Tạo một instance mới của UserControlB
            fOutputInfor newItem = new fOutputInfor();

            // Cài đặt chiều rộng bằng với Panel chứa nó
            newItem.Width = pnContainer.Width - 5;
            newItem.Dock = DockStyle.Top; // Để nó tự động xếp chồng lên nhau theo chiều dọc

            // Thêm vào đầu danh sách để xếp từ trên xuống
            pnContainer.Controls.Add(newItem);
            pnContainer.Controls.SetChildIndex(newItem, 0); // Đảm bảo thứ tự thêm vào đầu

        }

        private void btInPut_Click(object sender, EventArgs e)
        {
            //// lấy danh sách được tick ( control fInput_Infor)
            //List<fOutputInfor> selectedItems = new List<fOutputInfor>();
            //foreach (Control control in pnContainer.Controls)
            //{
            //    if (control is fOutputInfor ucb && ucb.checkBoxSelect.Checked)
            //    {
            //        selectedItems.Add(ucb);
            //    }
            //}
            //if (selectedItems.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn ít nhất một hóa đơn để nhập ");
            //    return;
            //}
            //// Tạo Output_Infor đã chọn
            //List<fOutputInfor> outputItems = new List<fOutputInfor>();
            //foreach (var item in selectedItems)
            //{
            //    OutputInforDTO inputInfor = new OutputInforDTO();
            //    {
                    
                    
            //        inputInfor.Quantity = item.Quantity;
                    
            //        inputInfor.Total = item.Total;

            //        inputInfor.IdObject = item.IdObject;
            //        inputInfor.TypeObject = item.TypeObject;
            //        inputInfor.SetObjectId = item.SetObjectId;
            //    }
            //    ;

            //}


        }
    }
}
