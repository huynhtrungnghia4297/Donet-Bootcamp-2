internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region function trong List của Collection
        //khởi tạo một danh sách
        // List<int> numbers = new List<int>();
        // // nhập n từ bàn phím vs n là số phần tử của mảng
        // string? n = Console.ReadLine();
        // int format = Convert.ToInt32(n);

        // for (int i = 0 ; i < format; i++)
        // {
        //     Console.WriteLine($"Mời bạn nhập số thứ {i+1}");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        // }

        // Console.WriteLine("Danh sách phần tử đã nhập là: ");
        // foreach (int  number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
        //     numbers.Sort();
        //     Console.WriteLine("Danh sách phần tử đã nhập là: ");
        //     Console.WriteLine(numbers);


        // // dùng reverse
        //     numbers.Reverse();
        //     Console.WriteLine("Danh sách phần tử đã nhập là: ");
        //     Console.Write(String.Join(",", numbers));
        #endregion

        #region Bài 1 tính tổng các số lớn hơn 50
            //khai báo list phần tử
            // List<int> numbers = new List<int>{20,50,31,75,20,65,20,100,11,66,68,86};
            // int sum = Bai1.tinhTongSoLon50(numbers);
            // Console.WriteLine($"Kết quả là {sum}: ");
        #endregion

        #region Bài 2 tính tổng các số lớn hơn 50
            //khai báo list phần tử
            // List<int> numbers = new List<int>{20,50,31,75,20,65,20,100,11,66,68,86,78,12};
            // int result = Bai1.timSoLonNhat(numbers);
            // Console.WriteLine($"Kết quả là {result}: ");
        #endregion


        #region 
        // List<string> fruits = new List<string> {"apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"};
        // List<string> result2 = Bai1.timChuBatDauBangChuM(fruits);
        //    foreach(string result in result2)
        //    {
        //     Console.WriteLine($"Kết quả là {result}: ");

        //    }
        #endregion


        #region 
        // List<int> fruits = new List<int> {1,1,2,2,2,3,4,4,5};
        // List<int> result2 = Bai1.xoaTrung(fruits);
        //    foreach(int result in result2)
        //    {
        //     Console.WriteLine($"Kết quả là {result}: ");

        //    }
        #endregion

        #region 
        Dictionary<string,string> dic = new Dictionary<string, string>();
        dic.Add("Alice","test");
        dic["Do"] = "Nam Trung";

        foreach(KeyValuePair<string,string> pointer in dic){
            //pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }

        // chỉ duyệt key hoặc value
        foreach(string str in dic.Keys){
            Console.WriteLine(str);
        }

        //uppdate 
        dic["Alice"] = "Johnson";
        foreach(KeyValuePair<string,string> pointer in dic){
            //pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }
        //delete
        dic.Remove("Alice");
         foreach(KeyValuePair<string,string> pointer in dic){
            //pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }
        #endregion

    }
}