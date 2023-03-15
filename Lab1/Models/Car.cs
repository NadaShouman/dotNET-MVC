using static System.Net.WebRequestMethods;

namespace Lab1.Models
{
    public class Car
    {
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? Image { get; set; }
        public string? HtmlDescription { get; set; }
        public DateTime FirstUseDate { get; set; }

        public string Name => $"Name: {Model} From {Manufacturer}";
        public int Duration => DateTime.Now.Year - FirstUseDate.Year;

        public static List<Car> GetCars()
            => new() {
                new Car
                {
                    Manufacturer = "Toyota",
                    Model = "Crolla",
                    Image = "https://toyotaassets.scene7.com/is/image/toyota/Corolla_Cars?fmt=jpg&fit=crop&resMode=bisharp&qlt=80&wid=848&hei=476",
                    HtmlDescription = "<p>Stand out in this fun-to-drive Toyota car." +
                    "It features impressive EPA-estimated fuel economy ratings up to 31/40/34 (city/highway/combined) MPG* on gas models," +
                    "a thoughtful interior design, and aggressive exterior stance that will make an impression everywhere you go.</p>",
                    FirstUseDate = new DateTime(1997, 3, 9)
                },
                new Car
                {
                    Manufacturer = "Honda",
                    Model = "CIVIC SEDAN",
                    Image = "https://automobiles.honda.com/-/media/Honda-Automobiles/Vehicles/2022/Civic-Sedan/Accessories/Promo-Banner/my22-civic-sedan-accessories-1920x350-2x-B.jpg?w=1920&hash=DB6FB6A48DB542D33F4452F134713E67",
                    HtmlDescription = "<p>The Honda Civic is a line of cars manufactured by Honda.</p>",
                    FirstUseDate = new DateTime(1972, 7, 11)
                },
                new Car {
                    Manufacturer = "NISSAN",
                    Model = "SANTRA",
                    Image = "https://www-europe.nissan-cdn.net/content/dam/Nissan/eg/vehicles/campaign/sentra-Desktop-3840X1575-ar-new.jpg.ximg.l_full_m.smart.jpg",
                    HtmlDescription = "<p>The NISSAN SANTRA is a series of japaneese cars.</p>",
                    FirstUseDate = new DateTime(1996, 4, 17)
                },
                new Car {
                    Manufacturer = "Chevrolet",
                    Model = "EQUINOX",
                    Image = "https://www.chevrolet.com/content/dam/chevrolet/na/us/english/index/vehicles/2023/suvs/equinox/01-images/masthead/2023-equinox-masthead-01.jpg?imwidth=1200",
                    HtmlDescription = "<p>The Chevrolet EQUINOX is a sports car produced by Chevrolet.</p>",
                    FirstUseDate = new DateTime(1953, 6, 30)
                },
                new Car {
                    Manufacturer = "Mercedes-Benz",
                    Model = "S-Class",
                    Image = "https://www.mercedes-benz.com.eg/en/passengercars/content-pool/marketing-pool/product-page-stages/s-class-saloon-w222-stage/_jcr_content/par/stageelement.MQ6.0.stage.20191010180400.jpeg",
                    HtmlDescription = "<p>The Mercedes-Benz S-Class is a series of luxury cars.</p>",
                    FirstUseDate = new DateTime(1972, 6, 1)
                },
                new Car {
                    Manufacturer = "BMW",
                    Model = "3 Series",
                    Image = "https://www.bmw-egypt.com/content/dam/bmw/common/all-models/3-series/series-overview/bmw-3er-overview-page-ms-07.jpg/jcr:content/renditions/cq5dam.resized.img.585.low.time1655716068613.jpg",
                    HtmlDescription = "<p>The BMW 3 Series is a line of compact executive cars.</p>",
                    FirstUseDate = new DateTime(1975, 5, 2)
                },
                new Car {
                    Manufacturer = "Audi",
                    Model = "A4",
                    Image = "https://media.hatla2eestatic.com/uploads/ncarmodel/10635/big-up_cb27e5691aee568f47d51f77be98d333.png",
                    HtmlDescription = "<p>The Audi A4 is a line of compact executive cars.</p>",
                    FirstUseDate = new DateTime(1994, 11, 4)
                },
                new Car {
                    Manufacturer = "Porsche",
                    Model = "911",
                    Image = "https://dbz-images.dubizzle.com/images/2023/02/27/83453f905b0544f9991e2ce7998a4fd8-.jpeg?impolicy=legacy&imwidth=480",
                    HtmlDescription = "<p>The Porsche 911 is a line of high-performance sports cars.</p>",
                    FirstUseDate = new DateTime(1963, 9, 12)
                }
            };

    }
}
