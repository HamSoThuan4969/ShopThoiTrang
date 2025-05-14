using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;
using System.Transactions; // Import TransactionScope

namespace BLL
{
    public class SaleBLL : BaseBLL<SaleDTO>
    {
        private SaleDAL saleDAL = new SaleDAL();
        private Sale_DetailDAL saleDetailDAL = new Sale_DetailDAL();
        // lấy thông tin bằng Id
        public SaleDTO GetSaleByIdBLL(string idSale)
        {
            return saleDAL.GetSaleById(idSale);
        }

        // xem toàn bộ danh sách 
        public List<SaleDTO> GetAllSale()
        {
            return saleDAL.GetAllSale();
        }
        // thêm
        public void AddSale(SaleDTO saleDTO)
        {
            try
            {
                // sinh id tự động 
                if(string.IsNullOrEmpty(saleDTO.Id))
                {
                    saleDTO.Id = GenerateAutoId("Sale", "Id", "SALE");
                }
                
                
                // gọi hàm DAl để thêm dữ liệu về sale
                saleDAL.AddSale(saleDTO);


            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi khi sinh mã tự động: " + ex.Message);
            }
        }
        // thêm sale và sale_detail đồng thời- ap dụng Transaction 
        public void AddSaleAndSaleDetail(SaleDTO saleDTO, Sale_DetailDTO saleDetailDTO)
        {
            try
            {
                // Sinh Id tự động cho Sale
                if (string.IsNullOrEmpty(saleDTO.Id))
                {
                    saleDTO.Id = GenerateAutoId("Sale", "Id", "SALE");
                }

                // Sinh Id tự động cho Sale_Detail và gán IdSale
                if (saleDetailDTO != null)
                {
                    if (string.IsNullOrEmpty(saleDetailDTO.Id))
                    {
                        saleDetailDTO.Id = GenerateAutoId("Sale_Detail", "Id", "SDT");
                    }

                    saleDetailDTO.IdSale = saleDTO.Id; // Gán Id của Sale cho Sale_Detail
                }

                // Sử dụng Transaction để đảm bảo tính toàn vẹn dữ liệu
                using (var transaction = new TransactionScope())
                {
                    // Thêm Sale
                    saleDAL.AddSale(saleDTO);
                    saleDetailDTO.TypeSale = saleDTO.TypeSale; // Gán TypeSale từ SaleDTO sang Sale_DetailDTO

                    // Thêm Sale_Detail (nếu có)
                    if (saleDetailDTO != null)
                    {
                        saleDetailDAL.AddSale_Detail(saleDetailDTO);
                    }

                    transaction.Complete(); // Commit transaction
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm Sale và Sale_Detail: " + ex.Message);
            }
        }
        // Xóa Sale và các Sale_Detail liên quan
        public void DeleteSaleWithDetails(string saleId)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    // Xóa Sale_Detail liên quan trước
                    saleDetailDAL.DeleteByIds("Sale_Detail", "IdSale", new List<string> { saleId});

                    // Xóa Sale
                    saleDAL.DeleteByIds("Sale", "Id", new List<string> { saleId });

                    transaction.Complete(); // Commit transaction
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa Sale: " + ex.Message);
            }
        }
        // update sale và Sale_Detail đồng thời 
        public void UpdateSaleWithDetails(SaleDTO saleDTO, Sale_DetailDTO saleDetailDTO)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    // Cập nhật Sale
                    saleDAL.UpdateSale(new List<SaleDTO> { saleDTO });

                    // Cập nhật Sale_Detail (nếu có)
                    if (saleDetailDTO != null)
                    {
                        saleDetailDAL.UpdateSale_Detail(new List<Sale_DetailDTO> { saleDetailDTO });
                    }


                    transaction.Complete(); // Commit transaction
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật Sale và Sale_Detail: " + ex.Message);
            }
        }
        // xóa
        public void DeleteSale(List<string> ids)
        {
            try
            {
                // gọi hàm DAL để xóa dữ liệu về sale
                saleDAL.DeleteSale(ids);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
        }
        // cập nhật
        public int UpdateSale(List<SaleDTO> sale)
        {
            if (sale== null || sale.Count == 0)
            {
                throw new ArgumentException("Danh sách khách hàng không được để trống.");
            }

            return saleDAL.UpdateSale(sale);
        }


    }



    // Sale_Detail
    public class Sale_DetailBLL : BaseBLL<Sale_DetailDTO>
    {
        private Sale_DetailDAL saleDetailDAL = new Sale_DetailDAL();

        // lấy hết thông Sale_Detail 
        public List<Sale_DetailDTO> GetAllSale_DetailBLL()
        {
            return saleDetailDAL.GetAllSale_Detail();
        }
        // lấy thông tin bằng Id
        public Sale_DetailDTO GetSale_DetailByIdBLL(string idSale_Detail)
        {
            return saleDetailDAL.GetSaleDetailById(idSale_Detail);
        }
        public List<Sale_DetailDTO> GetSale_DetailDAL()
        {
            // gọi hàm 
            return saleDetailDAL.GetAllSale_Detail();
        }

        // thêm sale_detail
        public void AddSale_Detail(Sale_DetailDTO saleDetail)
        {
            try
            {
                // sinh Id tự động 
               
                if (string.IsNullOrEmpty(saleDetail.Id))
                {
                    saleDetail.Id = GenerateAutoId("Sale_Detail", "Id", "SDT");
                }
                // gọi hàm DAL thêm 
                saleDetailDAL.AddSale_Detail(saleDetail);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm khách hàng ở CustomerBLL: {ex.Message}");

            }
        }
        // xóa 
        public void RemoveSale_Detail(List<string> ids)
        {
            try
            {
                DeleteByIds("Sale_Detail", "Id", ids);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa khách hàng ở CustomerBLL: {ex.Message}");
            }
        }
        public int UpdateSale_Detail(List<Sale_DetailDTO> saleDetails)
        {
            if (saleDetails == null || saleDetails.Count == 0)
            {
                throw new ArgumentException("Danh sách khách hàng không được để trống.");
            }

            return saleDetailDAL.UpdateSale_Detail(saleDetails);
        }
       


    }

}
