using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using FirebirdSql.Data.FirebirdClient;

namespace ImpressaoZebra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*======================================================================
          ========================= VÁRIÁVEIS GLOBAIS ==========================*/
        string preco = ""; // Preço retornado ne procedure
        string descricao = ""; // Descrição retornada na procedure
        string CODSAP, DESCR, TP, PRC_PROMO, PRC_ORI, INICIO, TFID_DATA_FIM;
        int isMinhaLe = 99;
        string ean = "";
        string desc1 = "", desc2 = ""; //Substrings caso a descrição contenha mais que 10 caracteres
        string s = "";
        bool maisQue20; //Controle do tamanho da descrição
        bool continua = true; // Controle do fluxo de impressão
        Consultas consultas = new Consultas();
        /* =====================================================================*/
        private void BtnPrint_Click(object sender, EventArgs e)
        {

            if (txtEAN.Text == "" && txtIpPDV.Text == "")
            {
                MessageBox.Show("Um ou mais campos obrigatórios não foram informados.\n\n*IP DO PDV\n*CÓDIGO EAN","Campo obigatório não informado", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtIpPDV.Text == "")
            {
                MessageBox.Show("Um ou mais campos obrigatórios não foram informados.\n\n*IP DO PDV", "Campo obigatório não informado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEAN.Text == "")
            {
                MessageBox.Show("Um ou mais campos obrigatórios não foram informados.\n\n*CÓDIGO EAN", "Campo obigatório não informado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            
            continua = true; //Reinicia o controle do fluxo de impressão
            isMinhaLe = 99;// reinicia o controle do Minha LE
            DESCR = null; // Limpa a descrição do Minha LE
            lblPrecoMinhaLe.Visible = false;

            //Conexão com o banco Firebird do PDV
            FbConnection fbConn = new FbConnection("DataSource=" + txtIpPDV.Text + "; Database=" + "C:\\proton\\pdv-client\\dat\\DBECF.gdb" + "; User=SYSDBA; Password=masterkey");
            FbCommand comando = new FbCommand();
            
            // Consulta Minha Le antes para verificar se o produto consultado tem promoção 

            try
            {
                fbConn.Open();
                comando.Connection = fbConn;
                comando.CommandType = CommandType.Text;

                comando.CommandText = "select distinct m.tmer_codigo_barras_ukn as codsap, " +
                                      "m.tmer_nome as DESCR, " +
                                      "p.tfid_tipo_preco as tp, " +
                                      "p.tfid_preco_venda as prc_promo, " +
                                      "e.tmer_preco_venda as prc_ori, " +
                                      "p.tfid_data_inicio as inicio, " +
                                      "p.tfid_data_fim " +
                                      "from tmer_mercadoria m inner join tfid_promocao p on p.tfid_codigo_pri_fk_pk = m.tmer_codigo_pri_pk and " +
                                      "p.tfid_codigo_sec_fk_pk = m.tmer_codigo_sec_pk " +
                                      "inner join tmer_estoque e on e.tmer_unidade_fk_pk = p.tfid_unidade_fk_pk and " +
                                                    "e.tmer_codigo_pri_fk_pk = p.tfid_codigo_pri_fk_pk and " +
                                                    "e.tmer_codigo_sec_fk_pk = p.tfid_codigo_sec_fk_pk " +
                                                    "where p.tfid_tipo_preco = 1 " +
                                                    "and m.tmer_codigo_barras_ukn = (select cod.tmer_codigo_barras_ean_fkn from tmer_codigo_barras cod where cod.tmer_codigo_barras_alter_pk = @COD_BARRALE)" +
                                                    "or m.tmer_codigo_barras_ukn = @COD_BARRALE" +
                                                    " and p.tfid_preco_venda <> e.tmer_preco_venda ";
                                                    //"and p.tfid_data_inicio <= 'now' " +
                                                    //"and p.tfid_data_fim >= 'now' ";
                //comando.Parameters["@COD_BARRA"].Value = txtEAN.Text;
                comando.Parameters.AddWithValue("@COD_BARRALE", txtEAN.Text);
                //comando.Parameters.AddWithValue("@PO_DESCRICAO", descricao);

                FbDataReader ler = comando.ExecuteReader();
                while (ler.Read())
                {
                    CODSAP = ler.GetValue(0).ToString();
                    DESCR = ler.GetValue(1).ToString();
                    TP = ler.GetValue(2).ToString();
                    PRC_PROMO = ler.GetValue(3).ToString();
                    PRC_ORI = ler.GetValue(4).ToString();
                    INICIO = ler.GetValue(5).ToString();
                    TFID_DATA_FIM = ler.GetValue(6).ToString();
                }
                fbConn.Close();
                //fbConn.Dispose();

                //Define as labels como visíveis
                lblCodigoMercadoria.Visible = true;
                lblDescricao.Visible = true;
                lblPrecoRegular.Visible = true;
                lblPrecoMinhaLe.Visible = true;
                lblMinhaLe.Visible = true;
                lblRegular.Visible = true;

                //Define o texto das labels para imprimir os retornos da consulta
                lblCodigoMercadoria.Text = txtEAN.Text;
                lblDescricao.Text = DESCR;
                lblPrecoRegular.Text = PRC_ORI;
                lblPrecoMinhaLe.Text = PRC_PROMO;

                if (DESCR == null)
                {
                    isMinhaLe = 0;
                    lblPrecoMinhaLe.Visible = false;
                    lblMinhaLe.Visible = false;
                    
                }

            // Consulta Não Minha LE
            if (isMinhaLe == 0)
            {
               FbConnection fbConn2 = new FbConnection("DataSource=" + txtIpPDV.Text + "; Database=" + "C:\\proton\\pdv-client\\dat\\DBECF.gdb" + "; User=SYSDBA; Password=masterkey");
               FbCommand comando2 = new FbCommand();
                    fbConn2.Open();
                    comando2.Connection = fbConn2;
                    comando2.CommandType = CommandType.StoredProcedure;

                    comando2.CommandText = "CONSULTA_MERC";
                    comando2.Parameters.AddWithValue("@COD_BARRA", txtEAN.Text);

                    FbDataReader ler2 = comando2.ExecuteReader();
                    while (ler2.Read())
                    {
                        preco = ler2.GetValue(0).ToString();
                        descricao = ler2.GetValue(1).ToString();
                    }
                    fbConn2.Close();

                    //Define as labels como visíveis
                    lblCodigoMercadoria.Visible = true;
                    lblDescricao.Visible = true;
                    lblPrecoRegular.Visible = true;

                    //Define o texto das labels para imprimir os retornos da procedure
                    lblCodigoMercadoria.Text = txtEAN.Text;
                    lblDescricao.Text = descricao;
                    lblPrecoRegular.Text = preco;

                    if (descricao == "") //Caso a descrição volte vazia exibir "Mercadoria não localizada"
                    {
                        lblDescricao.Text = "Mercadoria Não Localizada";
                        lblDescricao.Visible = true;
                        continua = false; // Não seguir para o fluxo de impressão
                    }

                    //Caso a variável descrição retorne preenchida da procedure
                    //deve seguir para o fluxo de impressão abaixo

                    //Tratamento do tamanho da descrição
                    if (descricao.Length >= 19)
                    {   // Divide em duas subsstrings para pular a linha
                        desc1 = descricao.Substring(0, 20); // 20 primeiros caracteres na primeira linha
                        desc2 = descricao.Substring(21);    // 21° caractere em diante na segunda linha
                        maisQue20 = true; // Ativa variável de controle da substring
                    }

            }
            }
            catch (Exception ex) // Tratamento da exceção de conexão com o banco do PDV.
            {
                if (ex.Message.Contains("Unable to complete network request to host"))
                    MessageBox.Show("Não foi possível conectar no PDV informado.\nInforme o IP de outro PDV.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                continua = false; // Desativa a variável de controle do fluxo de impressão
            }
            fbConn.Dispose();


        /*==================  F L U X O  D E  I M P R E S S Ã O  D A  E T I Q U E T A  Z E B R A  ====================*/
           
            
            //Impressão anulada pelo valor NULL
            if (continua == null) // Caso a variável de controle do fluxo de impressão esteja ativada
            {
            

            if (isMinhaLe == 0 && maisQue20 == true) // Caso a variável de controle das substrings esteja ativada
            { // Dividir a descrição da mercadoria em duas linhas
                s = "^XA" +
    "^FO40,25^A0N,36,36^FD" + txtEAN.Text + "^FS" + // Código do produto
    "^FO350,25^A0N,36,36^FD" + desc1 + "^FS" + // Primeira linha da descrição do produto
    "^FO350,55^A0N,36,36^FD" + desc2 + "^FS" + // Segunda linha da descrição do produto
    "^FO40,90^BEN,70,70Y,N^FD" + txtEAN.Text + "^FS" + // Código de barras gerado pela impressora
    "^FO300,90^A0N,116,116^FDR$^FS" + // Campo contendo o indicador monetário (R$) na etiqueta
    "^FO500,100^A0N,90^FD" + preco + "^FS" + // Preço da mercadoria
    "^PQ001,,,N" + // Salto de linha
    "^XZ";
            }
            else if (isMinhaLe == 0 && maisQue20 == false) // Caso a variável de controle do fluxo de impressão esteja desativada
            {
                s = "^XA" +
    "^FO40,25^A0N,36,36^FD" + txtEAN.Text + "^FS" + // Código do produto
    "^FO350,25^A0N,36,36^FD" + descricao + "^FS" + // Descrição da mercadoria em apenas uma linha
    "^FO40,90^BEN,70,70Y,N^FD" + txtEAN.Text + "^FS" + // Código de barras gerado pela impressora
    "^FO300,90^A0N,116,116^FDR$^FS" + // Campo contendo o indicador monetário (R$) na etiqueta
    "^FO500,100^A0N,90^FD" + preco + "^FS" + // Preço da mercadoria
    "^PQ001,,,N" + // Salto de linha
    "^XZ";
            }

            else if (isMinhaLe == 99) // Caso seja Minha Le
            {
                s = "^XA" +
                    "^PR1" +
                    "^FO30,25^A0N,35,35^FD" + DESCR + "^FS" +
                    "^FO50,80^A0B,30,30^FDRegular^FS" +
                    "^FO380,70^GB280,110,100,,1^FS" +
                    "^FO390,80^CF0,30,30^FR^FDClube Minha Le^FS" +
                    "^FO15,80^A0B,30,30^FD" + CODSAP + "^FS" +
                    "^FO90,80^A0N,26,26^FR^FDR$^FS" +
                    "^FO90,105^A0N,26,26^FDUN^FS" +
                    "^FO130,80^A0N,75,75^FD" + PRC_ORI + "^FS" +
                    "^FO390,115^CF0,26,26^FR^FDR$^FS" +
                    "^FO390,140^CF0,26,26^FR^FDUN^FS" +
                    "^FO430,110^CF0,75,75^FR^FD" + PRC_PROMO + "^FS" +
                    "^FO390,195^CF0,25,20^FDVANTAGENS E DESCONTOS EXCLUSIVOS^FS" +
                    "^FO120,150^BEN,45,45Y,N^FD" + txtEAN.Text + "^FS" +
                    "^PQ001,,,N" +
                    "^XZ";
            }

            //Instância da classe PrintDialog para enviar a impressão ao Windows
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            pd.AllowSomePages = true;
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s);
            }
            
        }
            txtEAN.Text = ""; // Limpar o campo do EAN após a execução do fluxo
        }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tratamento da validade do software (Não executar após a data abaixo)
            DateTime validade = DateTime.Parse("31/12/2021");
            if (DateTime.Now.Date >= validade)
            {
                MessageBox.Show("Programa Expirado!\nUtilize o SAP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        //Tratamento do "Enter" no campo do EAN no formulário principal
        private void txtEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                BtnPrint_Click(sender, e);

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyData == Keys.T)
            {
                TesteImpressao testeImpressao = new TesteImpressao();
                testeImpressao.Show();
            }
        }

        private void BtnPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyData == Keys.T)
            {
                TesteImpressao testeImpressao = new TesteImpressao();
                testeImpressao.Show();
            }
        }


    }
}
