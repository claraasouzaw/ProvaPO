
using System;

public class Verificar
{
    public string nome;
    public string cpf;
    public string profissao;
    public string sexo;
    public int idade;
    public int inicioP;
    private bool Homem;
    private bool Professor;
    private bool AgenteSeguranca;

    public Verificar(string nome, string cpf, string profissao, string sexo, int idade, int inicioP, bool Homem, bool Professor, bool AgenteSeguranca)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.profissao = profissao;
        this.sexo = sexo;
        this.idade = idade;
        this.inicioP = inicioP;
        this.Homem = Homem;
        this.Professor = Professor;
        this.AgenteSeguranca = AgenteSeguranca;
    }

    public int CalcularPontosFaltantesAposentadoria()
    {
        int pontosMinimos;

        if (Homem)
        {
            pontosMinimos = Professor ? 95 : 105;
        }
        else
        {
            pontosMinimos = Professor ? 85 : 95;
        }

        int pontosAtuais = idade + inicioP;

        return Math.Max(0, pontosMinimos - pontosAtuais);
    }

    // Métodos Get e Set
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Nascimento
    {
        get { return idade; }
        set { idade = value; }
    }

    public int InicioP
    {
        get { return inicioP; }
        set {inicioP = value; }
    }

    public bool EHomem
    {
        get { return Homem; }
        set { Homem = value; }
    }

    public bool EProfessor
    {
        get { return Professor; }
        set { Professor = value; }
    }

    public bool EAgenteSeguranca
    {
        get { return AgenteSeguranca; }
        set { AgenteSeguranca = value; }
    }







}