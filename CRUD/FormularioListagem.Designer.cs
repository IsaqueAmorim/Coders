using CRUD.Modelos;

namespace CRUD
{
    partial class FormularioListagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GRD_GridList = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sobrenomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apelidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataNascimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            jogadorModeloBindingSource = new BindingSource(components);
            listaJogadorBindingSource = new BindingSource(components);
            listPlayersBindingSource = new BindingSource(components);
            BTN_Novo = new Button();
            BTN_Atualizar = new Button();
            BTN_Deletar = new Button();
            ((System.ComponentModel.ISupportInitialize)GRD_GridList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jogadorModeloBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaJogadorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listPlayersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GRD_GridList
            // 
            GRD_GridList.AutoGenerateColumns = false;
            GRD_GridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRD_GridList.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, sobrenomeDataGridViewTextBoxColumn, apelidoDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, eloDataGridViewTextBoxColumn, dataNascimentoDataGridViewTextBoxColumn, DataCriacao });
            GRD_GridList.DataSource = jogadorModeloBindingSource;
            GRD_GridList.EditMode = DataGridViewEditMode.EditProgrammatically;
            GRD_GridList.Location = new Point(12, 12);
            GRD_GridList.MultiSelect = false;
            GRD_GridList.Name = "GRD_GridList";
            GRD_GridList.ReadOnly = true;
            GRD_GridList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GRD_GridList.RowHeadersWidth = 51;
            GRD_GridList.RowTemplate.Height = 25;
            GRD_GridList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GRD_GridList.Size = new Size(1086, 349);
            GRD_GridList.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 129;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 129;
            // 
            // sobrenomeDataGridViewTextBoxColumn
            // 
            sobrenomeDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome";
            sobrenomeDataGridViewTextBoxColumn.HeaderText = "Sobrenome";
            sobrenomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            sobrenomeDataGridViewTextBoxColumn.Name = "sobrenomeDataGridViewTextBoxColumn";
            sobrenomeDataGridViewTextBoxColumn.ReadOnly = true;
            sobrenomeDataGridViewTextBoxColumn.Width = 129;
            // 
            // apelidoDataGridViewTextBoxColumn
            // 
            apelidoDataGridViewTextBoxColumn.DataPropertyName = "Apelido";
            apelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
            apelidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            apelidoDataGridViewTextBoxColumn.Name = "apelidoDataGridViewTextBoxColumn";
            apelidoDataGridViewTextBoxColumn.ReadOnly = true;
            apelidoDataGridViewTextBoxColumn.Width = 130;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 129;
            // 
            // eloDataGridViewTextBoxColumn
            // 
            eloDataGridViewTextBoxColumn.DataPropertyName = "Elo";
            eloDataGridViewTextBoxColumn.HeaderText = "Elo";
            eloDataGridViewTextBoxColumn.MinimumWidth = 6;
            eloDataGridViewTextBoxColumn.Name = "eloDataGridViewTextBoxColumn";
            eloDataGridViewTextBoxColumn.ReadOnly = true;
            eloDataGridViewTextBoxColumn.Width = 129;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataNascimentoDataGridViewTextBoxColumn.Width = 129;
            // 
            // DataCriacao
            // 
            DataCriacao.DataPropertyName = "DataCriacao";
            DataCriacao.HeaderText = "Data de Cadastro";
            DataCriacao.Name = "DataCriacao";
            DataCriacao.ReadOnly = true;
            DataCriacao.Width = 129;
            // 
            // jogadorModeloBindingSource
            // 
            jogadorModeloBindingSource.DataSource = typeof(JogadorModelo);
            // 
            // listaJogadorBindingSource
            // 
            listaJogadorBindingSource.DataSource = typeof(JogadorModelo);
            // 
            // BTN_Novo
            // 
            BTN_Novo.Location = new Point(859, 370);
            BTN_Novo.Name = "BTN_Novo";
            BTN_Novo.Size = new Size(75, 23);
            BTN_Novo.TabIndex = 1;
            BTN_Novo.Text = "Novo";
            BTN_Novo.UseVisualStyleBackColor = true;
            BTN_Novo.Click += AoClicarNovo;
            // 
            // BTN_Atualizar
            // 
            BTN_Atualizar.Location = new Point(940, 370);
            BTN_Atualizar.Name = "BTN_Atualizar";
            BTN_Atualizar.Size = new Size(75, 23);
            BTN_Atualizar.TabIndex = 2;
            BTN_Atualizar.Text = "Atualizar";
            BTN_Atualizar.UseVisualStyleBackColor = true;
            BTN_Atualizar.Click += AoClicarAtualizar;
            // 
            // BTN_Deletar
            // 
            BTN_Deletar.Location = new Point(1020, 370);
            BTN_Deletar.Name = "BTN_Deletar";
            BTN_Deletar.Size = new Size(75, 23);
            BTN_Deletar.TabIndex = 3;
            BTN_Deletar.Text = "Deletar";
            BTN_Deletar.UseVisualStyleBackColor = true;
            BTN_Deletar.Click += AoClicarDeletar;
            // 
            // FormularioListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 402);
            Controls.Add(BTN_Deletar);
            Controls.Add(BTN_Atualizar);
            Controls.Add(BTN_Novo);
            Controls.Add(GRD_GridList);
            Name = "FormularioListagem";
            Text = "jogador";
            ((System.ComponentModel.ISupportInitialize)GRD_GridList).EndInit();
            ((System.ComponentModel.ISupportInitialize)jogadorModeloBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaJogadorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)listPlayersBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GRD_GridList;
        private Button BTN_Novo;
        private Button BTN_Atualizar;
        private Button BTN_Deletar;
        private BindingSource listPlayersBindingSource;
        private BindingSource listaJogadorBindingSource;
        private BindingSource jogadorModeloBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DataCriacao;
    }
}