using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class OrderItem
    {
        private string cargoName;       
        private uint cargoNum;
        private double money,unitPrice;

        public string CargoName { get => cargoName; set => cargoName = value; }
        public uint CargoNum { get => cargoNum; set => cargoNum = value; }
        public double Money { get => money; set => money = cargoNum * unitPrice; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }

        public OrderItem(string cargoName,uint cargoNum,double unitPrice)
        {
            this.cargoName = cargoName;
            this.cargoNum = cargoNum;
            this.unitPrice = unitPrice;
            this.money = cargoNum * unitPrice;
        }

        public override bool Equals(object obj)
        {
            OrderItem m = obj as OrderItem;
            return m != null && m.cargoName == cargoName && m.cargoNum == cargoNum && m.money == money && m.unitPrice == unitPrice;
        }

        public override string ToString()
        {
            return cargoName+"       "+cargoNum+"     "+unitPrice+"      "+money+"\n ";
        }
    }
}
