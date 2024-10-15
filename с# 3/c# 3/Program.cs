using System;
// задание 1
// class City
// {
//     private string cityName;
//     private string countryName;
//     private int population;
//     private string phoneCode;
//     private List<string> rayon;

//     public City()
//     {
//         cityName="Oдесса";
//         countryName="Украина";
//         population=36000000;
//         phoneCode="+380";
//         rayon=new List<string>{"Приморский","Малиновский","Киевский","Суворовский"};

//     }
//     public void Input()
//     {
//        Console.WriteLine("Название города: ");
//        cityName= Console.ReadLine();
//        Console.WriteLine("Название страны: ");
//        countryName= Console.ReadLine();
//        Console.WriteLine("Насиление: ");
//        population= int.Parse(Console.ReadLine());
//        Console.WriteLine("Телефонный код: ");
//        phoneCode= Console.ReadLine();
//        Console.WriteLine("Район: ");
//        rayon=new List<string>(Console.ReadLine().Split(','));

//     }
//     public void Print()
//     {
//         Console.WriteLine($"Город:{cityName}");
//         Console.WriteLine($"Страна:{countryName}");
//         Console.WriteLine($"Насиление:{population}");
//         Console.WriteLine($"Телефонный код:{phoneCode}");
//         Console.WriteLine($"Район:"+ string.Join(",",rayon));
//     }
//     public string GetCityName()
//     {
//        return cityName;
//     }
//     public void SetCityName(string name)
//     {
//         cityName=name;
//     }
    
//     public string GetCountryName()
//     {
//        return countryName;
//     }
//     public void SetCountryName(string name)
//     {
//         countryName=name;
//     }

//     public int GetPopulation()
//     {
//        return population;
//     }
//     public void SetPopulation(int pop)
//     {
//         population=pop;
//     }

//     public string GetPhoneCode()
//     {
//        return phoneCode;
//     }
//     public void SetPhoneCode(string code)
//     {
//         phoneCode=code;
//     }

//     public List<string> GetRayon()
//     {
//        return rayon;
//     }
//     public void SetRayon(List<string> ray)
//     {
//         rayon=ray;
//     }
// }
// class vivod
// {
//     static void Main(string[] args)
//     {
//         City Odessa= new City();
//         Odessa.Print();
//         Odessa.Input();
//         Odessa.Print();
//     }
// }











//задание 2
// class Sotrydnik
// {
//     private string name;
//     private string data;
//     private string email;
//     private string dolznost;
//     private string phone;
//     private List<string> obazanosti;

//     public Sotrydnik()
//     {
//         name="Белан Дима Андреевич ";
//         data="24.01.90";
//         email="belandia@gmail.com";
//         phone="+380493241342";
//         dolznost="Бугалтер";
//         obazanosti=new List<string>{"Поиск и привлечение новых клиентов ","Подготовка и проведение переговоров с партнерами "};

//     }
//     public void Input()
//     {
//        Console.WriteLine("ФИО: ");
//        name= Console.ReadLine();
//        Console.WriteLine("Дата рождения: ");
//        data= Console.ReadLine();
//        Console.WriteLine("Телефон: ");
//        phone= Console.ReadLine();
//        Console.WriteLine("Почта: ");
//        email= Console.ReadLine();
//        Console.WriteLine("Должность: ");
//        dolznost= Console.ReadLine();
//        Console.WriteLine("Обязаности: ");
//        obazanosti =new List<string>(Console.ReadLine().Split(','));

//     }
//     public void Print()
//     {
//         Console.WriteLine($"ФИО:{name}");
//         Console.WriteLine($"Дата рождения:{data}");
//         Console.WriteLine($"Телефон:{phone}");
//         Console.WriteLine($"Почта:{email}");
//         Console.WriteLine($"Должность:{dolznost}");
//         Console.WriteLine($"Обязаности:"+ string.Join(",",obazanosti));
//     }
//     public string GetName()
//     {
//        return name;
//     }
//     public void SetName(string Name)
//     {
//         name=Name;
//     }
    
//     public string GetData()
//     {
//        return data;
//     }
//     public void SetData(string Data)
//     {
//         data=Data;
//     }

//     public string GetPhone()
//     {
//        return phone;
//     }
//     public void SetPhone(string Phone)
//     {
//         phone=Phone;
//     }

//     public string GetEmail()
//     {
//        return email;
//     }
//     public void SetEmail(string Email)
//     {
//         email=Email;
//     }
//     public string GetDolznost()
//     {
//        return dolznost;
//     }
//     public void SetDolznost(string Dolznost)
//     {
//         dolznost=Dolznost;
//     }
//     public List<string> GetObazanosti ()
//     {
//        return obazanosti ;
//     }
//     public void SetObazanosti (List<string> Obazanosti )
//     {
//         obazanosti=Obazanosti;
//     }
// }
// class vivod
// {
//     static void Main(string[] args)
//     {
//         Sotrydnik Dima= new Sotrydnik();
//         Dima.Print();
//         Dima.Input();
//         Dima.Print();
//     }
// }




//задание 3
// class Samolet
// {
//     private string nazvanie;
//     private string proizvoditel;
//     private int godVypuska;
//     private string tip;

//     public Samolet()
//     {
//         nazvanie = "Boening 747-700";
//         proizvoditel = "Boening";
//         godVypuska = 1988;
//         tip = "Пассажирский";
//     }

//     public Samolet(string Nazvanie, string Proizvoditel, int GodVypuska, string Tip)
//     {
//         nazvanie = Nazvanie;
//         proizvoditel = Proizvoditel;
//         godVypuska = GodVypuska;
//         tip = Tip;
//     }

//     public void Vvod(string Nazvanie)
//     {
//         nazvanie = Nazvanie;
//     }
//     public void Vvod(string Nazvanie, string Proizvoditel)
//     {
//         nazvanie = Nazvanie;
//         proizvoditel = Proizvoditel;
//     }
//     public void Vvod(string Nazvanie, string Proizvoditel, int GodVypuska, string Tip)
//     {
//         nazvanie = Nazvanie;
//         proizvoditel = Proizvoditel;
//         godVypuska = GodVypuska;
//         tip = Tip;
//     }

//     public void Vyvod()
//     {
//         Console.WriteLine($"Название: {nazvanie}");
//         Console.WriteLine($"Производитель: {proizvoditel}");
//         Console.WriteLine($"Год выпуска: {godVypuska}");
//         Console.WriteLine($"Тип: {tip}");
//     }


//     public string GetNazvanie()
//     {
//         return nazvanie;
//     }

//     public void SetNazvanie(string Nazvanie)
//     {
//         nazvanie = Nazvanie;
//     }

//     public string GetProizvoditel()
//     {
//         return proizvoditel;
//     }

//     public void SetProizvoditel(string Proizvoditel)
//     {
//         proizvoditel = Proizvoditel;
//     }

//     public int GetGodVypuska()
//     {
//         return godVypuska;
//     }

//     public void SetGodVypuska(int GodVypuska)
//     {
//         godVypuska = GodVypuska;
//     }

//     public string GetTip()
//     {
//         return tip;
//     }

//     public void SetTip(string Tip)
//     {
//         tip = Tip;
//     }
// }
// class vivod
// {
//     static void Main(string[] args)
//     {
//         Samolet samolet1 = new Samolet();
//         samolet1.Vyvod();
//         Console.WriteLine("Ввод данных: ");
//         samolet1.Vvod("Airbus A320", "Airbus", 1998, "Пассажирский");
//         samolet1.Vyvod();
//     }
// }
