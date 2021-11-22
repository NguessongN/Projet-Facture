using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serializations
{
    public enum Modes
    {
        JSON,
        //Binary,
        Xml,
    }

    public class Serializer<T>
    {
        private string Path { get; }
        public Modes Mode { get; }

        public Serializer(string path = null, Modes mode = Modes.JSON)
        {
            this.Mode = mode;
            if (path == null)
            {
                path = GetPath();
            }

            Path = path;
            FileInfo fi = new FileInfo(Path);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
        }

        private string GetPath()
        {
            /*
            if (Mode == Modes.Binary)
            {
                return "Data/datas.bin";
            } else if (Mode == Modes.Xml)
            //*/
            if (Mode == Modes.Xml)
            {
                return "Data/datas.xml";
            }

            return "Data/datas.json";
        }

        public void Serialize(List<T> datas)
        {
            FileInfo fi = new FileInfo(Path);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            switch (Mode)
            {
                //case Modes.Binary:
                //  SerializeBinary(datas);
                //break;
                case Modes.Xml:
                    SerializeXml(datas);
                    break;
                case Modes.JSON:
                default:
                    SerializeJson(datas);
                    break;
            }
        }

        public List<T> Deserialize()
        {
            FileInfo fi = new FileInfo(Path);
            if (!fi.Directory.Exists || !fi.Exists)
            {
                return new List<T>() { };
            }

            switch (Mode)
            {
                //case Modes.Binary:
                //  return DeserializeBinary();
                case Modes.Xml:
                    return DeserializeXml();
                case Modes.JSON:
                default:
                    return DeserializeJson();
            }
        }

        private void SerializeXml(List<T> datas)
        {
            using (StreamWriter file = new StreamWriter(Path, true))
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<T>));
                serialiser.Serialize(file.BaseStream, datas);
            }
        }

        private List<T> DeserializeXml()
        {
            using (StreamWriter file = new StreamWriter(Path, true))
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<T>));
                return (List<T>)serialiser.Deserialize(file.BaseStream);
            }
        }

        private void SerializeJson(List<T> datas)
        {
            using (StreamWriter file = File.CreateText(Path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, datas);
            }
        }

        private List<T> DeserializeJson()
        {
            using (StreamReader file = File.OpenText(Path))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (List<T>)serializer.Deserialize(file, typeof(List<T>));
            }
        }

        /*
        private void SerializeBinary(List<T> datas)
        {
            using StreamWriter file = new StreamWriter(Path, true);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file.BaseStream, datas);
        }

        private List<T> DeserializeBinary()
        {
            using StreamReader file = new StreamReader(Path, true);
            BinaryFormatter bf = new BinaryFormatter();
            return (List<T>)bf.Deserialize(file.BaseStream);
        }
        //*/
    }
}
