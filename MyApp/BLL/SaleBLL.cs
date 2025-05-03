using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class SaleBLL : BaseBLL<SaleDTO>
    {
        private SaleDAL saleDAL = new SaleDAL();

        // lấy thông tin bằng Id
        public SaleDTO GetSaleByIdBLL(string idSale)
        {
            return saleDAL.GetSaleById(idSale);
        }

        // xem 
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
                    saleDTO.Id = GenerateAutoId("Sale", "Id", "Sale");
                }
                // gọi hàm DAl để thêm dữ liệu về sale
                saleDAL.AddSale(saleDTO);


            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi khi sinh mã tự động: " + ex.Message);
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
