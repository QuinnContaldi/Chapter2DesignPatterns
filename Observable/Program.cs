// See https://aka.ms/new-console-template for more information

using ObservableDesignPattern;

Console.WriteLine("Hello, Operator!");

Commander General_Black = new Commander();

Squad RedSquad = new Squad("Red Squad", "Viper Company", 8 );
RedSquad.AddSoldier( new Marine ("John Alexander", 30, "Male", "001", "Sergeant", "Drone Operator", new SMG("M4PDW", new ArmorPiercingRounds())));
RedSquad.AddSoldier(new Marine("Jane Ghost", 28, "Female", "002", "Corporal", "Anti Drone Operator", new SMG("M4PDW", new HollowPointRounds())));
RedSquad.AddSoldier( new Marine("Mike Lapez", 35, "Male", "003", "1st Lieutenant", "Squad Leader", new AssaultRifle("M5A1", new ArmorPiercingRounds())));
RedSquad.AddSoldier( new Marine("Anna Gray", 25, "Female", "004", "Private", "Medic", new AssaultRifle("SPZ-05", new HollowPointRounds())));
RedSquad.AddSoldier( new Marine("Wolf Jackson", 22, "Male", "005", "Corporal", "Designated Marksman", new Sniper("M970", new ArmorPiercingRounds())));
RedSquad.AddSoldier( new Marine("Lucy Lane", 22, "Female", "005", "Private", "Automatic Rifleman", new MachineGun("ZVH-98", new HollowPointRounds())));
RedSquad.AddSoldier(new Marine("Ryan Dhaul", 38, "Male", "007", "Gunnery Sergeant", "Grenadier", new AssaultRifle("SPZ-05 Grenader", new ExplosiveRounds())));
RedSquad.AddSoldier( new Marine("Sophia Rose", 29, "Female", "008", " 2nd Lieutenant", "Assistant Squad Leader", new AssaultRifle("M4A1", new ArmorPiercingRounds())));

Squad BlackSquad = new Squad("Black Squad", "Black Company", 6 );
BlackSquad.AddSoldier(new SpecOps("John Ghost", 32, "Male", "SOP001", "Captain", "Team Leader", new SMG("Suppressed SPZ02_300BLK", new ArmorPiercingRounds()), "Stealth Operative"));
BlackSquad.AddSoldier(new SpecOps("Sarah Shadow", 29, "Female", "SOP002", "Lieutenant", "Sniper", new Sniper("Suppressed M1000", new ArmorPiercingRounds()), "Stealth Operative"));
BlackSquad.AddSoldier(new SpecOps("Tom Gray", 35, "Male", "SOP003", "Sergeant", "Demolitions Expert", new MachineGun("Suppressed ZVH-110", new ArmorPiercingRounds()),  "Stealth Operative"));
BlackSquad.AddSoldier(new SpecOps("Jane Salee", 27, "Female", "SOP004", "Sergeant", "CQB Specialist", new Shotgun("Suppressed ZHH_12G", new ArmorPiercingRounds()), "Stealth Operative"));
BlackSquad.AddSoldier(new SpecOps("Mike Jones", 30, "Male", "SOP005", "Corporal", "Communications", new SMG("Suppressed SPZ02_300BLK", new ArmorPiercingRounds()), "Stealth Operative"));
BlackSquad.AddSoldier(new SpecOps("Emma Lilly", 31, "Female", "SOP006", "Lieutenant", "Medic", new AssaultRifle("Suppressed M5A1", new ArmorPiercingRounds()), "Stealth Operative"));

Tank Tank1 = new Tank("Tank 1", "Black Company", "ZARA-X", "30", "120 MM");
General_Black.RegistorObserver(RedSquad);
General_Black.NotifyObserver("Take the Bridge!");
RedSquad.ExecuteOrders();
Console.WriteLine("--------------------------------");
Console.WriteLine("Sending in renforment orders to Black Squad! Hold on Red Squad!");
General_Black.RegistorObserver(BlackSquad);
General_Black.NotifyObserver("Black Squad Take The Bridge!");
General_Black.RegistorObserver(Tank1);
General_Black.NotifyObserver("Take The Bridge!");
Tank1.ExecuteOrder();
Console.WriteLine("Change ammo we have armored units in bounds");
BlackSquad.ChangeAttack(new ArmorPiercingRounds());
RedSquad.ChangeAttack(new ArmorPiercingRounds());
General_Black.NotifyObserver("Kill armored units");
BlackSquad.ExecuteOrders();
RedSquad.ExecuteOrders();

