# WEB_BT1
# BÀI TẬP VỀ NHÀ 01:
**TẠO SOLUTION GỒM CÁC PROJECT SAU:**
1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis). <br>
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE<br>
3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE<br>
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.<br>

---------------------------------------------------------------------------------------------------------------------------

# Bài làm<br>
 **Tên đề tài: MÁY TÍNH ĐƠN GIẢN**<br>

**CÁC BƯỚC LÀM:<br>
Sử dụng Visual Studio 2022**<br>
1. CLASS LIBRARY<br>
   - Creat a new project ---> Bấm chọn class library (.NET Framework 2.0) và đặt tên: maytinhdongian <br>
   - Sửa lại tên file class1.cs = maytinh.cs và thay code trong đó bằng các input, output, hàm. Nhấn build solution để ra được file maytinhdongian.dll <br>
    <img width="1703" height="884" alt="image" src="https://github.com/user-attachments/assets/95fb1ada-91de-4810-a85c-d61f668ede1b" /><br>
   - Kết quả:<br>
    <img width="1401" height="760" alt="image" src="https://github.com/user-attachments/assets/8552ad5f-b929-4c25-a2c5-06e91270d869" /><br>
4. Tạo project console app ( .NET Framework 2.0) thêm Reference tới maytinhdongian.dll và sửa lại code trong Program.cs<br>
<img width="1705" height="770" alt="image" src="https://github.com/user-attachments/assets/e117eecb-9d37-4432-8939-2fe45692e0e4" /><br>
- Chuột phải vào project console ---> Set as startup project ---> F5 để chạy console app<br>
- Kết quả:<br>
  





   


