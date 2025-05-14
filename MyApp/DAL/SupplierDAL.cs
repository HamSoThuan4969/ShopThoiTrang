using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class SupplierDAL:BaseDAL
    { 
        private DataProvider dataProvider = new DataProvider();
        public List<SupplierDTO> GetAllSupplier()
        {
            string query = "SELECT * FROM Supplier";
            return dataProvider.ExecuteQuery<SupplierDTO>(query);
        }

        // lấy thông tin của Supplier bằng Id
        public SupplierDTO GetSupplierById(string idSupplier)
        {
            return GetById<SupplierDTO>("Supplier", "Id", idSupplier);
        }
        // thêm thông tin Supplier
        public void AddSupplier(SupplierDTO supplier)
        {
            string query = "INSERT INTO Supplier (Id, DisplayName, Address, Email, Phone, TypeObject, MoreInfor, ContractDate, Abbreviation ) " +
                "VALUES (@Id, @DisplayName, @Address, @Email, @Phone, @TypeObject, @MoreInfor, @ContractDate, @Abbreviation)";
            var parameters = new object[]
            {
                supplier.Id,
                supplier.DisplayName,
                supplier.Address,
                supplier.Email,
                supplier.Phone,
                supplier.TypeObject,
                supplier.MoreInfor,
                supplier.ContractDate,
                supplier.Abbreviation


            };
            dataProvider.ExecuteNonQuery(query, parameters);
        }
        // xóa thông tin Supplier
        public int DeleteSupplier(List<string> ids)
        {
            return DeleteByIds("Supplier", "Id", ids);
        }
        // cập nhật thông tin Supplier
        public int UpdateSupplier(List<SupplierDTO> suppliers)
        {
            return Update("Supplier", "Id", suppliers, (command, suppliers) =>
            {
                command.Parameters.AddWithValue("@Id", suppliers.Id);
                command.Parameters.AddWithValue("@DisplayName", suppliers.DisplayName);
                command.Parameters.AddWithValue("@Address", suppliers.Address);
                command.Parameters.AddWithValue("@Email", suppliers.Email);
                command.Parameters.AddWithValue("@Phone", suppliers.Phone);
                command.Parameters.AddWithValue("@TypeObject", suppliers.TypeObject);
                command.Parameters.AddWithValue("@MoreInfor", suppliers.MoreInfor);
                command.Parameters.AddWithValue("@ContractDate", suppliers.ContractDate);
                command.Parameters.AddWithValue("@Abbreviation", suppliers.Abbreviation);
            });
        }

    }
}
