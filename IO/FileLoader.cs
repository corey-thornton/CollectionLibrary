using Library.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Library.IO
{
    class FileLoader
    {
        ICollection<Game> loadedGames;
        public FileLoader()
        {
            this.loadedGames = new List<Game>();
        }
        #region Methods
        private void DeserializeGames(string filename)
        {
            if (filename.Equals(string.Empty) || filename == null)
            {
                return;
            }
            else
            {
                Console.WriteLine("Reading with Stream");
                // Create an instance of the XmlSerializer.
                XmlSerializer serializer =
                new XmlSerializer(typeof(List<Game>));

                // Declare an object variable of the type to be deserialized.

                try
                {
                    using (Stream reader = new FileStream(filename, FileMode.Open))
                    {
                        // Call the Deserialize method to restore the object's state.
                        this.loadedGames = (List<Game>)serializer.Deserialize(reader);
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("there was an error with loading the file");
                }

            }

        }

        public ICollection<Game> getGamesFromFile()
        {
            this.DeserializeGames("../../../Files/GameFile.xml");
            return this.loadedGames;
        }
    }
    #endregion
}

