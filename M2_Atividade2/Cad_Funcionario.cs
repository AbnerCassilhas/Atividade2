using System;


namespace M2_Atividade2
{
    public class Cad_Funcionario
    {
        // Atributos
        public int codigo;
        public string nome;
        public DateTime data_nasc;
        public string uf;
        public string rg;
        public string orgao_exp;
        public string cpf;
        public string ctps;
        public DateTime data_emis_ctps;
        public string gfip;
        public string sexo;
        public string genero;


        // Método Construtor
        public Cad_Funcionario()
        {
            /*
            this.codigo = 0;
            this.nome = "";
            this.data_nasc =0000-00-00 00:00:00;
            this.rg = "";
            this.orgao_exp = "";
            this.cpf = "";
            this.ctps = "";*/
        }

        public Cad_Funcionario(int p_codigo, string p_nome, DateTime p_data_nasc,string p_uf, string p_rg,
                               string p_orgao_exp, string p_cpf, string p_ctps, DateTime data_emis_ctps, 
                               string p_gfip, string p_sexo, string p_genero)
        {
            this.codigo = p_codigo;
            this.nome = p_nome;
            this.data_nasc = p_data_nasc;
            this.uf = p_uf;
            this.rg = p_rg;
            this.orgao_exp = p_orgao_exp;
            this.cpf = p_cpf;
            this.ctps = p_ctps;
            this.data_emis_ctps = data_emis_ctps;
            this.gfip = p_gfip;
            this.sexo = p_sexo;
            this.genero = p_genero; 
        }

        // Métodos get/set
        public int getCodigo() { return this.codigo; }
        public void setCodigo(int codigo) { this.codigo = codigo; }


        public string getNome() { return this.nome; }
        public void setNome(string nome) { this.nome = nome; }

        public DateTime getData_nasc() { return this.data_nasc; }
        public void setData_nasc(DateTime data_nasc) { this.data_nasc = data_nasc; }

        public string getUf() { return this.uf; }
        public void setUf(string uf) { this.uf = uf; }


        public string getRg() { return this.rg; }
        public void setRg(string rg) { this.rg = rg; }


        public string getOrgao_exp() { return this.orgao_exp; }
        public void setOrgao_exp(string orgao_exp) { this.orgao_exp = orgao_exp; }


        public string getCpf() { return this.cpf; }
        public void setCpf(string cpf) { this.cpf = cpf; }


        public string getCtps() { return this.ctps; }
        public void setCtps(string ctps) { this.ctps = ctps; }


        public DateTime getData_emis_ctps() { return this.data_emis_ctps; }
        public void setData_emis_ctps(DateTime data_emis_ctps) { this.data_emis_ctps = data_emis_ctps; }


        public string getGfip() { return this.gfip; }
        public void setGfip(string gfip) { this.gfip = gfip; }


        public string getSexo() { return this.sexo; }
        public void setSexo(string sexo) { this.sexo = sexo; }


        public string getGenero() { return this.genero; }
        public void setGenero(string genero) { this.genero = genero; }

    }
}
