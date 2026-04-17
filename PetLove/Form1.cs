using PetLove.PetLoveDB3DataSetTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PetLove
{
    public partial class Form1 : Form
    {
        PetsTableAdapter adapter = new PetsTableAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (adapter.GetData().Count == 0)
            {
                ImportarDadosDoArquivo();
            }

            ConfigurarComponentes();
            AtualizarListView();
        }

        private void ImportarDadosDoArquivo()
        {    // String de conexão
            string caminho = @"C:\Users\bruno.mnsilva2\source\repos\PetLove-Visual\PetLove-Visual\PetLove\bin\Debug\petlove.txt";

            if (File.Exists(caminho))
            {
                try
                {    //comando pra ler tud
                    string[] linhas = File.ReadAllLines(caminho);
                    foreach (string linha in linhas)
                    {
                        if (string.IsNullOrWhiteSpace(linha)) continue;

                        string[] dados = linha.Split(';');

                        if (dados.Length >= 4)
                        {
                            string nome = dados[0].Trim();
                            string especie = dados[1].Trim();
                            string raca = dados[2].Trim();
                            int idade = int.Parse(dados[3].Trim());

                            adapter.Insert(nome, especie, raca, idade);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na importação: " + ex.Message);
                }
            }
        }

        private void ConfigurarComponentes()
        {   //Configuração do combo box e de cores 
            cbEspecie.Items.Clear();
            cbEspecie.Items.AddRange(new object[] { "Cachorro", "Gato" });
            cbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEspecie.BackColor = SystemColors.ActiveCaption;
            cbEspecie.ForeColor = Color.Gold;
            cbEspecie.FlatStyle = FlatStyle.Flat;
        }


        private void AtualizarListView()
        {
            lvPets.Items.Clear();

            var fonteDeDados = adapter.GetData();
            var consultaLinq = from p in fonteDeDados //Fonte de dados SQL
                               orderby p.Nome ascending
                               select p;

            foreach (var p in consultaLinq)
            {
                ListViewItem item = new ListViewItem(p.Nome);
                item.Tag = p.id;
                item.SubItems.Add(p.Especie);
                item.SubItems.Add(p.Raca);

                // Exibe anos no list view
                string textoIdade = p.Idade == 1 ? "1 Ano" : p.Idade + " Anos";
                item.SubItems.Add(textoIdade);

                lvPets.Items.Add(item);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Comando do try
            try
            {
      
                string nome = txtNome.Text;
                string especie = cbEspecie.Text;
                string raca = txtRaca.Text;

                // Converte o texto da idade para um número inteiro (int)
                int idade = int.Parse(txtIdade.Text);

                // Procedure Insert aqui. envia os dados para o SQL
                adapter.Insert(nome, especie, raca, idade);

                // Cria um registro na classe de Log 
                PetLog log = new PetLog { NomePet = nome, Acao = "Cadastro" };
                MessageBox.Show(log.ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recarrega a list para mostrar o pet que acabou de ser salvo
                AtualizarListView();
                btnLimpar_Click(null, null);
            }
            // Mensagem de erro ao tentar por dados não compativies
            catch (Exception ex) { MessageBox.Show("Erro ao cadastrar: Verifique a idade. " + ex.Message); }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica se há algum pet selecionado na lista se estiver vazio ele não faz nada e volt
            if (lvPets.SelectedItems.Count == 0) return;

            //Tag de identificação do PET 
            int id = Convert.ToInt32(lvPets.SelectedItems[0].Tag);
            // caixa de dialogo de confirmação da opção deletar
            if (MessageBox.Show("Deseja remover este pet?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Chama o método Delete do banco de dados passando o ID para apagar a linha correta.
                adapter.Delete(id);
                AtualizarListView();
                btnLimpar_Click(null, null);
            }
        }

        private void lvPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPets.SelectedItems.Count > 0)
            {
                var selecao = lvPets.SelectedItems[0];

                txtNome.Text = selecao.Text;

                // Seleciona a espécie no Combo Box
                string especieVindaDaLista = selecao.SubItems[1].Text.Trim();
                int indice = cbEspecie.FindStringExact(especieVindaDaLista);
                cbEspecie.SelectedIndex = indice;

                txtRaca.Text = selecao.SubItems[2].Text;

                //Limpa Tela
                string idadeLimpa = selecao.SubItems[3].Text
                                    .Replace("Anos", "")
                                    .Replace("Ano", "")
                                    .Trim();

                txtIdade.Text = idadeLimpa;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtRaca.Clear();
            txtIdade.Clear();
            cbEspecie.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }

    public class PetLog
    {
        public string NomePet { get; set; }
        public string Acao { get; set; }
        public override string ToString() => $"[{DateTime.Now:HH:mm}] {Acao}: {NomePet}";
    }
}