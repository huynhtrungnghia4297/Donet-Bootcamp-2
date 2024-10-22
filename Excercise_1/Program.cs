 while (true)
{
    Console.WriteLine("Nhập số bài bạn muốn thực hiện. Nhập 'exit' để thoát:");
    string? input = Console.ReadLine();
    if (input == "exit")
        {
            Console.WriteLine("Kết thúc chương trình.");
            break;
        }
    switch (input)
    {
        case "1":
        //Bài 1: Tính số ngày trong tuần và số ngày lẻ
        #region 
        //Input
        Console.WriteLine("Nhập số ngày: ");
        string? _dayIn = Console.ReadLine();
        int _formatDayIn = Convert.ToInt32(_dayIn);
        //Output
        int _dayOut = 0;
        int _oddDays = 0;
        //Process
        _dayOut = _formatDayIn / 7;
        _oddDays = _formatDayIn % 7;
        Console.WriteLine($"Số tuần là: {_dayOut} và số ngày lẻ là: {_oddDays}");
        #endregion
        break;

        case "2":
        //Bài 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
        #region 
        //Input
        Console.WriteLine("Nhập vào giá trị đơn hàng: ");
        string? _priceProduct = Console.ReadLine();
        Console.WriteLine("Nhập vào số phần trăm giảm giá: ");
        string? _percentDiscount = Console.ReadLine();

        double _formatPrice = Convert.ToDouble(_priceProduct);
        double _formatPercent = Convert.ToDouble(_percentDiscount);

        //Output
        double _priceDiscount = 0.0;
        double _totalPrice = 0.0;

        //Process
        _priceDiscount = (_formatPrice * _formatPercent) /100;
        _totalPrice = _formatPrice - _priceDiscount;

        Console.WriteLine($"Số tiền giảm giá là: {_priceDiscount} và tổng số tiền phải thành toán sau khi áp dụng giảm giá là: {_totalPrice}");
        #endregion
        break;

        case "3":
        //Bài 3: Chuyển đổi thời gian sang từ phút sang giờ và phút
        #region 
        //Input
        Console.WriteLine("Nhập số phút: ");
        string? _minuteIn = Console.ReadLine();
        int _formatMinuteIn = Convert.ToInt32(_minuteIn);

        //Output
        int __minuteOut = 0;
        int _oddMinutes = 0;

        //Process
        __minuteOut = _formatMinuteIn / 60;
        _oddMinutes = _formatMinuteIn % 60;
        Console.WriteLine($"Số giờ là: {__minuteOut} giờ và số phút còn lại là: {_oddMinutes} phút");

        #endregion
        break;

        case "4":
        //Bài 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
        #region 
        //Input
        Console.WriteLine("Nhập số tiền gốc: ");
        string? _priceIn = Console.ReadLine();

        Console.WriteLine("Nhập tỷ lệ thuế VAT: ");
        string? _vatIn = Console.ReadLine();

        double _formatPriceIn = Convert.ToDouble(_priceIn);
        double _formatVatIn = Convert.ToDouble(_vatIn);

        //Output
        double _priceVat = 0.0;
        double _totalPriceAmout = 0.0;

        //Process
        _priceVat = (_formatPriceIn * _formatVatIn) /100;
        _totalPriceAmout = _formatPriceIn + _priceVat;
        Console.WriteLine($"Tổng số tiền sau khi đã cộng thêm thuế là: {_totalPriceAmout}");
        #endregion
        break;

        case "5":
        //Bài 5: Chuyển đổi đơn vị tiền tệ
        #region 
        //Input
        Console.WriteLine("Nhập số tiền USD: ");
        string? _priceUSD = Console.ReadLine();

        Console.WriteLine("Nhập tỷ giá chuyển đổi từ USD sang VND: ");
        string? _exchangeRate = Console.ReadLine();

        double _formatPriceUSD = Convert.ToDouble(_priceUSD);
        double _formatExchangeRate = Convert.ToDouble(_exchangeRate);

        //Output
        double _priceVND = 0.0;

        //Process
        _priceVND = _formatPriceUSD * _formatExchangeRate;
        Console.WriteLine($"Số tiền sau khi chuyển đổi là: {_priceVND} VND");
        #endregion
        break;

        case "6":
        //Bài 6: TÍnh số dư sau khi rút tiền từ tài khoản
        #region 
        //Input
        double _formatBalance = 0.0;
        double _formatWithdraw = 0.0;
         while (true)
        {
            Console.WriteLine("Nhập số dư tài khoản hiện tại: ");
            string? _balance = Console.ReadLine();
            //_formatBalance = Convert.ToDouble(_balance);

            if (double.TryParse(_balance, out _formatBalance))
            {
                if (_formatBalance <= 0 )
                {
                    Console.WriteLine("Số dư bạn không đủ để thực hiện giao dịch. Vui lòng nhập lại số dư.");
                    continue;
                }
               break;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ.");
            }
            
        }
        while (true)      
        {
            Console.WriteLine("Nhập số tiền muốn rút: ");
            string? _withdraw = Console.ReadLine();     
             //_formatWithdraw = Convert.ToDouble(_withdraw);


             if (double.TryParse(_withdraw, out _formatWithdraw) && _formatWithdraw > 0 && _formatWithdraw <= _formatBalance)
            {

                break;
                
            } 
            else
            {
                if(_formatWithdraw > _formatBalance)
                {
                    Console.WriteLine("Số tiền bạn muốn rút lớn hơn số dư tài khoản của bạn. Vui lòng nhập lại.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ.");            
                }     
            }              
        }
        //Output
                double _totalPriceBalance = 0.0;
                //Process
                _totalPriceBalance = _formatBalance - _formatWithdraw;
                Console.WriteLine($"Số tiền dư còn lại sau khi rút là: {_totalPriceBalance}");
        #endregion
        break;

        case "7":
        //Bài 7: Tính tốc độ trung bình
        #region
        //Input
        Console.WriteLine("Nhập vào số quãng đường đã đi (km): ");
        string? _kilomet = Console.ReadLine();
        Console.WriteLine("Nhập vào số thời gian đã đi (giờ): ");
        string? _hour = Console.ReadLine();

        double _formatKilomet = Convert.ToDouble(_kilomet);
        double _formatHour = Convert.ToDouble(_hour);

        //Output
        double _speed = 0.0;

        //Process
        _speed = _formatKilomet / _formatHour;
        Console.WriteLine($"Vận tốc trung bình là: {_speed} km/h");

        #endregion
        break;

        case "8":
        //Bài 8: Tính tỷ lệ phần trăm
        #region 
        // //Input 
        Console.WriteLine("Nhập vào số bất kỳ: ");
        string? _number = Console.ReadLine();
        Console.WriteLine("Nhập vào số tổng bất kỳ: ");
        string? _total = Console.ReadLine();

        double _formatNumber = Convert.ToDouble(_number);
        double _formatTotal = Convert.ToDouble(_total);

        //Output
        double _percent = 0.0;

        //Process
        _percent = (_formatNumber/_formatTotal) * 100;
        Console.WriteLine($"Tỷ lệ phần trăm là: {_percent} %");
        #endregion
        break;

    //Bài 9: Chuyển đổi từ km/h sang m/s

   
    
        case "9":
        #region 
        //Input 
        Console.WriteLine("Nhập vào số vận tốc (km/h): ");
        string? _speed2 = Console.ReadLine();


        double _formatSpeed = Convert.ToDouble(_speed2);

        //Output
        double _speedConvert = 0.0;

        //Process
        _speedConvert = (_formatSpeed/3.6);
        Console.WriteLine($"Kết quả chuyển đổi là: {_speedConvert} m/s");
        #endregion
        break;
        case "10":
        //Bài 10: Tính lượng calo tiêu thụ
        #region 
        //Input 
        Console.WriteLine("Nhập vào số phút đã tập thể dục: ");
        string? _minutes = Console.ReadLine();
            
        double _formatMinutes = Convert.ToDouble(_minutes);

        Console.WriteLine("Nhập vào loại hình tập thể dục (1: Chạy, 2: Đạp xe, 3: Bơi lội): ");
        string? _type = Console.ReadLine();
        double _calo = 0.0;
                
        //Output
        double _totalCalo = 0.0;

        //Process
        if (_type == "1")
        {
            _calo = 13;
        }
        else if (_type == "2")
        {
            _calo = 15.5;
        }
        else if (_type == "3")
        {
            _calo = 12.5;
        }
        _totalCalo = (_formatMinutes * _calo);
                
        Console.WriteLine($"Lượng tiêu thụ calo khi bạn {_type} là: {_totalCalo}");
                
        #endregion
        break;

        default:
        Console.WriteLine("Không có bài tập này. Vui lòng chọn lại.");
        break;
    }
}

