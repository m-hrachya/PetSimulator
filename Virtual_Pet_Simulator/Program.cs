class Program {
    static void entryMessege() {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Adopt Domestic Pets");
        Console.WriteLine("2. Adopt Wild Pets");
        Console.WriteLine("3. Interact with Your Pet");
        Console.WriteLine("4. Exit");
    }
    static void Main() {
        PetAdoptionCenter adoptionCenter = PetAdoptionCenter.getInstance();
        int userResponse = 0;
        bool animalExists = false;
        IPet[] userPets = new IPet[2];
        string petsType = "";
        bool endPoint = false;
        Console.WriteLine("Welcome to the Virtual Pet Adoption Center!\n");
        while (true) {
            entryMessege();
            string input = Console.ReadLine() ?? "0";
            userResponse = int.Parse(input);
            switch (userResponse) {
                case 1 :
                    if (petsType == "Domestic") {
                        Console.WriteLine("\n---------------------");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("\nYou already adopted domestic animals!\n");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("---------------------\n");
                    } else {
                        petsType = "Domestic";
                        adoptionCenter.setPetFactory("Domestic");
                        userPets[0] = adoptionCenter.adoptCat()!;
                        userPets[1] = adoptionCenter.adoptDog()!;
                        animalExists = true;
                        Console.WriteLine("\n---------------------");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("You adopted domestic animals successfully!");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("---------------------\n");
                    }
                    break;
                case 2 :
                    if (petsType == "Wild") {
                        Console.WriteLine("\n---------------------");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("\nYou already adopted wild animals!\n");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("---------------------\n");
                    } else {
                        petsType = "Wild";
                        adoptionCenter.setPetFactory("Wild");
                        userPets[0] = adoptionCenter.adoptCat()!;
                        userPets[1] = adoptionCenter.adoptDog()!;
                        animalExists = true;
                        Console.WriteLine("\n---------------------");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("You adopted wild animals successfully!");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("---------------------\n");
                    }
                    break;
                case 3 :
                    if (animalExists) {
                        Console.WriteLine("\n---------------------");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Your animals are making sounds!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        userPets[0].sound();
                        userPets[1].sound();
                        Console.ResetColor();
                        Console.WriteLine("---------------------");
                        Console.WriteLine("---------------------\n");
                    } else {
                        Console.WriteLine("\n---------------------");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("You need to adopt animals first!");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("---------------------\n");
                    }
                    break;
                case 4 :
                    endPoint = true;
                    Console.WriteLine("\n---------------------");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Have a good day!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("---------------------\n");
                    break;
                default :
                    Console.WriteLine("\n---------------------");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("---------------------\n");
                    break;
            }
            if (endPoint) break;
        }
    }
}
