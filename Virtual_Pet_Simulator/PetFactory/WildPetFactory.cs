public class WildPetFactory : IPetFactory {
    public ICat createCat() {
        return new Lion();
    }
    public IDog createDog() {
        return new Wolf();
    }

}