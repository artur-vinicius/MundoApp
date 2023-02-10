using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MundoApp
{
    class NCidade
    {
        private static List<Cidade> cidades = new List<Cidade>();

        public static void Inserir(Cidade c)
        { // C - Create
            Abrir();
            cidades.Add(c);
            Salvar();
        }
        
        public static List<Cidade> Listar()
        {
            Abrir();
            return cidades;
        }
        public static Cidade Listar(int id)
        {
            // Encontra, se existir, uma turma com o id
            foreach (Cidade obj in cidades)
                if (obj.Id == id) return obj;
            return null;
        }
        public static void Atualizar(Cidade c)
        { // U - Update
            Abrir();
            Cidade obj = Listar(c.Id);
            obj.Nome = c.Nome;
            obj.Populacao = c.Populacao;
            obj.IdEstado = c.IdEstado;
            Salvar();
        }
        public static void Excluir(Cidade c)
        { // D - Delete
            Abrir();
            cidades.Remove(Listar(c.Id));
            Salvar();
        }


        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Cidade>));
                f = new StreamReader("./aluno.xml");
                cidades = (List<Cidade>)xml.Deserialize(f);
            }
            catch
            {
                cidades = new List<Cidade>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Cidade>));
            StreamWriter f = new StreamWriter("./aluno.xml", false);
            xml.Serialize(f, cidades);
            f.Close();
        }
        public static List<Cidade> Listar(Estado p)
        {
            Abrir(); // Abre c lista com todos os cidades
            List<Cidade> mapa = new List<Cidade>(); // Lista de cidades da turma c
            foreach (Cidade obj in cidades)
                if (obj.IdEstado == p.Id) mapa.Add(obj);
            return mapa;
        }
    }
}