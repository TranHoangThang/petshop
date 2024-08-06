User_manual_and_demo_Acc

PetShop có 4 chức năng chính:
- 3 chức năng là quản lý thông tin nhân viên "Employee", khách hàng "Customer", thú cưng "Pet's".
- chức năng còn lại là "report" có tổng cộng 4 chức năng phụ.
+ "Billing" lập hóa đơn "invoices" được lưu ở dạng hình ảnh trong bin\Debug\net8.0-windows\Invoices.

+ "Transaction History" lưu trữ những giao dịch được lập trong "billing" của khách hàng khi "search" sễ tìm tất cả các giao dịch và lưu ở dạng hình ảnh trong bin\Debug\net8.0-windows\Transactions.

+ "Sale Report" tìm cũng như in ra excel những giao dịch được tạo ra theo ngày hoặc tháng (mặc định) gồm các các sản phẩm khách hàng mua và sản phẩm được mua bao nhiêu lần bởi khách hàng nào.

+ "Inventory and Service" Quản lý thêm/bớt sản phẩm của shop.

* kèm theo quyền quản lý quyền sử dụng của nhân viên trong "StaffList" chỉ riêng quản lý là được sử dụng, những nhân viên được tạo ra hay thêm vào trong "Employee" chỉ gồm các thông tin cơ bản chỉ có quản lý mới có quyền trao quyền cho những nhân viên đó.

* Thay connection string "Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False" với connection string của máy mở ứng dụng cho các form sau:
> Login.cs

> Employee.cs
> Customer.cs
> Pet.cs

> SalesReport.cs
> Inventory.cs

> Billing.cs
> Transaction.cs

> StaffList.cs
> EditEmployeeForm.cs

<------------->

Tài khoản Manager Demo:

UserName: TQuang
Password: TQuang

Quyền: Toàn quyền

Tài khoản Clerk Demo:

UserName: HThang
Password: HThang

Quyền: Access Employee, Customer, Pet's

Tài khoản Accountant Demo:

UserName: QPhu
Password: QPhu

Quyền: Access Report
