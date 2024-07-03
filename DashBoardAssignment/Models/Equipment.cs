using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashBoardAssignment.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public DateTime EntryDate { get; set; }

        public static List<Equipment> LstEquipment()
        {
            List<Equipment> list = new List<Equipment>();

            Equipment equipment = new Equipment();  
            equipment.Name = "Laptop 1";
            equipment.Count = 5;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            equipment = new Equipment();
            equipment.Name = "Laptop 2";
            equipment.Count = 6;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            equipment = new Equipment();
            equipment.Name = "Laptop 3";
            equipment.Count = 7;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            equipment = new Equipment();
            equipment.Name = "Laptop 4";
            equipment.Count = 8;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            equipment = new Equipment();
            equipment.Name = "Laptop 5";
            equipment.Count = 6;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            return list;
        }
    }
}