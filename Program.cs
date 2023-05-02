using HikSDK;
namespace DQiTsl
{
    class Program
    {
        static void Main()
        {
            CHCNetSDK.NET_DVR_Init();
            Console.WriteLine(CHCNetSDK.NET_DVR_Init());
        }
    }
}
