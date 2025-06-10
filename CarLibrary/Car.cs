
using System;

namespace CarLibrary
{
    public class Car
    {
        public string Brand { get; set; }            
        public int Year { get; set; }                
        public readonly string VIN;                   
        public readonly CarBodyType BodyType;         

        public decimal Price { get; set; }          
        public DateTime SaleDate { get; set; }
        public string BuyerFullName { get; set; }

        public Car(string brand, int year, string vin, CarBodyType bodyType)
        {
            Brand = brand;
            Year = year;
            VIN = vin;
            BodyType = bodyType;
        }

        public virtual string[] GetInfo()
        {
            return new string[]
            {
                $"Марка: {Brand}, Год: {Year}, VIN: {VIN}, Тип кузова: {BodyType}",
                $"Цена: {Price} руб., Дата продажи: {SaleDate:dd.MM.yyyy}, Покупатель: {BuyerFullName}"
            };
        }
    }
}
