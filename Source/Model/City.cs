namespace Source.Model
{
    public record City(string State, string StateCode, string CityCode, string CityName, string Population)
    {
        public override string ToString()
        {
            return $"{CityName}/{State} - possui {Population} habitantes.";
        }
    }
}