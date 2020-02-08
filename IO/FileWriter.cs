using Library.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Library.IO
{
    class FileWriter
    {
        private XmlSerializer gameSerializer;

        public FileWriter()
        {
            this.gameSerializer = new XmlSerializer(typeof(List<Game>));
        }

        public void writeGamesToXmlFile(ICollection<Game> games)
        {

            Stream fs = new FileStream( "../../../Files/GameFile.xml", FileMode.Create);

            XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode);

            this.gameSerializer.Serialize(writer, games);
            writer.Close();

        }
    }
}
