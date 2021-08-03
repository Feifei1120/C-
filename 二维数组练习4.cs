//求二维数组（5行5列）中最大元素值及其行列号（随机1-500）
Random r = new Random();
int [,] arr = new int [5,5];
int max = 0, x = 0, y =0;
for (int i = 0; i < arr.GetLength(0); i ++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i,j] = r. Next (1.501);
        if (arr[i,j] > max) {
            max = arr[i,j];
            x = i;
            y = j;
        }
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}
ConsoleApp2.WriteLine("max:{0}, x :{1}, y:{2}", max, x,y);