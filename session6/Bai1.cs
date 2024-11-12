class Bai1{
    public static int tinhTongSoLon50(List<int> numbers){
       int sum =0;
       
        foreach(int number in numbers)
        {
            if (number >= 50)
            {
                sum += number;
            }
        }
        return sum;
    }

    public static int timSoLonNhat(List<int>numbers){
        int result = 0;
        for (int i = 0; i< numbers.Count ; i++)
        {
            if(numbers[i]>result)
            {
                result = numbers[i];
            }
        }
        return result;
    }
    public static List<string>  timChuBatDauBangChuM (List<string> fruits)
    {
        List<string>result = new List<string>();

        for(int i = 0 ; i < fruits.Count; i++)
        {
            if (fruits[i].StartsWith("m"))
            {
                 result.Add(fruits[i]);
            }
        }
        return result;
    }

    public static List<int> xoaTrung (List<int> numbers){
        List<int> newList = new List<int>();
        newList.Add(numbers.ElementAt(0));
        for (int i = 1; i < numbers.Count; i++)
        {
            if (newList.Contains(numbers[i]) == false ){
                newList.Add(numbers[i]);
            }
        }
        return newList;
    }
}