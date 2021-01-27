using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IGamerService
    {
        void SaveGamer(Gamer gamer);
        void ListGamer(List<Gamer> gamers);
        void UpdateGamer(Gamer gamer);
        void DeleteGamer(Gamer gamer);
    }
}
