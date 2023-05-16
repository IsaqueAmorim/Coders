using CRUD.DOMAIN.MensagensDeErro;
using CRUD.Repositorios;
using CRUD.Servicos;

namespace CRUD
{
    public partial class FormularioListagem : Form
    {

        private IRepositorioJogadores _repositorio;

        private Validacao _validacao;
        public FormularioListagem(IRepositorioJogadores repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
            _validacao = new(repositorio);
            CarregarPagina();


        }

        private void AoClicarNovo(object sender, EventArgs e)
        {
            var formularioCadastro = new FormularioCadastro(_validacao);

            if (formularioCadastro.ShowDialog() == DialogResult.OK)
            {
                var jogadorParaAdicionarNaLista = FormularioCadastro.ObterJogadorCriado();
                try
                {

                _repositorio.CriarJogador(jogadorParaAdicionarNaLista);
                }
                catch (Exception ex)
                {

                   MessageBox.Show(ex.Message);
                }
                CarregarPagina();

            }
        }

        private void CarregarPagina()
        {
            GRD_GridList.DataSource = _repositorio.ObterTodosJogadores().ToList();
            GRD_GridList.ClearSelection();
        }

        private void AoClicarAtualizar(object sender, EventArgs e)
        {
            var rows = GRD_GridList.SelectedRows.Count;
            try
            {
                Validacao.ValidaQuantidadeDeLinhasSelecionadas(rows);
                var id = Int32.Parse(GRD_GridList.SelectedRows[0].Cells[0].Value.ToString()
                    ?? throw new Exception(MensagensDeErro.FALHA_LINHA_NAO_ENCONTRADA));

                var jogadorAtual = _repositorio.ObterJogadorPorId(id);
                var formularioCadastro = new FormularioCadastro(_validacao,jogadorAtual);

                if (formularioCadastro.ShowDialog() == DialogResult.OK)
                {
                    var jogadorParaAdicinarNaLista = FormularioCadastro.ObterJogadorCriado();
                    _repositorio.AtualizarJogador(jogadorParaAdicinarNaLista);
                    CarregarPagina();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void AoClicarDeletar(object sender, EventArgs e)
        {
            var rows = GRD_GridList.SelectedRows.Count;
            try
            {
                Validacao.ValidaQuantidadeDeLinhasSelecionadas(rows);
                var id = Int32.Parse(GRD_GridList.SelectedRows[0].Cells[0].Value.ToString() ?? throw new Exception(MensagensDeErro.FALHA_LINHA_NAO_ENCONTRADA));


                var dialogResult = MessageBox.Show("Tem certeza que deseja excluir permanentemente este item ?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _repositorio.DeletarJogador(id);
                    CarregarPagina();
                }
                else if (dialogResult == DialogResult.No)
                {
                    CarregarPagina();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
