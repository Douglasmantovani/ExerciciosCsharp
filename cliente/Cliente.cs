using System;


namespace Bytebank{
    public class Cliente{ 
            public  string Nome{get;set;}
            public  string Senha{get;set;}
            public string Email{get;set;}
            public  string cpf{get;set;}




        public Cliente(string Nome, string Email,string cpf)     
        {
            this.Nome = Nome;
            this.cpf = cpf;
            this.Email = Email;
        }
        public bool trocasenha(string senha){
            if((Senha.Length > 6) && (Senha.Length < 16))
            {
                this.Senha = senha;
                return true;
            }else {
                return false;
            }
        }
    }
}




