using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public enum Status
    {
        list,
        table
    }

    public class CarInfo
    {
        public Car? car { get; set; }
        public Status? status { get; set; }
    }
    public class CarsController : Controller
    {
        public IActionResult GetAll()
        {
            var cars = Car.GetCars();
            return View(cars);
        }

        public IActionResult GetDetails(String CarModel, Status? status)
        {
            var car = Car.GetCars().FirstOrDefault(c => c.Model == CarModel);
            CarInfo info = new CarInfo();
            info.car = car;
            info.status = status;
            return View(info);
        }
    }
}
