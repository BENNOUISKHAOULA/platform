﻿using System.ComponentModel.DataAnnotations;

namespace PlatformApi.Models
{
    public class Vendeur
    {

        [Key]
        public int id_Vendeur { get; set; }
        public string nom_Venduer { get; set; }
        public string prenom_Vendeur { get; set; }
        public DateTime date_naissance { get; set; }
        public string email_Vendeur { get; set; }
        public int num_telephone { get; set; }
        public string password { get; set; }
        public string ville { get; set; }
        public bool verifie_compte {  get; set; }
        public bool block { get; set; } = false;
        public IList<VendeurAdmin> VendeurAdmins { get; set; }
        public IList<Store> stores { get; set; }
        public IList<Paiement> Paiements { get; set; }

    }
}
