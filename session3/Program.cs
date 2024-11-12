//If - else Stament

#region 
// nhập số nguyên từ bàn phím. In ra số đó là số lẻ hay số chẳn
//Input
// Console.WriteLine("Mời bạn nhập số:");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);

// if (formatNumber %2 == 0)
// {
//     Console.WriteLine("Số chẵn");
// }
// else
// {
//     Console.WriteLine("Số lẻ");
// }
//Output

//Process
#endregion


//Nhập điểm trung bình của học sinh

#region 
// Console.WriteLine("Nhập số điểm của học viên:");
// string? core = Console.ReadLine();
// double formatCore = Convert.ToDouble(core);
// if(formatCore >= 9)
// {
//     Console.WriteLine("Xuất sắc");
// }
// else if (formatCore >= 8 && formatCore<9)
// {
//     Console.WriteLine("Giỏi");
// }
// else if (formatCore >= 6.5 && formatCore<8)
// {
//     Console.WriteLine("Giỏi");

// }
// else if (formatCore >= 5 && formatCore<6.5)
// {
//     Console.WriteLine("Trung bình");

// }else if (formatCore >= 3.5 && formatCore<5)
// {
//     Console.WriteLine("Yếu");

// }else 
// {
//     Console.WriteLine("Quá kém");

// }
#endregion

#region 
// using System.Diagnostics.CodeAnalysis;

// Console.WriteLine("Nhập số có 3 chữ số:");
// string? num = Console.ReadLine();
// int formatNumber = Convert.ToInt32(num);
// int sum = 0;
// int sohangtram = 0;
// int sohangchuc = 0;
// int sohangdonvi = 0;
// if(formatNumber >=1000 || formatNumber < 100)
// {
//     Console.WriteLine("Không hợp lệ");
// }
// else {

//     sohangtram = formatNumber / 100;
//     sohangchuc  = (formatNumber % 100)/10;
//     sohangdonvi = (formatNumber % 100)%10;
//     sum = sohangtram +sohangchuc+sohangdonvi;
//     // Console.WriteLine("Bạn nhập đúng");
//     //  sum = num.ToString().ToCharArray()
//     //                      .Select(c => int.Parse(c.ToString()))
//     //                      .Sum();

//     Console.WriteLine($"Kết quả tổng 3 số là: {sum}");
// }
#endregion
//Bài tập
//nhập ngày (dd/mm/yyyy). In ra thứ mấy trong tuần
// VD: 23/10/2024 => thứ tư
// Lưu ý: không dùng thư viện


//switch..case
//nhập số có trong khoảng từ 1 đến 10, đọc ra
#region 
string? number2 = Console.ReadLine();
int formatNumber2 = Convert.ToInt32(number2);
switch(formatNumber2)
{
    case 1:
        Console.WriteLine("Số 1");
        break;
     case 2:
        Console.WriteLine("Số 2");
        break;
     case 3:
        Console.WriteLine("Số 3");
        break;
    case 4:
        Console.WriteLine("Số 4");
        break;
    case 5:
        Console.WriteLine("Số 5");
        break;
    case 6:
        Console.WriteLine("Số 6");
        break;
    case 7:
        Console.WriteLine("Số 7");
        break;
    case 8:
        Console.WriteLine("Số 8");
        break;
    case 9:
        Console.WriteLine("Số 9");
        break;
    default:
            Console.WriteLine("Số 10");
            break;
}
#endregion






