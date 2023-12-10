try
{
    Console.Write("Введите количество автомобилей:");
    int n = int.Parse(Console.ReadLine());
    Car[] cars = new Car[n];
    for (int i = 0; i < n; i++)
    {
        cars[i] = new Car();
        Console.Write("Введите марку:");
        cars[i].Marka = Console.ReadLine();
        Console.Write("Введите производителя:");
        cars[i].Factory = Console.ReadLine();
        Console.Write("Введите тип:");
        cars[i].Type = Console.ReadLine();
        Console.Write("Введите год выпуска:");
        cars[i].Year = int.Parse(Console.ReadLine());

        Console.Write("Введите год регистрации:");
        int yearReg = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц регистрации:");
        int monthReg = int.Parse(Console.ReadLine());
        Console.Write("Введите день регистрации:");
        int dayReg = int.Parse(Console.ReadLine());
        cars[i].DateReg = new DateTime(yearReg, monthReg, dayReg);
    }

    foreach (Car car in cars)
    {
        int nowYear = DateTime.Now.Year;
        int toYear = car.DateReg.Year;
        if (nowYear - toYear < 1)
        {
            Console.WriteLine(car.Marka);
            Console.WriteLine(car.Factory);
            Console.WriteLine(car.Type);
            Console.WriteLine(car.Year);
            Console.WriteLine(car.DateReg);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct Car
{
    public string Marka;
    public string Factory;
    public string Type;
    public int Year;
    public DateTime DateReg;
}