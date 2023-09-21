using PokeGame;
using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;


Trainer ash = new Trainer("Ash");

Pokemon sobble = new Pokemon("Sobble", PokeTypes.Water);
Pokemon charmander = new Pokemon("Charmander", PokeTypes.Fire);

Ember ember = new Ember();
charmander.LearnAttack(ember, 0);

AirCutter airCutter = new AirCutter();
sobble.LearnAttack(airCutter, 0);

Console.WriteLine("--------------------------");

Console.WriteLine(sobble.HealthPoints);

BattleEngine.MakeAttack(sobble, ember);

Console.WriteLine(sobble.HealthPoints);