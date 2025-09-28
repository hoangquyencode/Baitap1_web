# Baitap1_web
k58ktp - Môn: Phát triển ứng dụng trên nền web
BÀI TẬP VỀ NHÀ 01:
TẠO SOLUTION GỒM CÁC PROJECT SAU:
DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

# BaiLam:

1. Tạo DLL đa năng (Class Library .NET Framework 2.0)

👉 Đây là project trung tâm, chứa thuật toán tính định thức ma trận (determinant).

DLL không có Main().

Chỉ có class + method.

Input: ma trận (double[,])

Output: định thức (double)

<img width="1873" height="973" alt="image" src="https://github.com/user-attachments/assets/edbef538-5731-483d-8467-664f1b3e73fb" />


2. Console App (.NET Framework 2.0)
   
   Sau khi tạo được 2 project ta có bảng:


<img width="1887" height="982" alt="image" src="https://github.com/user-attachments/assets/bd563f22-841b-4cb6-8dbd-a07b7b108832" />


3. Tạo Windows Forms App (.NET Framework 2.0)


  <img width="1114" height="665" alt="image" src="https://github.com/user-attachments/assets/36905f2d-0ebd-4b9f-b265-37875d3931d5" />



4.ASP.NET WebForms App (.NET Framework 2.0)
 Tạo ra các item :


 
  <img width="408" height="319" alt="image" src="https://github.com/user-attachments/assets/e4d40d98-eb89-41ea-99f2-160c9650b994" />



5. Cấu hình IIS cho Project Web
   

<img width="1409" height="715" alt="image" src="https://github.com/user-attachments/assets/0f7555d0-eaec-40fc-801d-55b1365e38f7" />








