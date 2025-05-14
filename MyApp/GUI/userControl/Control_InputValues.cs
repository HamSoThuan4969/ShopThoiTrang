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
using System.ComponentModel.Design;


namespace GUI.userControl
{

    public partial class Control_InputValues : UserControl
    {
        private InputInforBLL inputInforBLL = new InputInforBLL();
        private SupplierBLL supplierBLL = new SupplierBLL();
        private SetObjectBLL setObjectBLL = new SetObjectBLL();
        private ObjectBLL objects = new ObjectBLL();
        public Control_InputValues()
        {
            InitializeComponent();
            LoadList();
            AddCheckboxColumn();
            InitializeComboBox();
            // Đăng ký sự kiện CellClick cho DataGridView
            dataGridView_InputInfor.CellClick += DataGridView_InputInfor_CellClick;


        }
        private void LoadList()
        {
            try
            {
                List<InputInforDTO> inputInfor = inputInforBLL.GetActiveInputInfor();
                dataGridView_InputInfor.DataSource = inputInfor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khách hàng: {ex.Message}");
            }
        }
        private void AddCheckboxColumn()
        {
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "Chọn",
                Width = 50

            };
            dataGridView_InputInfor.Columns.Insert(0, checkboxColumn);
        }
        private void InitializeComboBox()
        {
            try
            {
                // Gọi BLL để lấy dữ liệu từ cơ sở dữ liệu
                List<SetObjectDTO> setObjects = setObjectBLL.GetSetObject(); // Lấy toàn bộ dữ liệu nhà cung cấp

                // Chuyển danh sách nhà cung cấp thành DataTable hoặc danh sách đối tượng
                DataTable comboBoxData = new DataTable();
                comboBoxData.Columns.Add("DisplayName", typeof(string)); // Cột hiển thị
                comboBoxData.Columns.Add("Id", typeof(string)); // Cột giá trị (ẩn)

                foreach (var setObject in setObjects)
                {
                    comboBoxData.Rows.Add(setObject.DisplayName, setObject.Id); // Thêm dữ liệu
                }

                // Gắn dữ liệu vào ComboBox
                cbbIdSet.DataSource = comboBoxData;
                cbbIdSet.DisplayMember = "DisplayName"; // Hiển thị cột TypeObject
                cbbIdSet.ValueMember = "Id"; // Giá trị sẽ là cột Id
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu vào ComboBox: {ex.Message}");
            }
        }
        private void DataGridView_InputInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_InputInfor.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView_InputInfor.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ dòng đã chọn vào các TextBox
                tbId_InputInfor.Text = selectedRow.Cells["Id"].Value.ToString();
                tbDisplayName.Text = selectedRow.Cells["DisplayName_Object"].Value.ToString();
                tbInputPrice.Text = selectedRow.Cells["InputPrice"].Value.ToString();
                nbRQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                tbOutputPrice.Text = selectedRow.Cells["OutputPrice"].Value.ToString();
                tbIdInput.Text = selectedRow.Cells["IdInput"].Value.ToString();
                tbActive.Text = selectedRow.Cells["Active"].Value.ToString();
                tbIdSupplier.Text = selectedRow.Cells["IdSupplier"].Value.ToString();


            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy giá trị từ comboBox
                string selectedH = cbbIdSet.Text; // Giá trị hiển thị
                string selectedValueIsSet = cbbIdSet.SelectedValue.ToString();
                string idInputInfor = tbId_InputInfor.Text;
                // tạo một đối tượng Object mới 
                ObjectDTO objectDTO = new ObjectDTO
                {
                    
                    DisplayName = tbDisplayName.Text,
                    InputPrice = int.Parse(tbInputPrice.Text),
                    Quantity = int.Parse(nbRQuantity.Text),
                    IdSet = selectedValueIsSet,
                    OutputPrice = int.Parse(tbOutputPrice.Text),
                    IdInputInfor = tbIdInput.Text,
                    IdSupplier = tbIdSupplier.Text,



                };
                // gọi hàm thêm vào BLL
                objects.AddObject(objectDTO);
                inputInforBLL.UpdateColumns(idInputInfor, "0");
                LoadList();
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }

        private void Control_InputValues_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
