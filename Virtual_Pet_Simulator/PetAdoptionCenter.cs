public class PetAdoptionCenter {
    private static PetAdoptionCenter? instance = null;
    private static IPetFactory? petFactory = null;
    public static PetAdoptionCenter getInstance() {
        if (instance == null) {
            instance = new PetAdoptionCenter();
        }
        return instance;
    }
    private PetAdoptionCenter() {}
    public void listAvailablePets() {
        Console.WriteLine("Available pets are: Dog, Wolf, Cat And Lion.");
    }
    public void setPetFactory(string type) {
        if (type == "Domestic") {
            if (petFactory == null || petFactory is WildPetFactory) {
                petFactory = new DomesticPetFactory();
            }
        } else if (type == "Wild") {
            if (petFactory == null || petFactory is DomesticPetFactory) {
                petFactory = new WildPetFactory();
            }
        } else {
            Console.WriteLine("No such type of animals!");
        }
    }
    public ICat? adoptCat() {
        if (petFactory != null) {
            return petFactory.createCat();
        }
        return null;
    }
    public IDog? adoptDog() {
        if (petFactory != null) {
            return petFactory.createDog();
        }
        return null;
    }
}