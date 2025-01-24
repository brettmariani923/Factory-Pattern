public static class VehicleFactory 
{
    public static IVehicle GetVehicle(string numberOfTires = "0")
    {
       
        switch (numberOfTires.ToLower())
        {
            case "two":
                return new Motorcycle();
            case "four":
                return new Car();
            default:
                throw new ArgumentException("write two or four, pal");

        }
    }
}