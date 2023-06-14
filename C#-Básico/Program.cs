using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     internal class Program
    {
        public class Pessoa
        {
            public string nome;
            public int idade;
            public bool vivo;

        
            
            
        public void matar()
            {
                vivo = false;
            }
        public void viver() {
                
                vivo = true;
            
            }
        public string verificar() {
            if (vivo == true ) {
                    return "Vivo";
            }else 
                {   return "Morto";
                }
            
            }
        }
        public class Paulista : Pessoa
        {
            public string localNasc;

            public Paulista(string nome)
            {
                this.nome = nome;
                localNasc = "São Paulo";
                idade = 27;
            }

        }
            public class Paulistano : Paulista

        {
            private int id;

            public Paulistano() : base("Daniel") {
                localNasc = "Osasco-SP";
                vivo = true;
            
            
            }
            public int getId()
            {
                return id;
            }
           
            public int setID(int id)
            {
                this.id = id;
                return id;
            }
        }
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Ederson";
            p1.idade = 26;
            p1.viver();
            Console.WriteLine("Nome:........: {0}", p1.nome);
            Console.WriteLine("Idade:.......: {0}", p1.idade);
            Console.WriteLine("Status:......: {0}", p1.verificar());
            Console.ReadLine();
            
            Paulista p2 = new Paulista("Daniel");
            p1.idade = 32;
            p2.localNasc = "São Paulo";
            p2.viver();
            Console.WriteLine("Nome:........: {0}", p2.nome);
            Console.WriteLine("Idade:.......: {0}", p2.idade);
            Console.WriteLine("Status:......: {0}", p2.verificar());
            Console.WriteLine("Local de Nas:..: {0}", p2.localNasc);
            Console.ReadLine() ;

            Paulistano p3 = new Paulistano();
            p3.setID(10987);

            Console.WriteLine("Nome:........: {0}", p3.nome);
            Console.WriteLine("Idade:.......: {0}", p3.idade);
            Console.WriteLine("Status:......: {0}", p3.verificar());
            Console.WriteLine("Local de Nas:.:{0}", p3.localNasc);
            Console.WriteLine("ID............:{0}", p3.getId());
            Console.ReadLine();
        }
    }
}
