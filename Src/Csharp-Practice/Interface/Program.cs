// See https://aka.ms/new-console-template for more information
using Interface;


/*
 
 IVehiculo => Drive ,Refuel gasoline 
CAR=>
 
 */

Audi audi = new Audi();
Ferrari f20 = new Ferrari();
Car car = new Car(20);
car.Drive();


Car mycar = new Car(f20);
mycar.EstablishEngine();

