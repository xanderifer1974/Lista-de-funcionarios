using ListaFuncionariosBussiness;
using ListaFuncionariosBussiness.Bussiness;
using System;
using System.Collections.Generic;

namespace ListaFuncionarios
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registrared?");
            int qtdFunc = int.Parse(Console.ReadLine());
            FuncionarioBussiness employeesManager = new FuncionarioBussiness(qtdFunc);
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            while (qtdFunc > 0)
            {
                Console.WriteLine("Enter with id?");
                int id = int.Parse(Console.ReadLine());
                bool hasfunc = employeesManager.ConsultaFuncionario(listaFuncionario, id);
                if (!hasfunc)
                {
                    Console.WriteLine("Enter with name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter with salary?");
                    double salary = double.Parse(Console.ReadLine());
                   
                    employeesManager.AdicionaFuncionarios(listaFuncionario,id, name,salary);
                    --qtdFunc;
                }
                else
                {
                    Console.WriteLine("Matrícula: " + id + " já cadastrada!");
                }
             
            }

            Console.Write("Enter the employee id that will have salary increase:");
            int idFunc = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage:");
            double perct = double.Parse(Console.ReadLine());
            perct = perct / 100;
            string retorno = employeesManager.AumentarFuncionario(listaFuncionario, idFunc, perct);
            Console.WriteLine(retorno);

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Update List of Employees:");
            foreach(var item in listaFuncionario)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }
    }
}
