namespace TodoList
{
    public class TodoItem
    {
        public string Titulo;
        public string Nota;

        public TodoItem(string Titulo,string Nota){/*CARACTERISTICA DE UM CONSTRUTOR,COMO DIFERENCIAR DO METODO?
        O NOME DO CONSTRUTOR DEVE SER IGUAL A DA CLASSSE
        ELE NAO TEM TIPO DE RETORNO,ELE INSTANCIA UMA CLASSE E RETORNA UM OBJETO */
            this.Titulo = Titulo;
            this.Nota = Nota;
        }
    }
}