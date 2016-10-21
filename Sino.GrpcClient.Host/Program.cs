using System;

namespace Sino.GrpcClient.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var list = MsgServiceClient.GetList(0, "1", 0, 0);
                }
                catch (Exception ex)
                {

                }
                Console.ReadKey();
            }
        }
    }
}
