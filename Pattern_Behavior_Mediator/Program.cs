
using Pattern_Behavior_Mediator.Models.Colleagues;
using Pattern_Behavior_Mediator.Models.Mediators;

ConcreteMediatr mediatr = new ConcreteMediatr();

Farmer farmer = new Farmer(mediatr);
Cannery cannery = new Cannery(mediatr);
Shop shop = new Shop(mediatr);


mediatr.Farmer = farmer;
mediatr.Cannery = cannery;
mediatr.Shop = shop;

farmer.GrowTomato();

Console.ReadLine();
