using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

public class ExcelExporter
{
    public void ExportToExcel<T>(List<T> data, string filePath, string sheetName = "Sheet1")
    {
        try
        {
            using (var package = new ExcelPackage())
            {
                // Tạo một worksheet
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                // Lấy danh sách thuộc tính của đối tượng T
                var properties = typeof(T).GetProperties();

                // Thêm tiêu đề cột (header)
                for (int i = 0; i < properties.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = properties[i].Name; // Tên thuộc tính làm tiêu đề
                }

                // Thêm dữ liệu vào Excel
                for (int row = 0; row < data.Count; row++)
                {
                    for (int col = 0; col < properties.Length; col++)
                    {
                        // Lấy giá trị của thuộc tính
                        var value = properties[col].GetValue(data[row]);
                        worksheet.Cells[row + 2, col + 1].Value = value != null ? value.ToString() : ""; // Tránh lỗi null
                    }
                }

                // Tự động điều chỉnh độ rộng cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file Excel
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Lỗi khi xuất dữ liệu ra Excel: {ex.Message}");
        }
    }
}