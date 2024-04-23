
using System.Drawing;
using ASCII_Art;

do
{
    string path;

    do
    {
        Console.WriteLine("Por favor, proporciona la ruta completa de la imagen:");
        path = Console.ReadLine().Trim();

        if (string.IsNullOrWhiteSpace(path))
        {
            Console.WriteLine("La ruta de la imagen no puede estar vacía.");
        }
        else if (!IsValidImagePath(path))
        {
            Console.WriteLine("La ruta de la imagen no es válida.");
        }
    } while (string.IsNullOrWhiteSpace(path) || !IsValidImagePath(path));

    var img = Image.FromFile(path);
    var image = new Bitmap(img, 150, 200);

    var asciiContent = ASCII.ASCIIGenerator(image);
    Console.WriteLine(asciiContent);

    Console.WriteLine("¿Desea generar otro dibujo? (S/N)");
} while (Console.ReadLine().Trim().ToUpper() == "S");

static bool IsValidImagePath(string path)
{
    try
    {
        using (var img = Image.FromFile(path))
        {
            return true;
        }
    }
    catch
    {
        return false;
    }
}