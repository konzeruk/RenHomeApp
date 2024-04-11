
using ApplicationContextDB.Contexts;
using DTO.Entities;
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

using (var db = new ContextAuthDB(config, true))
{
    var users = new List<UserEntity>
    {
        new UserEntity 
        {
            Login = "admin", 
            Password = "admin",
        },
        new UserEntity
        {
            Login = "user1",
            Password = "user1",
        },
        new UserEntity
        {
            Login = "user2",
            Password = "user2",
        }
    };

    foreach (var user in users)
        db.Add(user);

    db.SaveChanges();
}

using (var db = new ContextHomeDB(config, true))
{
    var homes = new List<HomeEntity>
    {
        new HomeEntity
        {
            City = "Пенза",
            District = "ул. Ленинградская 18, кв. 25",
            Description = "Сдается двухкомнатная квартира со всеми удобствами на длительный срок полностью мебелированная c бытoвoй тexникoй (хoлoдильник, cтиpaльная машина, телeвизоp и интеpнет) порядочным людям.",
            Price = 5000,
            Reservations = new List<ReservationEntity>
            {
                new ReservationEntity
                {
                    StartDate = new DateTime(2024, 5, 2),
                    EndDate = new DateTime(2024, 5, 10)
                }
            }
        },
        new HomeEntity
        {
            City = "Пенза",
            District = "ул. Мира 18, кв. 22",
            Description = "Отличная планировка, просторная кухня-гостиная, родительская спальня со своим санузлом\r\n\r\nCкандинaвский стиль прeдпoлaгaeт плoтную застрoйку и нeкую кулуaрнocть каждого из квартaлов, к котoрым идет cвоя тихая аллeя. Нa бульвaр выходят коммерческие помещения, кафе, магазинчики, там происходят соседские мероприятия. Он притягивает людей, которые хотят каких-то историй.",
            Price = 3000,
            Reservations = new List<ReservationEntity>
            {
                new ReservationEntity
                {
                    StartDate = new DateTime(2024,5,5),
                    EndDate = new DateTime(2024,5,11)
                }
            }
        },
        new HomeEntity
        {
            City = "Пенза",
            District = "ул. Ленина 60, кв. 5",
            Description = "Сдается прекрасная 2-комнатная квартира по ул. Ленина 60, на длительный срок для ответственных арендаторов. Квартира полностью меблирована и оборудована всей необходимой техникой. В наличии кровать для комфортного отдыха. Звоните нам для оперативного просмотра. Квартира свободна для заселения.",
            Price = 7000,
            Reservations = new List<ReservationEntity>
            {
                new ReservationEntity
                {
                    StartDate = new DateTime(2024,5,7),
                    EndDate = new DateTime(2024,5,20)
                }
            }
        }
    };

    foreach(var home in homes)
        db.Add(home);

    db.SaveChanges();
}

using (var db = new ContextReviewDB(config, true))
{
    var reviews = new List<ReviewEntity>
    {
        new ReviewEntity
        {
            Grade = 3,
            IdHome = 3,
            Login = "user1",
            Text = "Квартира в самом центре, рядом с набережной. Высокие потолки, много воздуха. Есть всё необходимое для проживания. Мебель старая, цена и качества не сходится."
        },
        new ReviewEntity
        {
            Grade = 5,
            IdHome = 3,
            Login = "user2",
            Text = "Все отлично, вопросов не было."
        },
        new ReviewEntity
        {
            Grade = 4,
            IdHome = 1,
            Login = "user2",
            Text = "Квартира находится в шаговой доступности от нужных магазинов и остановки. Чистая и уютная квартира"
        },
        new ReviewEntity
        {
            Grade = 5,
            IdHome = 1,
            Login = "user1",
            Text = ""
        },
        new ReviewEntity
        {
            Grade = 5,
            IdHome = 1,
            Login = "user5",
            Text = "Прекрасная квартира все находится очень близко"
        }
    };

    foreach(var review in reviews)
        db.Add(review); 

    db.SaveChanges();
}