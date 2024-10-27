using DZ_Lesson_18_Tuples;

List<string> planets = new List<string>() { "Земля", "Лимония", "Марс" };

CatalogPlanets catalogPlanets = new CatalogPlanets();

foreach (string planet in planets)
{
    var returnValue = catalogPlanets.GetPlanet(planet);
    string result = string.IsNullOrEmpty(returnValue.Item3) 
        ? $"порядковый номер от Солнца - {returnValue.Item1}, длина экватора - {returnValue.Item2} км"
        : returnValue.Item3;

    Console.WriteLine($"Вывод информации по планете {planet}: {result}");
}
