using RPG.Models;
using RPG.src.Models;

Personagem hero = new Personagem();
hero.Nome = "Ivon";
hero.TipoHeroi = "Mago";
hero.Level = 2;

hero.AdicionarAtaque("Magia Congelante", 2);
hero.AdicionarAtaque("Flecha Mágica", 1);
hero.AdicionarAtaque("Machado Cinzento", 2);

hero.AdicionarDefesa("Flecha Flamejante", 1);
hero.AdicionarDefesa("Espada Mortal", 2);

System.Console.WriteLine($"Nome: {hero.Nome} | Tipo: {hero.TipoHeroi} | HP: {hero.Hp} | Level: {hero.Level}");



Personagem player = new Personagem();
player.Nome = "Strar";
player.TipoHeroi = "Guerreiro";

player.AdicionarAtaque("Machado de Ouro", 2);
player.AdicionarAtaque("Flecha Flamejante", 1);
player.AdicionarAtaque("Espata Mortal", 2);

player.AdicionarDefesa("Flecha Mágica", 1);
player.AdicionarDefesa("Machado Cinzento", 1);


System.Console.WriteLine($"Nome: {player.Nome} | Tipo: {player.TipoHeroi} | HP: {player.Hp} | Level: {player.Level}");

Batalha batalhaHero = new Batalha(hero, player);
batalhaHero.Atacar(player, "Machado Cinzento");
batalhaHero.Batalhar();
System.Console.WriteLine("===================");
System.Console.WriteLine("====Pós Batalha====");
System.Console.WriteLine("===================");
System.Console.WriteLine($"Nome: {player.Nome}");
System.Console.WriteLine($"Tipo: {player.TipoHeroi}");
System.Console.WriteLine($"HP: {player.Hp}");