// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Học toán tử cơ bản

// //học cộng (+) trừ (-) nhân(*) chia(/), (%)chia phần nguyên,chia phần dư
// //khai báo biến
// int add = 5+10;
// Console.WriteLine($"Kết quả của biến add là: {add}");

// int minus = 100 - 50;
// Console.WriteLine($"Kết quả của biến minus là: {minus}");

// int A = 100 * 50;
// Console.WriteLine($"Kết quả của biến A là: {A}");

// double B = 5 / 2;
// Console.WriteLine($"Kết quả của biến B là: {B}");


// double C = 100 % 21;
// Console.WriteLine($"Kết quả của biến C là: {C}");
#endregion

#region numberic toán tử
    // int cong = 0;//định nghĩa biến cộng có giá trị mặc định là 0
    // cong += 10;
    // Console.WriteLine($"Numberic toán tử cộng: {cong}");

    // int nhan = 1;
    // nhan *=100;
    // Console.WriteLine($"Numberic toán tử nhân: {nhan}");
#endregion

#region ép kiểu dữ liệu
// //Convert
// //nhập dữ liệu từ bàn phím => Readline (string
// string number = Console.ReadLine();
// int convertNumber = Convert.ToInt32(number);
// Console.WriteLine($"value number: {convertNumber}");
#endregion

#region tính chỉ số BMI
//Input
// chiều cao và cân nặng nhập từ bàn phím
// Console.WriteLine("Mời bạn nhập chiều cao (m):");
// string? chieuCao = Console.ReadLine();

// double formatChieucao= Convert.ToDouble(chieuCao);

// Console.WriteLine("Mời bạn nhập cân nặng (kg)");
// string? canNang = Console.ReadLine();
// double formatCannang= Convert.ToDouble(canNang);


// //Output
// //in ra chỉ số BMI

// double? bmi = 0.0;

// //Process
// //BMI = (cân nặng) / chiều cao)*(chiều cao)
// bmi = formatCannang / (formatChieucao * formatChieucao);
// Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");

#endregion

#region 
Console.WriteLine("Nhập bán kính hình tròn:");
string? banKinh = Console.ReadLine();

double formatBanKinh= Convert.ToDouble(banKinh);


//Output
//in ra chỉ số BMI

double? chuvi = 0.0;
double? dientich = 0.0;


//Process
//BMI = (cân nặng) / chiều cao)*(chiều cao)
double Pi = Math.PI; 
chuvi = 2 * Pi * formatBanKinh;
dientich = Pi * (chuvi * chuvi);
Console.WriteLine($"Chu vi hình tròn là: {chuvi}");
Console.WriteLine($"Diện tích hình tròn là: {dientich}");

#endregion
