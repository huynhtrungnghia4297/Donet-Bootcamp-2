//while

//in ra các số từ 1 đến n với n là số được nhập từ bàn phím
//B1: khởi tạo giá trị lặp
//B2: xác định điều lặp (tính tới trường hợp dừng)
//B3: thay đổi điều kiện lặp
#region 
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// int count = 1; 
// while(count <= formatNumber)
// {
//     Console.WriteLine($"Sô in ra là : {count}");
//     count++;
// }
#endregion

#region 
// Console.WriteLine("Mời bạn nhập số: ");
// string? number =Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// int count = 0;
// int sum = 0;

// while(count <= formatNumber)
// {
//     sum += count;
//     count ++;
// }
// Console.WriteLine($"Tổng là: {sum}");
#endregion

#region 
// Console.WriteLine("Mời bạn nhập số: ");
// string? number =Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// int count = 1;
// int result = 1;

// while(count <= formatNumber)
// {
//     result *= count;
//     count ++;
// }
// Console.WriteLine($"Kết quả là: {result}");
#endregion

#region 
// Console.WriteLine("Mời bạn nhập số bảng cửu chương muốn in: ");
// string? number =Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// int count = 1;
// int result = 1;

// while(count <= 10)
// {
//     result = count * formatNumber;
//     Console.WriteLine($" {count} x {formatNumber} = {result}");

//     count ++;
// }
#endregion


#region 
// Console.WriteLine("Mời bạn nhập số: ");
// string? number =Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// int count = 2;

// while(count < formatNumber)
// {
//     if (formatNumber % count == 0)
//     {
//         Console.WriteLine($" {formatNumber} không phải là số nguyên tố");
//         break;
//     }
//  count ++;
// }
// if(count == formatNumber){
//             Console.WriteLine($" {formatNumber} là số nguyên tố");

// }
#endregion

#region 
Console.WriteLine("Nhập số cột: ");
Console.WriteLine("Nhập số dòng: ");

string? col = Console.ReadLine();
string? row = Console.ReadLine();

int formatcol = Convert.ToInt32(col);
int formatrow = Convert.ToInt32(row);
int count = 0;
for (int i = 0; i < formatrow; i++){
    for (int j = 0; j< formatcol; j++)
    {
        Console.Write("*");       
    }
    Console.Write("\n");
}
#endregion

//j => 2*i+1
//i=0 height - i -1 
//i=1 height = 2 in ra 2 space va 3*
//i=2 height = 3 in ra 1 space va 5*