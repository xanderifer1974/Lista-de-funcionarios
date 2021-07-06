using System.Collections.Generic;

namespace ListaFuncionariosBussiness.Bussiness
{
   public class FuncionarioBussiness
    {
        public int QuantidadeDeFuncionarios { get; set; }

        private double Percentual { get; set; }

        public int IdDoFuncionario { get; set; }       
        

        public FuncionarioBussiness(int quantidade)
        {
            QuantidadeDeFuncionarios = quantidade;
          
        }

        public void AdicionaFuncionarios(List<Funcionario>Lista, int id, string nome, double salario)
        {
           Lista.Add(new Funcionario(id,nome,salario));
        }

        public string AumentarFuncionario(List<Funcionario> Lista,int matricula,double aumento)
        {
           bool hasFuncionario = false;
           hasFuncionario = ConsultaFuncionario(Lista,matricula);     
           string retorno = "";          
           if(hasFuncionario)
            {
               Funcionario func = Lista.Find(x => x.Id == matricula);
               func.AumentarSalario(aumento);
               retorno = "Funcionario id " + matricula + " foi aumentado";
            }
            else
            {
                retorno = "Id " + matricula + " não encontrado";
            }

            return retorno;
          
        }

        public bool ConsultaFuncionario(List<Funcionario> Lista,int id)
        {
            Funcionario func = Lista.Find(x => x.Id == id);
            if(func != null)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        
       

    }
}
