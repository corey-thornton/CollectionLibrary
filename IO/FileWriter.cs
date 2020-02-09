using Library.model;
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

            Stream fs = new FileStream("../../../Files/GameFile.xml", FileMode.Create);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            settings.NewLineOnAttributes = true;
            settings.Encoding = Encoding.UTF8;
            XmlWriter writer = XmlWriter.Create(fs, settings);


            this.gameSerializer.Serialize(writer, games);
            writer.Close();

        }
    }
}
