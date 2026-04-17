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
                {    //comando pra ler tudo
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
        {
            cbEspecie.Items.Clear();
            cbEspecie.Items.AddRange(new object[] { "Cachorro", "Gato" });
            cbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- APLICANDO A COR ACTIVECAPTION ---
            // Pega a cor exata do tema do seu Windows
            cbEspecie.BackColor = SystemColors.ActiveCaption;

            // Como o ActiveCaption é um azul claro, o texto preto (ControlText) 
            // costuma dar a melhor leitura
            cbEspecie.ForeColor = Color.Gold;

            // Mantenha o Flat para a cor aparecer sem as bordas cinzas do Windows
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

                // --- AJUSTE: Exibindo "Ano" ou "Anos" na lista ---
                string textoIdade = p.Idade == 1 ? "1 Ano" : p.Idade + " Anos";
                item.SubItems.Add(textoIdade);

                lvPets.Items.Add(item);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string especie = cbEspecie.Text;
                string raca = txtRaca.Text;
                int idade = int.Parse(txtIdade.Text);

                adapter.Insert(nome, especie, raca, idade);

                PetLog log = new PetLog { NomePet = nome, Acao = "Cadastro" };
                MessageBox.Show(log.ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarListView();
                btnLimpar_Click(null, null);
            }
            catch (Exception ex) { MessageBox.Show("Erro ao cadastrar: Verifique a idade. " + ex.Message); }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (lvPets.SelectedItems.Count == 0) return;

            try
            {
                int idValido = Convert.ToInt32(lvPets.SelectedItems[0].Tag);
                PetLog log = new PetLog { NomePet = txtNome.Text, Acao = "Atualização" };
                MessageBox.Show(log.ToString());

                AtualizarListView();
            }
            catch (Exception ex) { MessageBox.Show("Erro ao atualizar: " + ex.Message); }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lvPets.SelectedItems.Count == 0) return;

            int id = Convert.ToInt32(lvPets.SelectedItems[0].Tag);
            //Mensagem ao deletar
            if (MessageBox.Show("Deseja remover este pet?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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