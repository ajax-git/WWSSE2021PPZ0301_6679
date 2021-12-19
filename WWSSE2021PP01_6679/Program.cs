/*
    Napisz program wyświetlający na konsoli następujący kształt:
    X
    XX
    XXX
    XXXX
    XXXXX
*/

string text = "X";
Console.WriteLine(text);

for(int i = 1; i <= 4; i++)
{
    text = text + 'X';
    Console.WriteLine(text);
}
