using System;
using System.Reflection;
using System.Windows.Forms;

public class Funcionario

{
    public string name = "";
    public string cpf;
    public double rg;
    public string email;
    public string celular;
    public string dataNasc;
    public string estadoCiv;
    public string endereco;
    public string cidade;
    public string estado;
    public double salario;
    public string funcao;

    public string VerificaFunc( string funcao)
    {
        if ( funcao == "Administrador")
        {
            string valor = "10000";
            return valor;
        }
    }

}