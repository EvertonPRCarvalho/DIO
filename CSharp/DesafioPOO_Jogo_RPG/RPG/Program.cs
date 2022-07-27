using RPG.Models;
using RPG.src.Models;

Personagem hero = new Personagem();
hero.Nome = "Jack";
hero.TipoHeroi = "Mago";

hero.AdicionarAtaque("Magia Congelante", 2);
hero.AdicionarAtaque("Flecha Mágica", 1);
hero.AdicionarAtaque("Machado Cinzento", 2);

System.Console.WriteLine($"Nome: {hero.Nome}");
System.Console.WriteLine($"Tipo: {hero.TipoHeroi}");
System.Console.WriteLine($"HP: {hero.Hp}");



Personagem player = new Personagem();
player.Nome = "Ethan";
player.TipoHeroi = "Guerreiro";

player.AdicionarAtaque("Machado de Ouro", 2);
player.AdicionarAtaque("Flecha Flamejante", 1);
player.AdicionarAtaque("Espata Mortal", 2);

player.AdicionarDefesa("Flecha Mágica", 1);
player.AdicionarDefesa("Machado Cinzento", 1);

System.Console.WriteLine($"Nome: {player.Nome}");
System.Console.WriteLine($"Tipo: {player.TipoHeroi}");
System.Console.WriteLine($"HP: {player.Hp}");

Batalha batalhaHero = new Batalha(hero, player);
batalhaHero.Atacar(player, "Machado Cinzento");
batalhaHero.Batalhar();
System.Console.WriteLine("===================");
System.Console.WriteLine("====Pós Batalha====");
System.Console.WriteLine("===================");
System.Console.WriteLine($"Nome: {player.Nome}");
System.Console.WriteLine($"Tipo: {player.TipoHeroi}");
System.Console.WriteLine($"HP: {player.Hp}");