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
    public partial class fInput : UserControl
    {
        public InputBLL inputBLL = new InputBLL();
        public SupplierBLL supplierBLL = new SupplierBLL();
        public fInput()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Tạo một instance mới của UserControlB
            fInput_Infor newItem = new fInput_Infor();

            // Cài đặt chiều rộng bằng với Panel chứa nó
            newItem.Width = pnContainer_Input.Width-5;
            newItem.Dock = DockStyle.Top; // Để nó tự động xếp chồng lên nhau theo chiều dọc

            // Thêm vào đầu danh sách để xếp từ trên xuống
            pnContainer_Input.Controls.Add(newItem);
            pnContainer_Input.Controls.SetChildIndex(newItem, 0); // Đảm bảo thứ tự thêm vào đầu
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Tạo danh sách tạm để tránh lỗi khi xóa trong vòng lặp
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in pnContainer_Input.Controls)
            {
                if (control is fInput_Infor)
                {
                    fInput_Infor ucb = (fInput_Infor)control;
                    if (ucb.checkBoxSelect.Checked)
                    {
                        controlsToRemove.Add(ucb);
                    }
                }
            }

            // Xóa các user control đã chọn
            foreach (Control control in controlsToRemove)
            {
                pnContainer_Input.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy danh sách được tick ( control fInput_Infor)
                List<fInput_Infor> selectedItems = new List<fInput_Infor>();
                foreach (Control control in pnContainer_Input.Controls)
                {
                    if(control is fInput_Infor ucb && ucb.checkBoxSelect.Checked)
                    {
                        selectedItems.Add(ucb);
                    }
                }
                if (selectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một hóa đơn để nhập ");
                    return;
                }
                // tạo danh sách InputInfor từ các UserControl đã chọn nè
                List<InputInforDTO> inputInforList = new List<InputInforDTO>();
                foreach (var control in selectedItems)
                {
                    // Lấy giá trị từ ComboBox
                    //string selectedTypeObject = control.IdSupplier; // Giá trị hiển thị
                    //string selectedId = cbbTypeObject.SelectedValue.ToString(); // Giá trị ẩn (Id)


                    InputInforDTO inputInfor = new InputInforDTO()
                    {

                        DisplayName_Object = control.DisplayName_Object,
                        Quantity = control.Quantity,
                        InputPrice = control.InputPrice,
                        OutputPrice = control.OutputPrice,
                        IdSupplier = control.IdSupplier,

                    };
                    inputInforList.Add(inputInfor);

                }
                // Gọi BLL để thêm Input và InputInfor 
                inputBLL.AddInputAndInput_Infor(inputInforList);
                MessageBox.Show("Thêm hóa đơn thành công");

                // xóa những hóa đơn thành công 
                // Xóa các control đã được tick sau khi thêm thành công
                foreach (var control in selectedItems)
                {
                    pnContainer_Input.Controls.Remove(control);
                    control.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn GUI: " + ex.Message);
            }
        }
    }
}
