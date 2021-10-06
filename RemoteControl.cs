using System;
namespace DzAirConditioning
{
public class RemoteControl : IndoorUnit,  IOnOff
    {

        public new string On { get; set; } = " on ";
        public new string Off { get; set; } = " off ";
        

    }
}