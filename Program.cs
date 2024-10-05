internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot so");
        int so = int.Parse(Console.ReadLine());
        if (0 <= so && so < 999)
        {
            if (0 <= so && so < 10)
            {
                if (so == 0) Console.WriteLine("khong");
                else if (so == 1) Console.WriteLine("mot");
                else if (so == 2) Console.WriteLine("hai");
                else if (so == 3) Console.WriteLine("ba");
                else if (so == 4) Console.WriteLine("bon");
                else if (so == 5) Console.WriteLine("nam");
                else if (so == 6) Console.WriteLine("sau");
                else if (so == 7) Console.WriteLine("bay");
                else if (so == 8) Console.WriteLine("tam");
                else Console.WriteLine("chin");
            }
            else if (10 <= so && so < 99)
            {
                // Code cho số từ 10 đến 98 bị cắt khỏi hình ảnh
            }
            else
            {
                // Code cho số từ 99 đến 998 bị cắt khỏi hình ảnh
            }
        }
        // Có thể có thêm code xử lý cho trường hợp số >= 999, nhưng không hiển thị trong hình
    }
}