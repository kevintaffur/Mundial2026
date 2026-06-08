using Mundial2026.Models;

namespace Mundial2026.Seed;

public static class StickerSeed
{
    public static List<Sticker> GetData()
    {
        return new List<Sticker>
        {
            new() { Id = 1, Number = 1, PlayerName = "Lionel Messi", Team = "Argentina", Owned = true, Quantity = 1 },
            new() { Id = 2, Number = 2, PlayerName = "Julian Alvarez", Team = "Argentina", Owned = true, Quantity = 3 },
            new() { Id = 3, Number = 3, PlayerName = "Enzo Fernandez", Team = "Argentina", Owned = true, Quantity = 1 },
            new() { Id = 4, Number = 4, PlayerName = "Angel Di Maria", Team = "Argentina", Owned = false, Quantity = 0 },
            new() { Id = 5, Number = 5, PlayerName = "Rodrigo De Paul", Team = "Argentina", Owned = true, Quantity = 2 },

            new() { Id = 6, Number = 6, PlayerName = "Kylian Mbappe", Team = "France", Owned = true, Quantity = 2 },
            new() { Id = 7, Number = 7, PlayerName = "Antoine Griezmann", Team = "France", Owned = false, Quantity = 0 },
            new() { Id = 8, Number = 8, PlayerName = "Ousmane Dembele", Team = "France", Owned = true, Quantity = 1 },
            new() { Id = 9, Number = 9, PlayerName = "Eduardo Camavinga", Team = "France", Owned = true, Quantity = 1 },
            new() { Id = 10, Number = 10, PlayerName = "Aurélien Tchouaméni", Team = "France", Owned = false, Quantity = 0 },

            new() { Id = 11, Number = 11, PlayerName = "Cristiano Ronaldo", Team = "Portugal", Owned = true, Quantity = 1 },
            new() { Id = 12, Number = 12, PlayerName = "Bernardo Silva", Team = "Portugal", Owned = true, Quantity = 2 },
            new() { Id = 13, Number = 13, PlayerName = "Bruno Fernandes", Team = "Portugal", Owned = false, Quantity = 0 },
            new() { Id = 14, Number = 14, PlayerName = "Joao Felix", Team = "Portugal", Owned = true, Quantity = 1 },
            new() { Id = 15, Number = 15, PlayerName = "Ruben Dias", Team = "Portugal", Owned = false, Quantity = 0 },

            new() { Id = 16, Number = 16, PlayerName = "Harry Kane", Team = "England", Owned = true, Quantity = 1 },
            new() { Id = 17, Number = 17, PlayerName = "Jude Bellingham", Team = "England", Owned = true, Quantity = 2 },
            new() { Id = 18, Number = 18, PlayerName = "Phil Foden", Team = "England", Owned = false, Quantity = 0 },
            new() { Id = 19, Number = 19, PlayerName = "Bukayo Saka", Team = "England", Owned = true, Quantity = 1 },
            new() { Id = 20, Number = 20, PlayerName = "Declan Rice", Team = "England", Owned = false, Quantity = 0 },

            new() { Id = 21, Number = 21, PlayerName = "Pedri", Team = "Spain", Owned = true, Quantity = 1 },
            new() { Id = 22, Number = 22, PlayerName = "Gavi", Team = "Spain", Owned = true, Quantity = 2 },
            new() { Id = 23, Number = 23, PlayerName = "Rodri", Team = "Spain", Owned = false, Quantity = 0 },
            new() { Id = 24, Number = 24, PlayerName = "Ferran Torres", Team = "Spain", Owned = true, Quantity = 1 },
            new() { Id = 25, Number = 25, PlayerName = "Alvaro Morata", Team = "Spain", Owned = false, Quantity = 0 },

            new() { Id = 26, Number = 26, PlayerName = "Vinicius Jr", Team = "Brazil", Owned = true, Quantity = 2 },
            new() { Id = 27, Number = 27, PlayerName = "Neymar Jr", Team = "Brazil", Owned = true, Quantity = 1 },
            new() { Id = 28, Number = 28, PlayerName = "Casemiro", Team = "Brazil", Owned = false, Quantity = 0 },
            new() { Id = 29, Number = 29, PlayerName = "Rodrygo", Team = "Brazil", Owned = true, Quantity = 1 },
            new() { Id = 30, Number = 30, PlayerName = "Alisson Becker", Team = "Brazil", Owned = false, Quantity = 0 },

            new() { Id = 31, Number = 31, PlayerName = "Luka Modric", Team = "Croatia", Owned = true, Quantity = 1 },
            new() { Id = 32, Number = 32, PlayerName = "Mateo Kovacic", Team = "Croatia", Owned = false, Quantity = 0 },
            new() { Id = 33, Number = 33, PlayerName = "Josko Gvardiol", Team = "Croatia", Owned = true, Quantity = 2 },
            new() { Id = 34, Number = 34, PlayerName = "Ivan Perisic", Team = "Croatia", Owned = false, Quantity = 0 },
            new() { Id = 35, Number = 35, PlayerName = "Brozovic", Team = "Croatia", Owned = true, Quantity = 1 },

            new() { Id = 36, Number = 36, PlayerName = "Robert Lewandowski", Team = "Poland", Owned = true, Quantity = 1 },
            new() { Id = 37, Number = 37, PlayerName = "Piotr Zielinski", Team = "Poland", Owned = false, Quantity = 0 },
            new() { Id = 38, Number = 38, PlayerName = "Wojciech Szczesny", Team = "Poland", Owned = true, Quantity = 1 },
            new() { Id = 39, Number = 39, PlayerName = "Arkadiusz Milik", Team = "Poland", Owned = false, Quantity = 0 },
            new() { Id = 40, Number = 40, PlayerName = "Jakub Kiwior", Team = "Poland", Owned = true, Quantity = 1 },

            new() { Id = 41, Number = 41, PlayerName = "Son Heung-min", Team = "South Korea", Owned = true, Quantity = 2 },
            new() { Id = 42, Number = 42, PlayerName = "Hwang Hee-chan", Team = "South Korea", Owned = false, Quantity = 0 },
            new() { Id = 43, Number = 43, PlayerName = "Kim Min-jae", Team = "South Korea", Owned = true, Quantity = 1 },
            new() { Id = 44, Number = 44, PlayerName = "Lee Kang-in", Team = "South Korea", Owned = false, Quantity = 0 },
            new() { Id = 45, Number = 45, PlayerName = "Jung Woo-young", Team = "South Korea", Owned = true, Quantity = 1 },

            new() { Id = 46, Number = 46, PlayerName = "Christian Pulisic", Team = "USA", Owned = true, Quantity = 1 },
            new() { Id = 47, Number = 47, PlayerName = "Weston McKennie", Team = "USA", Owned = false, Quantity = 0 },
            new() { Id = 48, Number = 48, PlayerName = "Gio Reyna", Team = "USA", Owned = true, Quantity = 2 },
            new() { Id = 49, Number = 49, PlayerName = "Tyler Adams", Team = "USA", Owned = false, Quantity = 0 },
            new() { Id = 50, Number = 50, PlayerName = "Tim Weah", Team = "USA", Owned = true, Quantity = 1 }
        };
    }
}