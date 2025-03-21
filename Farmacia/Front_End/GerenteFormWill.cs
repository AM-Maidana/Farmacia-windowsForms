using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// #606060 #EBEBEB #233ED9
namespace Front_End
{
    public partial class GerenteForm : Form
    {
        public GerenteForm()
        {
            // InitializeComponent();
            ConfigurarInterface();
        }

        private void ConfigurarInterface()
        {
            this.Text = "Painel do Gerente";
            this.Size = new System.Drawing.Size(1000, 600);
            // this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = true;

            TabControl tabControl = new TabControl() { Dock = DockStyle.Fill };

            // Tab 1 - Gerenciamento de Usuários
            // TabPage tabUsuarios = new TabPage("Registro de Venda");
            // TableLayoutPanel panelUsuarios = CriarPainelUsuarios();
            // tabUsuarios.Controls.Add(panelUsuarios);

            // // Tab 2 - Cadastro de Fornecedores
            // TabPage tabFornecedores = new TabPage("Pesquisa e Consulta");
            // TableLayoutPanel panelFornecedores = CriarPainelFornecedores();
            // tabFornecedores.Controls.Add(panelFornecedores);

            // Tab 3 - Relatórios
            TabPage tabRelatorios = new TabPage("Controle De Validade");
            TableLayoutPanel panelRelatorios = CriarPainelRelatorios();
            tabRelatorios.Controls.Add(panelRelatorios);

            // tabControl.TabPages.Add(tabUsuarios);
            tabControl.TabPages.Add(tabFornecedores);
            tabControl.TabPages.Add(tabRelatorios);
            this.Controls.Add(tabControl);
        }

        private TableLayoutPanel CriarPainelUsuarios()
        {
            TableLayoutPanel panel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
            panel.BackColor = ColorTranslator.FromHtml("#EBEBEB");
            panel.Controls.Add(new Label { Text = "Nome:" }, 0, 0);
            panel.Controls.Add(new TextBox { Dock = DockStyle.Fill }, 1, 0);
            panel.Controls.Add(new Label { Text = "Código Produto:" }, 0, 1);
            panel.Controls.Add(new TextBox { Dock = DockStyle.Fill, Text = "Gerente"});
            panel.Controls.Add(new Label { Text = "CPF:" }, 0, 2);
            panel.Controls.Add(new MaskedTextBox { Mask = "000.000.000-00", Dock = DockStyle.Fill }, 1, 2);
            panel.Controls.Add(new Label { Text = "Senha:" }, 0, 3);
            panel.Controls.Add(new TextBox { PasswordChar = '*', Dock = DockStyle.Fill }, 1, 3);

            TableLayoutPanel buttonsTable = new TableLayoutPanel
            {
                ColumnCount = 4,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Adiciona colunas com preenchimento proporcional
            for (int i = 0; i < 4; i++)
                buttonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            buttonsTable.Controls.Add(new Button { Text = "Inserir Usuário", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 0, 0);
            buttonsTable.Controls.Add(new Button { Text = "Lista Usuário", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 1, 0);
            buttonsTable.Controls.Add(new Button { Text = "Atualizar Usuário", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 2, 0);
            buttonsTable.Controls.Add(new Button { Text = "Apagar Usuário", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 3, 0);

            panel.Controls.Add(buttonsTable, 1, 4);

            panel.Controls.Add(new DataGridView { BorderStyle = BorderStyle.FixedSingle, ForeColor = Color.Black, BackgroundColor = Color.White, Dock = DockStyle.Fill }, 1, 5);
            return panel;
        }

        private TableLayoutPanel CriarPainelFornecedores()
        {
            TableLayoutPanel panel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
            panel.Controls.Add(new Label { Text = "Nome:" }, 0, 0);
            panel.Controls.Add(new TextBox { Dock = DockStyle.Fill }, 1, 0);
            panel.Controls.Add(new Label { Text = "CNPJ:" }, 0, 1);
            panel.Controls.Add(new MaskedTextBox { Mask = "00.000.000/0000-00", Dock = DockStyle.Fill }, 1, 1);
            panel.Controls.Add(new Label { Text = "Telefone:" }, 0, 2);
            panel.Controls.Add(new MaskedTextBox { Mask = "(00) 00000-0000", Dock = DockStyle.Fill }, 1, 2);
            panel.Controls.Add(new Label { Text = "Endereço:" }, 0, 3);
            panel.Controls.Add(new TextBox { Dock = DockStyle.Fill }, 1, 3);

            TableLayoutPanel buttonsTable = new TableLayoutPanel
            {
                ColumnCount = 4,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Adiciona colunas com preenchimento proporcional
            for (int i = 0; i < 4; i++)
                buttonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsTable.Controls.Add(new Button { Text = "Inserir Fornecedor", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 0, 0);
            buttonsTable.Controls.Add(new Button { Text = "Lista Fornecedor", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 1, 0);
            buttonsTable.Controls.Add(new Button { Text = "Atualizar Fornecedor", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 2, 0);
            buttonsTable.Controls.Add(new Button { Text = "Apagar Fornecedor", BackColor = ColorTranslator.FromHtml("#233ED9"), ForeColor = ColorTranslator.FromHtml("#FFF"), Height = 50, Dock = DockStyle.Fill }, 3, 0);

            panel.Controls.Add(buttonsTable, 1, 4);

            panel.Controls.Add(new DataGridView { BorderStyle = BorderStyle.FixedSingle, ForeColor = Color.Black, BackgroundColor = Color.White, Dock = DockStyle.Fill }, 1, 5);
            return panel;
        }

        private TableLayoutPanel CriarPainelRelatorios()
{
    TableLayoutPanel panel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };

    TableLayoutPanel buttonsTable = new TableLayoutPanel
    {
        ColumnCount = 1,
        Dock = DockStyle.Fill,
        AutoSize = true
    };

    for (int i = 0; i < 2; i++)
        buttonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

    // Criando o botão
    Button btnValidades = new Button
    {
        Text = "Validades dos Medicamentos",
        BackColor = ColorTranslator.FromHtml("#233ED9"),
        ForeColor = ColorTranslator.FromHtml("#FFF"),
        Height = 50,
        Dock = DockStyle.Fill
    };

    // Criando o DataGridView
    DataGridView dgv = new DataGridView
    {
        BorderStyle = BorderStyle.FixedSingle,
        ForeColor = Color.Black,
        BackgroundColor = Color.White,
        Dock = DockStyle.Fill
    };

    // Evento do botão para carregar os dados
    btnValidades.Click += (sender, e) =>
    {
        using (var con = new Conexao())
        {
            dgv.DataSource = con.Vendas.OrderBy(m => m.data_validade).ToList();
        }
    };

    buttonsTable.Controls.Add(btnValidades, 0, 0);
    panel.Controls.Add(buttonsTable, 1, 4);
    panel.Controls.Add(dgv, 1, 5);

    return panel;
}

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new GerenteForm());
        }
    }
}