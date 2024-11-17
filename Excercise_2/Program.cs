

while (true)
    {
    Console.WriteLine("Nhập vào số bài tập:");
    string? numberExcercise = Console.ReadLine();
    if (numberExcercise == "exit")
        {
            Console.WriteLine("Kết thúc chương trình.");
            break;
        }
    switch(numberExcercise)
    {
        case "1":
                int[] IstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20];               
                int Sum = 0;
                for (int i = 0; i < IstNumber.Length; i++)
                {
                    Sum += IstNumber[i];
                }
                Console.WriteLine($"Tổng của mảng là : {Sum}");
        break;

        case "2":
        Console.WriteLine("Nhập vào target cần xuất: ");
            int[] nums = [2,7,11,15];
            int target = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< nums.Length ; i++)
            {   
                for (int j = i+1; j<nums.Length; j++)   
                {
                    if (nums[i]+ nums[j] == target)
                    {
                        nums[0] = i;
                        nums[1] = j;    
                        Console.WriteLine("nums[0]: " + nums[0]);
                        Console.WriteLine("nums[1]: " + nums[1]);
                        return;
                    }
                }
            }
        break;

        case "3":
            int[] IstNumber_3 = [1, 1, 2, 2, 2, 3, 4, 4, 5]; 
            List<int> newList = new List<int>();
            
            newList.Add(IstNumber_3[0]);

            for (int i = 1; i<IstNumber_3.Length; i++)
            {
                if (newList.Contains(IstNumber_3[i]))
                {
                    continue;
                }
                else
                {
                    newList.Add(IstNumber_3[i]);
                }
            }
             Console.WriteLine($"Mảng mới là: {string.Join(", ", newList)}");
        break;


        case "4":

            int[] IstNumber_4 = [1, 1, 1, 1, 2, 2, 3]; 
            Dictionary<int, int> counts = new Dictionary<int, int>();
            List<int> newList4 = new List<int>();   
            

            foreach (int num in IstNumber_4)
                {
                    if (counts.ContainsKey(num))
                    {
                        counts[num]++;
                        if (counts[num] == 2)
                        {
                            newList4.Add(num);
                        }
                        
                    }
                    else
                    {
                        counts[num] = 1;    
                    }
                }
            foreach (var pair in counts)
            {
                Console.WriteLine($"Phần tử {pair.Key} xuất hiện {pair.Value} lần.");
            }

    
            Console.WriteLine($"Mảng mới là: {string.Join(", ", newList4)}");
        break;


        case "5":

            int[] IstNumber_5 = [7, 1, 5, 3, 6, 4];
            int minPrice = IstNumber_5[0];
            int profit = 0;
            int maxPrice = 0;

            foreach (int price in IstNumber_5)
            {
                if (price < minPrice)
                {
                      minPrice = price;  
                }

                profit = price - minPrice;

                if (profit > maxPrice)
                {
                    maxPrice = profit;
                }
            }

            Console.WriteLine($"Lợi nhuận cao nhất là: {maxPrice}");

        break;
    }
}
