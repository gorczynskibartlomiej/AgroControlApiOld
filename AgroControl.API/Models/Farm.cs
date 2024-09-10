﻿namespace AgroControl.API.Models
{
    public class Farm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FarmNumber { get; set; }
        public string Address { get; set; } //szczegolowo?
        //wlasciciel

        public DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedById { get; set; }

        public ICollection<AgroControlUser> Users { get; set; } //posrednia tabela zeby mozna miec kilka gospodarsw?
        public ICollection<Field> Fields { get; set; }

        public ICollection<FarmCropProtectionProduct> FarmCropProtectionProducts { get; set; }
        public ICollection<FarmFertilizer> FarmFertilizers { get; set; }
        public ICollection<FarmFuel> FarmFuels { get; set; }
        public ICollection<FarmSeed> FarmSeeds { get; set; }

    }
}