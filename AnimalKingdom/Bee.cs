namespace AnimalKingdom
{
    class Bee : Animal, ICanFly
    {
        public int NumberOfWings { get { return 4 ;} }
        public override string Sound()
        {
            return base.Sound() + "Bee sound";
        }
    }
}