namespace DZ_Lesson_18_Tuples
{
    public class CatalogPlanets
    {
        public int count = 0;

        static Planet planetVenus = new Planet()
        {
            Name = "Венера",
            SequenceNumber = 2,
            LengthEquator = 6051,
            PreviousPlanet = null,
        };

        static Planet planetEarth = new Planet()
        {
            Name = "Земля",
            SequenceNumber = 3,
            LengthEquator = 40075,
            PreviousPlanet = planetVenus,
        };

        static Planet planetMars = new Planet()
        {
            Name = "Марс",
            SequenceNumber = 4,
            LengthEquator = 21326,
            PreviousPlanet = planetEarth,
        };

        public (int?, int?, string) GetPlanet(string planet)
        {
            count++;

            List<Planet> planets = new List<Planet>();
            planets.Add(planetVenus);
            planets.Add(planetEarth);
            planets.Add(planetMars);

            if (count == 3)
                return (null, null, "Вы спрашиваете слишком часто");        
                
            var findPlanet = planets.Where(x => x.Name == planet).FirstOrDefault();
            if (findPlanet != null)
                return (findPlanet.SequenceNumber, findPlanet.LengthEquator, "");
            else
                return (null, null, "Не удалось найти планету");
        }
    }
}