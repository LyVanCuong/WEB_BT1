
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
    
2. CONSOLE APP<br>

- Tạo project console app ( .NET Framework 2.0) thêm Reference tới maytinhdongian.dll và sửa lại code trong Program.cs<br>

   <img width="1705" height="770" alt="image" src="https://github.com/user-attachments/assets/e117eecb-9d37-4432-8939-2fe45692e0e4" /><br>
   
- Chuột phải vào project console ---> Set as startup project ---> F5 để chạy console app<br>

- Kết quả:<br>

   <img width="1656" height="850" alt="image" src="https://github.com/user-attachments/assets/f8d4a2b6-2825-4e2e-b954-329fdd2b9c8a" /><br>

3. WINDOWS FORM APP<br>

- Tạo project Windows form app ( .NET Framework 2.0) thêm Reference tới maytinhdongian.dll.<br>

- Có 2 cách để tạo giao diện Design cho windows formm app:<br>

   + Dùng thao tác đồ họa kéo thả các thanh toolbox vào khung<br>
   
   + Dùng code thay thế cho các file .cs để tự động tạo giao diện<br>
   
- Dùng code để xây dựng giao diện cho đề tài máy tính đơn giản:<br>

   + Program.cs:<br>
   
     <img width="1695" height="878" alt="image" src="https://github.com/user-attachments/assets/f2a9c66a-f90b-4ccc-ba11-29cbe720ab9a" /><br>
     
   + Form1.cs:<br>
   
     <img width="1616" height="879" alt="image" src="https://github.com/user-attachments/assets/75402b86-ffd5-470c-b157-9ff3702b2d03" /><br>
     
- Tiếp tục project window form app ---> Set as startup project ---> F5 để chạy window form app<br>

- Kết quả chạy: <br>

   <img width="1362" height="618" alt="image" src="https://github.com/user-attachments/assets/c1fbbe07-eb30-4abc-bb31-bc145407fc34" /><br>
   
4. WEB FORM<br>

- Tạo project ASP.NET Web Application ( .NET Framework 2.0) thêm Reference tới maytinhdongian.dll.<br>

- Từ project này add thêm 1 HTML page đặt tên index.html và 1 item tên api.aspx<br>

- Viết code html, css, js cho file index.html và code-behind cho api.aspx.cs<br>

   <img width="1702" height="639" alt="image" src="https://github.com/user-attachments/assets/b509170f-ce58-48ab-829b-aa5ea926b617" />s<br>
   
   <img width="1669" height="691" alt="image" src="https://github.com/user-attachments/assets/de912a5f-777b-4341-a7ce-dee18108362d" /><br>
   
- Tạo 1 folder và publish Web Form vào folder đó <br>

   <img width="1149" height="509" alt="image" src="https://github.com/user-attachments/assets/af24636c-49be-4767-aca0-c3f66d5b95aa" /><br>

- Deploy IIS + Host:<br>

  + Mở IIS --> Add Website ---> Trỏ đến folder vừa Publish vào<br>
  
  + Hostname: maytinh.com, Port: 80<br>
  
  + Mở nodepad chay quyền admin và mở tệp hosts trong địa chỉ: C:\Windows\System32\drivers\etc\hosts. Thêm dòng "127.0.0.1   maytinh.com" vào cuối tệp và lưu lại.<br>
    
- Kết quả chạy trên localhost với tên miền là maytinh.com:<br>
  
<img width="1892" height="1075" alt="image" src="https://github.com/user-attachments/assets/21f62177-58da-4a0c-bdc4-b278890fe33f" />


   


  

  





   


