using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Data.SqlClient;

namespace FrmPrincipal
{
    public class Alumno
    {
        public int id;
        public  string nombre;

        public int Id
        {
            get
            {
                return this.id;
            }
            set { this.id = value; }
        }

        public string Nombre
        { 
            get
            { return this.nombre; }
            set { this.nombre = value; }
        }

        public Alumno(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Alumno()
        {

        }

        public static void Serializanding(object Path)
        {

            Alumno alum = new Alumno();
            XmlTextReader reader;
            XmlSerializer ser;

            reader = new XmlTextReader((string)Path);
            ser = new XmlSerializer(typeof(Alumno));
            alum = (Alumno)ser.Deserialize(reader);
            Console.WriteLine(alum.Mostrar());
            reader.Close();           
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre" + this.nombre);
            sb.AppendLine("Id" + this.id);
            return sb.ToString();
        }
    }
}
