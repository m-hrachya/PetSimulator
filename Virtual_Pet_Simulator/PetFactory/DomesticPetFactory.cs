public class DomesticPetFactory : IPetFactory {
    public ICat createCat() {
        return new SimpleCat();
    }
    public IDog createDog() {
        return new SimpleDog();
    }
}