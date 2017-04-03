using System;
using System.IO;
using System.Linq;
using FilesAndFolders.SampleData;

namespace FilesAndFolders
{
    class Program
    {
        /// <summary>
        /// Vasim ukolem je implementovat nize uvedene metody FileSystemWatcher a FileEqualityComparer
        /// </summary>
        static void Main(string[] args)
        {
            FileEqualityComparer();
            FileSystemWatcher();
        }

        /// <summary>
        /// Pomocí třídy FileSystemWatcher sledujte složku SampleData v projektu FilesAndFolders.
        /// V okamžiku když dojde ve složce k vytvoření nového souboru s příponou.txt,
        /// vypište do konzole vhodné hlášení (ostatní typy souborů ignorujte).
        /// V rámci testování v dané složce nejprve vytvořte soubor "text5.txt", dále pak "data.xml" 
        /// (nemělo by dojít k vyvolání obsluhy události Created třídy FileSystemWatcher)
        /// </summary>
        private static void FileSystemWatcher()
        {
            // TODO...

        }

        /// <summary>
        /// Vytvořte metodu, která bude brát jako parametry cesty ke dvěma souborům, 
        /// které pak porovná(zjistí, zda jsou soubory identické). 
        /// V případě že jsou totožné, vrátí true, jinak false.
        /// Testování proveďte nejdříve na souborech text1.txt a text2.txt (false)
        /// následně pak na text1.txt a text3.txt (metoda by měla vrátit true)
        /// </summary>
        private static void FileEqualityComparer()
        {
            // TODO...

        }
    }
}
