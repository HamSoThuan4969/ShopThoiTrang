using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaseBLL<T> where T : class
    {
        private BaseDAL baseDAL = new BaseDAL();

        // sinh Id tự động
        public string GenerateAutoId(string tableName, string columnName, string prefix)
        {
            try
            {
                // lấy Id lớn nhất từ baseDAL
                string maxId = baseDAL.GetMaxID(tableName, columnName, prefix);

                // nếu chưa có Id nào thì , trả về Id đầu tiền 001
                if (string.IsNullOrEmpty(maxId))
                {
                    return $"{prefix}001";
                }
                // ép MaxId và prefix về dạng In hoa để tiện sử lý so sánh và trùng trong csdl.
                string upperMaxId = maxId.ToUpper();
                string upperPrefix = prefix.ToUpper();

                // Tách phần số từ Id lớn nhất 
                string numberPart = upperMaxId.Substring(upperPrefix.Length);
                if(!int.TryParse(numberPart, out int currentNumber))
                {
                    throw new Exception("Không thể phân tích số của Id");
                }
                // tăng số của Id và tạo ra Id mới
                int newNumber = currentNumber + 1;  
                return $"{upperPrefix}{newNumber:D3}";
            }catch(Exception ex)
            {
                throw new Exception($"Lỗi khi tự động sinh Id cho bảng {tableName}: {ex.Message}");
            }
        }
        public virtual void  DeleteByIds(string tableName, string columnName, List<string> ids)
        {
            if(ids== null || ids.Count == 0)
            {
                throw new ArgumentException("Danh sách Id không được null hoặc rỗng");
            }
            try
            {
                baseDAL.DeleteByIds(tableName, columnName, ids);

            }
            catch(Exception ex)
            {
                throw new Exception($"Lỗi khi xóa Id trong bảng  {tableName}: {ex.Message} Tầng baseBLL");
            }
        }
        // phương thức cập nhật dữ liệu - Update
       

    }
}
