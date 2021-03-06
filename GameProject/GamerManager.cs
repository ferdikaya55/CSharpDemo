﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void SaveGamer(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
                Console.WriteLine(gamer.FirstName + " isimli oyuncu kaydedildi..");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulanamadı.Kayıt başarısız.");

            }
           
        }
        public void ListGamer(List<Gamer> gamers)
        {
            Console.WriteLine("Oyuncu Listesi");
            Console.WriteLine("***************");
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName);
            }
        }
        public void RemoveListGamer(List<Gamer> gamers)
        {
            gamers.RemoveAt(1);
            Console.WriteLine("Oyuncu Listesinden Silindi..");
            Console.WriteLine("Listede kalan oyuncular:");
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName);
            }

        }
        public void UpdateGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu güncellendi..");
        }
        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu silindi..");
        }
    }
}
