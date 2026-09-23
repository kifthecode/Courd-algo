
Animal a = new Chat();
a.Parelr();

public class Animal
{

    public virtual void Parelr() => Console.WriteLine("...");

}

public class Chat : Animal
{

    public override void Parelr() => Console.WriteLine("Miaou je serais toujours Miaou que toi ");


}


