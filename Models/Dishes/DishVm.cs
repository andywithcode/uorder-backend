﻿using Data.Enums;

namespace Models.Dishes
{
    public class DishVm
    {
        public string Key { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Price { get; set; }
        public int CompletionTime { get; set; }
        public bool IsActive { get; set; }
        public int QtyPerDay { get; set; }
        public DishType Type { get; set; }
        public string TypeName { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> OrderDetails { get; set; } = new List<string>();
        public List<string> DishMedias { get; set; } = new List<string>();
        public List<string> DishMenus { get; set; } = new List<string>();
    }
}