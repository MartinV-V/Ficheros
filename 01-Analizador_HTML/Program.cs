using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Pedir la ruta del archivo HTML
        Console.Write("Escribe la ruta del archivo HTML: ");
        string ruta = Console.ReadLine();

        string html;
        using (StreamReader sr = new StreamReader(ruta))
        {
            html = sr.ReadToEnd();
        }

        using (StreamWriter sw = new StreamWriter("salida.csv"))
        {
            // Guardar la URL de la página en la primera línea del CSV

            sw.WriteLine("id,texto,url");

            int id = 1;
            int pos = 0;

            while (true)
            {
                int startTag = html.IndexOf("<a", pos, StringComparison.OrdinalIgnoreCase);
                if (startTag == -1) break;

                // Buscar el atributo href
                int hrefStart = html.IndexOf("href=", startTag, StringComparison.OrdinalIgnoreCase);
                if (hrefStart == -1) break;// si no encuentra href, salir

                char quote = html[hrefStart + 5]; // Comprueba si usa " o '
                int urlStart = hrefStart + 6; // comprueba donde comienza la URL
                int urlEnd = html.IndexOf(quote, urlStart); // encuentra el final de la URL
                if (urlEnd == -1) break; // si no encuentra el final, salir

                // Extraer la URL entre las comillas
                string url = html.Substring(urlStart, urlEnd - urlStart);

                // Extraer el texto entre las etiquetas <a> y </a>
                int tagEnd = html.IndexOf('>', urlEnd); // encuentra el final de la etiqueta <a>
                if (tagEnd == -1) break;// si no encuentra el final, salir

                int closeTag = html.IndexOf("</a>", tagEnd, StringComparison.OrdinalIgnoreCase);// encuentra la etiqueta de cierre </a>
                if (closeTag == -1) break;// si no encuentra el cierre, salir

                // Extraer el texto entre las etiquetas
                string texto = html.Substring(tagEnd + 1, closeTag - tagEnd - 1);

                // Escribir la línea en el archivo CSV
                sw.WriteLine($"{id},\"{texto}\",\"{url}\"");

                // Mover la posición más allá de la etiqueta de cierre para la siguiente iteración
                pos = closeTag + 4;
                // Incrementar el ID
                id++;
            }
        }

        Console.WriteLine("Proceso completado. Se generó el archivo salida.csv");
    }
}