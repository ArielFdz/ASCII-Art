# Image to ASCII Art Converter in C#

This C# program allows you to convert images into ASCII art directly in the console. It's a fun way to experiment with your favorite images!

## How It Works

The program prompts the user to provide the full path of the image they want to convert into ASCII art. Once a valid path is provided, the program loads the image, transforms it into an ASCII representation, and displays it in the console.

The conversion process involves converting each pixel of the image into an ASCII character corresponding to the pixel's grayscale level. The darker the grayscale tone, the denser character is used to represent it in ASCII.

## Usage

1. Clone this repository to your local machine.

2. Open the project in your preferred development environment that supports .NET Core (e.g., Visual Studio Code).

3. Run `dotnet restore` to restore the project dependencies.

4. Compile and run the program using the `dotnet run` command.

5. Follow the instructions in the console to input the path of the image you want to convert.

6. Watch as the image is transformed into ASCII art in the console.

7. Optionally, you can generate multiple consecutive drawings by responding "S" when prompted to generate another drawing.


## Requirements

- .NET Core 3.1 or higher.

> [!NOTE]
>  The program executable is available now.
