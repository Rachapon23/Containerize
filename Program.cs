/*UNSOLVED PROBLEM FOUND
  1.ถ้ากล้องหลุดหลังจากล็อคอินไปเเล้ว Realhandle จะทำงานตามปกติยังไม่มีวิฑีการตรวจว่ากล้องหลุดหรือไม่ เเต่วิดีโอที่ record ออกมาได้เป็น 0 Byte ไม่มีข้อมูล มีแแค่ไฟล์วิดีโอ*/
using HikSDK;
namespace DQiTs1
{
    class Program
    {
        static void Main()
        {
            CHCNetSDK.NET_DVR_Init();
            var deviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();
            var userID = CHCNetSDK.NET_DVR_Login_V30("192.168.1.101", (short)8000, "admin", "DIATIoT01", ref deviceInfo);
            if (userID < 0)
            {
                Console.WriteLine("Login error");
                return;
            }
            else
            {
                Console.WriteLine(userID);
                var previewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO { lChannel = 1 };
                var userPtr = IntPtr.Zero;
                var realHandle = CHCNetSDK.NET_DVR_RealPlay_V40(userID, ref previewInfo, null, userPtr);
                CHCNetSDK.NET_DVR_SaveRealData(realHandle, "C:/Users/mawin/Desktop/video/Record_test0.mp4");
                Thread.Sleep(1000);
                CHCNetSDK.NET_DVR_StopSaveRealData(realHandle);
                CHCNetSDK.NET_DVR_StopRealPlay(realHandle);
                Console.WriteLine("real_handle: " + realHandle);
            }
        }
    }
}