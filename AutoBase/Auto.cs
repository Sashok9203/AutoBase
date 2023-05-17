using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Auto
    {
        public string Brand { get; }
        public string Model { get; }
        public string Color { get; }
        public string VinNumber { get; }
        public string CNumber { get; }
        public int Year { get; }
        public Auto(string? brand,string? model,string? color,string? vin,string? num,int year)
        {
            Brand = brand ?? "Invalid brand";
            Model = model ?? "Invalid model";
            Color = color ?? "Invalid color";
            VinNumber = vin ?? "Invalid VIN";
            CNumber = num ?? "Invalid number";
            Year = year < 1970 ? 1970 : year;
        }

        public string GetInfo()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Марка   : {Brand}");
            sb.AppendLine($"Модель : {Model}");
            sb.AppendLine($"Колір     : {Color}");
            sb.AppendLine($"Номер   : {CNumber}");
            sb.AppendLine($"VIN         : {VinNumber}");
            return sb.ToString(); 
        }

        public override string ToString() => $"{Brand} {Model}";
        
    }
}
