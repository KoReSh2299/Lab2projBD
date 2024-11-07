using Lab2proj.Data;
using Lab2proj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Collections.Immutable;

namespace Lab2proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var optionsBuilder = new DbContextOptionsBuilder<KursachContext>();

            //var dbContext = new KursachContext();

            //foreach (var a in dbContext.Cars)
            //{
            //    Console.WriteLine($"{a.Id} {a.Number}");
            //}

            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<KursachContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (var db = new KursachContext(options))
            {
                //Console.WriteLine("1. Вывести данные из таблицы Employees, которая стоит на стороне отношения один(нажмите любую клавишу)");
                //Console.ReadLine();

                //var employees = db.Employees;
                //foreach (var employee in employees)
                //{
                //    Console.WriteLine($"{employee.Id,-3}. {employee.Surname,-15} {employee.Name,-15} {employee.MiddleName,-20}");
                //}




                //Console.WriteLine("2. Вывести данные из таблицы Clients, где имя клиента содержит букву \"П\"(нажмите любую клавишу)");
                //Console.ReadLine();

                //var clients = from client in db.Clients
                //              where client.IsRegularClient == false &&
                //                    client.Name.Contains("П")
                //              select client;

                //foreach (var client in clients)
                //{
                //    var isReg = client.IsRegularClient ? "RegularClient" : "NotRegularClient";
                //    Console.WriteLine($"{client.Id,3}. {client.Surname,-15} {client.Name,-15} {client.MiddleName,-20} {client.Telephone,-15} {isReg,-16}");
                //}




                //Console.WriteLine("3. Вывести данные из таблицы Cars, отображающие кол-во машин, которыми владеет каждый клиент(нажмите любую клавишу)");
                //Console.ReadLine();

                //var cars = db.Cars.
                //    GroupBy(x => x.ClientId).
                //    Select(group => new
                //    {
                //        ClientId = group.Key,
                //        Count = group.Count()
                //    }).
                //    OrderBy(key => key.ClientId);


                //foreach (var car in cars)
                //{
                //    Console.WriteLine($"{car.ClientId,4}. {car.Count}");
                //}



                //Console.WriteLine("4. Вывести данные из таблиц Clients и Cars, связанных отношением \"один-ко-многим\"(нажмите любую клавишу)");
                //Console.ReadLine();

                //var carsClients = db.Clients.Join(
                //    db.Cars,
                //    client => client.Id,
                //    car => car.ClientId,
                //    (client, car) => new
                //    {
                //        client.Id,
                //        client.Surname,
                //        client.Name,
                //        client.MiddleName,
                //        car.Brand,
                //        CarNumber = car.Number
                //    }).
                //    OrderBy(carClient => carClient.Id);


                //foreach (var carClient in carsClients)
                //{
                //    Console.WriteLine($"{carClient.Id,-4}. {carClient.Surname,-15} {carClient.Name,-15} {carClient.MiddleName,-20} {carClient.Brand,-10} {carClient.CarNumber,-15}");
                //}



                //Console.WriteLine("5. Вывести данные из таблиц Clients и Cars, связанных отношением \"один-ко-многим\" и содержащих букву \"s\" в названии бренда машины(нажмите любую клавишу)");
                //Console.ReadLine();

                //var carsClients2 = db.Clients.Join(
                //    db.Cars,
                //    client => client.Id,
                //    car => car.ClientId,
                //    (client, car) => new
                //    {
                //        client.Id,
                //        client.Surname,
                //        client.Name,
                //        client.MiddleName,
                //        car.Brand,
                //        CarNumber = car.Number
                //    })
                //    .Where(carClient => carClient.Brand.Contains("s"))
                //    .OrderBy(carClient => carClient.Id);


                //foreach (var carClient in carsClients2)
                //{
                //    Console.WriteLine($"{carClient.Id,4}. {carClient.Surname,-15} {carClient.Name,-15} {carClient.MiddleName,-20} {carClient.Brand,-10} {carClient.CarNumber,-15}");
                //}




                //Console.WriteLine("6. Вставка данных в таблицу Employees(нажмите любую клавишу)");
                //Console.ReadLine();
                //Console.WriteLine("Последние 10 работников по id до добавления нового работника");

                //var last10Employees = db.Employees.OrderByDescending(emp => emp.Id).Take(10);

                //foreach (var newEmployee in last10Employees)
                //{
                //    Console.WriteLine($"{newEmployee.Id, 4} {newEmployee.Surname,-20} {newEmployee.Name,-15} {newEmployee.MiddleName,-20}");
                //}

                //Console.WriteLine("\nПоследние 10 работников по id после добавления нового работника");

                //var employee = new Employee
                //{
                //    Surname = "Горкунов",
                //    Name = "Василий",
                //    MiddleName = "Алексеевич"
                //};

                //db.Employees.Add(employee);
                //db.SaveChanges();

                //last10Employees = db.Employees.OrderByDescending(emp => emp.Id).Take(10);

                //foreach (var newEmployee in last10Employees)
                //{
                //    Console.WriteLine($"{newEmployee.Id, 4} {newEmployee.Surname,-20} {newEmployee.Name,-15} {newEmployee.MiddleName,-20}");
                //}




                //Console.WriteLine("7. Вставка данных в таблицу Cars(нажмите любую клавишу)");
                //Console.ReadLine();
                //Console.WriteLine("Последние 10 машин по id до добавления новой машины");

                //var last10Cars = db.Cars.OrderByDescending(car => car.Id).Take(10);

                //foreach (var newCar in last10Cars)
                //{
                //    Console.WriteLine($"{newCar.Id, 4} {newCar.Brand,-10} {newCar.Number,-15} {newCar.ClientId,-4}");
                //}

                //Console.WriteLine("\nПоследние 10 машин по id после добавления новой машины");

                //var random = new Random();
                //var clientId = random.Next(1, db.Clients.Count());

                //var car = new Car
                //{
                //    Brand = "Audi",
                //    Number = "3950589",
                //    ClientId = clientId
                //};

                //db.Cars.Add(car);
                //db.SaveChanges();

                //last10Cars = db.Cars.OrderByDescending(car => car.Id).Take(10);

                //foreach (var newCar in last10Cars)
                //{
                //    Console.WriteLine($"{newCar.Id, 4} {newCar.Brand,-10} {newCar.Number,-15} {newCar.ClientId,-4}");
                //}



                //Console.WriteLine("8. Удаление данных из таблицы Employees(нажмите любую клавишу)");
                //Console.ReadLine();
                //Console.WriteLine("Последние 10 работников по id до удаления 5 крайних по id работников");

                //var last10Employees = db.Employees.OrderByDescending(emp => emp.Id).Take(10);

                //foreach (var newEmployee in last10Employees)
                //{
                //    Console.WriteLine($"{newEmployee.Id,-4} {newEmployee.Surname,-20} {newEmployee.Name,-15} {newEmployee.MiddleName,-20}");
                //}

                //Console.WriteLine("\nПоследние 10 работников по id после удаления 5 крайних по id работников");

                //var employeesToDelete = db.Employees.OrderByDescending(employee => employee.Id).Take(5);

                //db.Employees.RemoveRange(employeesToDelete);
                //db.SaveChanges();

                //last10Employees = db.Employees.OrderByDescending(emp => emp.Id).Take(10);

                //foreach (var newEmployee in last10Employees)
                //{
                //    Console.WriteLine($"{newEmployee.Id,-4} {newEmployee.Surname,-20} {newEmployee.Name,-15} {newEmployee.MiddleName,-20}");
                //}



                //Console.WriteLine("9. Удаление данных из таблицы Cars(нажмите любую клавишу)");
                //Console.ReadLine();
                //Console.WriteLine("Последние 10 машин по id до удаления 5 крайних по id машин");

                //var last10Cars = db.Cars.OrderByDescending(car => car.Id).Take(10);

                //foreach (var newCar in last10Cars)
                //{
                //    Console.WriteLine($"{newCar.Id, 4} {newCar.Brand, -20} {newCar.Number, -15} {newCar.ClientId, -20}");
                //}

                //Console.WriteLine("\nПоследние 10 машинн по id после удаления 5 крайних по id машин");

                //var carsToDelete = db.Cars.OrderByDescending(car => car.Id).Take(5);

                //db.Cars.RemoveRange(carsToDelete);
                //db.SaveChanges();

                //last10Cars = db.Cars.OrderByDescending(car => car.Id).Take(10);

                //foreach (var newCar in last10Cars)
                //{
                //    Console.WriteLine($"{newCar.Id,4} {newCar.Brand,-20} {newCar.Number,-15} {newCar.ClientId,-20}");
                //}




                Console.WriteLine("10. Обновление данных в таблице Clients(нажмите любую клавишу)");
                Console.ReadLine();
                Console.WriteLine("Последние 10 клиентов по id до обновления их данных");

                var last10Clients = db.Clients.OrderByDescending(client => client.Id).Take(10);

                foreach (var newClient in last10Clients)
                {
                    Console.WriteLine($"{newClient.Id, 4} {newClient.Surname, -20} {newClient.Name,-15} {newClient.MiddleName, -20} {newClient.Telephone, -15}");
                }

                var random = new Random();

                for (int i = 0; i < last10Clients.Count(); i++)
                {
                    last10Clients.ElementAt(i).Telephone = $"375-{random.Next(100000000, 1000000000)}";
                }

                db.SaveChanges();

                Console.WriteLine("\nПоследние 10 клиентов по id после обновления их данных");

                last10Clients = db.Clients.OrderByDescending(client => client.Id).Take(10);

                foreach (var newClient in last10Clients)
                {
                    Console.WriteLine($"{newClient.Id,4} {newClient.Surname,-20} {newClient.Name,-15} {newClient.MiddleName,-20} {newClient.Telephone,-15}");
                }
            }
        }
    }
}
