//Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
//Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
// __*
// _* *
// __*   *
// _*     *
// *******

//Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
//Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");


//Bài 1:
#region 

// Console.WriteLine("Mời bạn nhập số: ");
//     int number = Convert.ToInt32(Console.ReadLine());



//     for(int i = 2; i<= number;i++)
//     {
//         bool istrue = true;
//         for(int j = 2; j<= Math.Sqrt(i); j++)
//         {
//             if (i % j == 0)
//             {
//                 istrue = false;
//                 break;
//             }
//         }

//         if(istrue == true)
//         {
//         Console.Write($" {i} ");

//         }

//     }
#endregion

#region 
// Console.WriteLine("Mời bạn nhập số: ");

//     string? number_2 = Console.ReadLine();
//     int idx = number_2.Length-1;
//     int idx_left = 0;
//     bool istrue=false;

//     while(idx_left < idx)
//     {
//         if (number_2[idx_left] != number_2[idx])
//         {
//             istrue = false;
//             break;
//         }
//         else{
//             istrue =true;
//         }

//     idx_left ++;
//     idx --;
//     }


//     if (istrue==true)
//     {
//         Console.WriteLine("đây là số đối xứng");
//     }
//     else
//     {
//         Console.WriteLine("đây không phải là số đối xứng");
//     }
#endregion

internal class Program
{
    private static void Main(string[] args)
    {
       int ketQua =  tinhTong(1,2);
       Console.WriteLine ($"{ketQua}");


    Console.WriteLine("Mời bạn nhập số: ");
    int number = Convert.ToInt32(Console.ReadLine());



    for(int i = 2; i<= number;i++)
    {
        bool istrue_2 = isPrime(i);
        if(istrue_2 == true)
        {
        Console.Write($" {i} ");

        }

    }

        Console.WriteLine("Mời bạn nhập một số: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        bool istrue = outPut(number3);
        if (!istrue)
        {
            Console.WriteLine("Đây không phải số nghịch đảo");
        }
        else
        {
            Console.WriteLine("Đây là số nghịch đảo");

        }

        
        
       
    }

    private static bool outPut (int number)
    {
        int originalNumber = number;
        int reverseNumber = 0;
        while(number > 0){
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        if (reverseNumber == originalNumber){
            return true;
        } else {
            return false;
        }
    }
    private static bool isPrime (int number){
        if (number<2)
        {return false;}
        for (int count = 2; count <= Math.Sqrt(number); count++)
        {
            if (number % count == 0)
            {
                return false;
            }
        }
        return true;
    }
    private static int tinhTong (int number1, int number2)
    {
        return number1 + number2;
    }

}