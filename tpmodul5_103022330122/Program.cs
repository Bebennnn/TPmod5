using System;

class utama
{ 
    static void Main()
    {
        HaloGeneric.SapaUser(" Benaya");
    }
}

class HaloGeneric
{
    public static void SapaUser<T> (T nama)
    {
        Console.WriteLine("Halo User" + nama);
    }
}
