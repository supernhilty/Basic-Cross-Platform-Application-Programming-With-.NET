
using AutomobileLibrary.BussinessObject;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        //Inititalize car list
        private static List<Car> CarList = new List<Car>
        {
            new Car
            {
                CarID = 1,
                CarName = "Test",
                Manufacturer = "Honda",
                Price = 30000,
                ReleaseYear = 2021
            },
             new Car
            {
                CarID = 2,
                CarName = "VF8",
                Manufacturer = "VinFast",
                Price = 50000,
                ReleaseYear = 2022
            },
              new Car
            {
                CarID = 3,
                CarName = "VF9",
                Manufacturer = "VinFast",
                Price = 80000,
                ReleaseYear = 2023
            },
               new Car
            {
                CarID = 4,
                CarName = "Lux 20",
                Manufacturer = "VinFast",
                Price = 30000,
                ReleaseYear = 2020
            },
        };
        //Using Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance 
        { 
            get 
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
                
            } 
        }

        public List<Car> GetCarList => CarList;

        public Car? GetCarByID(int carID)
        {
            Car? car = CarList.SingleOrDefault(pro=>pro.CarID == carID);
            return car;
        }

        public void AddNew(Car car)
        {
            if(GetCarByID(car.CarID)!=null) {
                throw new Exception("Car has already existed!");
            }
            CarList.Add(car);
        }

        public void UpdateCar(Car car)
        {
            if (GetCarByID(car.CarID) == null)
            {
                throw new Exception("Car has not existed!");
            }
            CarList[CarList.IndexOf(car)] = car;
        }

        public void RemoveCar(int CarID)
        {
            if (GetCarByID(CarID) == null)
            {
                throw new Exception("Car has not existed!");
            }
            CarList.Remove(GetCarByID((int)CarID));
        }
    }
}
