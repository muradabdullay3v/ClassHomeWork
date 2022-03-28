using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHierarchy
{
    class SmartPhone:Phone
    {
        public string ScreenResolution;
        public int CameraMP;
        public int ScreenHz;
        public int Performance;
        public bool WirelessCharging;
        public bool NFC;

        public SmartPhone(string Brand, string Model, int buttonsCount, string Material, int maya_price , string ScreenResolution ,int CameraMP , int ScreenHz , int Performance , bool WirelessCharging , bool NFC):base(Brand,Model,buttonsCount,Material,maya_price)
        {
            this.ScreenResolution = ScreenResolution;
            this.CameraMP = CameraMP;
            this.ScreenHz = ScreenHz;
            this.Performance = Performance;
            this.WirelessCharging = WirelessCharging;
            this.NFC = NFC;
        }

        public override void Info()
        {
            Console.WriteLine($"Brand : {Brand}\nModel : {Model}\nMaterial : {Material}\nNumber of Buttons : {buttonsCount}\n" +
                $"Price : {maya_price}\nScreenResolution : {ScreenResolution}\nCameraMP : {CameraMP}\nScreenHz : {ScreenHz}\n" +
                $"Performance : {Performance}\nWirelessCharging : {WirelessCharging}\nNFC : {NFC}\n");
        }


    }
}
