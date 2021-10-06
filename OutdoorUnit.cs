using System;
namespace DzAirConditioning
{
 public class OutdoorUnit : IOnOff
    {
        public string On  { get; set; }
        public string Off { get; set; }
        public void CompresАreon()
        {
            Console.WriteLine(" Сжимать фреон ");
        }
        public void NotCompressFreon()
        {
            Console.WriteLine(" Не сжимать фреон ");
        }
    }
}