using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MundoApp
{
    class NPais
    {
        //private Pais[] pais = new Pais[10];
        private static List<Pais> pais = new List<Pais>();
        public static void Inserir(Pais p)
        {
            Abrir();
            // Procurar o maior Id
            int id = 0;
            foreach (Pais obj in pais)
                if (obj.Id > id) id = obj.Id;
            p.Id = id + 1;
            pais.Add(p);
            Salvar();
        }
        public static List<Pais> Listar()
        {
            Abrir();
            return pais;
        }
        public static void Atualizar(Pais p)
        {
            Abrir();
            // Percorrer a lista de turma procurando o id informado (p.Id)
            foreach (Pais obj in pais)
                if (obj.Id == p.Id)
                {
                    obj.Nome = p.Nome;
                    obj.Populacao = p.Populacao;
                }
            Salvar();
        }
        public static void Excluir(Pais p)
        {
            Abrir();
            // Percorrer a lista de turma procurando o id informado (p.Id)
            Pais x = null;
            foreach (Pais obj in pais)
                if (obj.Id == p.Id) x = obj;
            if (x != null) pais.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // Objeto que serializa (transforma) uma lista de pais em um texto em XML
                XmlSerializer xml = new XmlSerializer(typeof(List<Pais>));
                // Objeto que abre um texto em um arquivo
                f = new StreamReader("./pais.xml");
                // Chama a operação de desserialização informando a origem do texto XML
                pais = (List<Pais>)xml.Deserialize(f);
            }
            catch
            {
                pais = new List<Pais>();
            }
            // Fecha o arquivo
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            // Objeto que serializa (transforma) uma lista de pais em um texto em XML
            XmlSerializer xml = new XmlSerializer(typeof(List<Pais>));
            // Objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./pais.xml", false);
            // Chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, pais);
            // Fecha o arquivo
            f.Close();
        }
    }
}
