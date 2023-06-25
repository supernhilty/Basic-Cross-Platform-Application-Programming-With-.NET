using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int CarID) => CarDBContext.Instance.RemoveCar(CarID);
       
        public Car? GetCarByID(int carID) => CarDBContext.Instance.GetCarByID(carID);


        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;
       

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);
                

        public void UpdateCar(Car car) => CarDBContext.Instance.UpdateCar(car);
       
    }
}
