
using Pattern_Behavior_Memento.Models.Caretaker;
using Pattern_Behavior_Memento.Models.Original;

Man man = new Man();
Robot robot = new Robot();

man.Clothes = "Джинсы, футболка, кеды";
robot.Backpack = man.UnDress();

man.Clothes = "шорты";

man.Dress(robot.Backpack);

Console.ReadLine();