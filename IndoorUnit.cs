using System;
namespace DzAirConditioning
{
public class IndoorUnit : IOnOff
    {
        public string On { get; set; }

        public string Off { get; set; }

        public void WarmMode()
        {
            Console.WriteLine(" Режим греть ");
        }
        public void ColdMode()
        {
            Console.WriteLine(" Режим холод ");
        }
    }
}