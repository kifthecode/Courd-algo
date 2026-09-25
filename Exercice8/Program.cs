// Le chenil de la clinique : 5 box, et le poids
// de chaque pensionnaire en kg . c# numerote
// Les cases a partir de 0 : le box 1 est la case 0.

int[] chenil = { 12, 7, 30, 9, 21 };

// Le 3e box : la case 2.
Console.WriteLine($"Box 3 :{chenil[2]} kg");

//Le chiendu 2e box box sort, un chat de 4 kg entre.
chenil[1] = 4;

Console.WriteLine($"Box 2 : {chenil[1]} kg");
Console.WriteLine($"Nombre de box : {chenil.Length}");

