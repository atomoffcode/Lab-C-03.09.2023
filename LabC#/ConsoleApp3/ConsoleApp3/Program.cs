using ConsoleApp3;

Car car = new Car("BMW", 20000, 200);
Car car1 = new Car("Mercedes", 50000, 220);
Car car2 = new Car("Maserati", 550000, 220);

Gallery gallery = new Gallery("Kazimin masinlari");

gallery.AddCar(car);
gallery.AddCar(car1);
gallery.AddCar(car2);

Console.WriteLine("Qalerayanin adi : " + gallery.Name);
gallery.GetGalleryCarShow();

gallery.SumCar();



gallery.DeleteCar(1);

gallery.GetGalleryCarShow();
Console.WriteLine("kazim ziyandadi");

Console.WriteLine(gallery.Cars.Length);








