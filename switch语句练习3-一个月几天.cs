//请用户输入年份，再输入月份，经计算后输出该月的天数
//做这道题需要明白一个东西叫--贯穿
//switch效率更高，但是有些例子用switch没办法写，只能用if-else

Console.WriteLine("请输入年份： ");
string year_str = Console.ReadLine();
Console.WriteLine("输入月份： ");
string month_str = Console.ReadLine();

int year , month;
int.TryParse(year_str, out year);
int.TryParse(month_str, out month);

bool run_nian = false;
if (year%400 ==0 || (run_nian%4 ==0 && year % 100 != 0)) {
    run_nian = true;
}

switch (month) {
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("31 days");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("30 days");
        break;
    case 2:
        if (run_nian) {
            Console.WriteLine("29 days");
        }
        else {
            Console.WriteLine("28 days");
        }
        break;

}