using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace MundoApp
{
    class NEstado
    {
        private static List<Estado> estados = new List<Estado>();

        public static void Inserir(Estado e)
        {
            Abrir();

            int id = 0;
            foreach (Estado obj in estados)
                if (obj.Id > id) id = obj.Id;
            e.Id = id + 1;
            estados.Add(e);
            Salvar();
        }
        public static List<Estado> Listar()
        {
            Abrir();
            return estados;
        }
        public static void Atualizar(Estado e)
        {
            Abrir();

            foreach (Estado obj in estados)
                if (obj.Id == e.Id)
                {
                    obj.Nome = e.Nome;
                    obj.Populacao = e.Populacao;
                    obj.IdPais = e.IdPais;
                }
            Salvar();
        }
        public static void Excluir(Estado e)
        {
            Abrir();

            Estado x = null;
            foreach (Estado obj in estados)
                if (obj.Id == e.Id) x = obj;
            if (x != null) estados.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {

                XmlSerializer xml = new XmlSerializer(typeof(List<Estado>));

                f = new StreamReader("./estados.xml");

                estados = (List<Estado>)xml.Deserialize(f);
            }
            catch
            {
                estados = new List<Estado>();
            }

            if (f != null) f.Close();
        }
        public static void Salvar()
        {

            XmlSerializer xml = new XmlSerializer(typeof(List<Estado>));

            StreamWriter f = new StreamWriter("./estados.xml", false);

            xml.Serialize(f, estados);

            f.Close();
        }
        public static List<Estado> Listar(Pais p)
        {
            Abrir();

            List<Estado> mapa = new List<Estado>();
            foreach (Estado obj in estados)
                if (obj.Id == p.Id) mapa.Add(obj);
            return mapa;
        }
    }
}
