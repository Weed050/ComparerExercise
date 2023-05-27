using ShoeExercise;

static void PrintDucks(List<Duck> ducks)
{
    foreach (Duck duck in ducks)
    {
        Console.WriteLine(duck.Kind.ToString() + " " + duck.Size.ToString() + "-centymetrowa kaczka ");
    }
    Console.WriteLine("\n");
}
List<Duck> ducks = new List<Duck>()
{
    new Duck(){ Kind = KindOfDuck.Decoy,Size = 17},
    new Duck(){ Kind = KindOfDuck.Muscovy,Size = 12},
    new Duck(){ Kind = KindOfDuck.Mallard,Size = 15},
    new Duck(){ Kind = KindOfDuck.Muscovy,Size = 19},
    new Duck(){ Kind = KindOfDuck.Decoy,Size = 18},
    new Duck(){ Kind = KindOfDuck.Mallard,Size = 20},
};
//ducks.Sort();
PrintDucks(ducks);

DuckComparerBySize sizeComparer = new DuckComparerBySize();
//ducks.Sort(sizeComparer);
//PrintDucks(ducks);

DuckComparerByKind kindComparer = new DuckComparerByKind();
//ducks.Sort(kindComparer);
//PrintDucks(ducks);

//utworzenie instancji porównującej, potem wybranie jak sortować
DuckComparer comparerDuck = new DuckComparer();
comparerDuck.SortBy = SortCriteria.SizeThenKind;
ducks.Sort(comparerDuck);
PrintDucks(ducks);

comparerDuck.SortBy = SortCriteria.KindThenSize;
ducks.Sort(comparerDuck);
PrintDucks(ducks);

Console.ReadKey();

