using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wpf_mercadinho
{
    public partial class frm_principal : Form
    {
        int total = 0, quantidade = 0, id = 1;

        public frm_principal()
        {
            InitializeComponent();
            txt_id_venda.Enabled = false;
            txt_id_venda.Text = id.ToString();
        }

        private void clear_txt()
        {
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_valor_unit.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_venda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_venda.RowCount > 0)
            {
                txt_qnt_alterar.Text = dgv_venda.CurrentRow.Cells["cmn_quantidade"].Value.ToString();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if(txt_qnt_alterar.Text != "")
            {
                total -=
                int.Parse(dgv_venda.CurrentRow.Cells["cmn_valor_unit"].Value.ToString()) * 
                int.Parse(dgv_venda.CurrentRow.Cells["cmn_quantidade"].Value.ToString());
                quantidade -= int.Parse(dgv_venda.CurrentRow.Cells["cmn_quantidade"].Value.ToString());

                dgv_venda.CurrentRow.Cells["cmn_quantidade"].Value = txt_qnt_alterar.Text;

                quantidade += int.Parse(dgv_venda.CurrentRow.Cells["cmn_quantidade"].Value.ToString());
                total += int.Parse(dgv_venda.CurrentRow.Cells["cmn_valor_unit"].Value.ToString()) *
                int.Parse(dgv_venda.CurrentRow.Cells["cmn_quantidade"].Value.ToString());

                lbl_nota.Text = $"{quantidade} ITENS | {total.ToString("C")}";
            }
        }

        private void btn_cancelar_venda_Click(object sender, EventArgs e)
        {
            clear_txt();
            dgv_venda.RowCount = 0;
            id = 1;
            quantidade = 0;
            total = 0;
            txt_id_venda.Text = id.ToString();
            lbl_nota.Text = $"{quantidade} ITENS | {total.ToString("C")}";
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(dgv_venda.Rows.Count > 0)
            {
                dgv_venda.Rows.RemoveAt(dgv_venda.CurrentRow.Index);
            }
        }

        private void btn_nova_venda_Click(object sender, EventArgs e)
        {
            clear_txt();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (txt_id_venda.Text != "" || txt_produto.Text != "" || 
            txt_quantidade.Text != "" || txt_valor_unit.Text != "")
            {
                dgv_venda.Rows.Add(id, txt_produto.Text, txt_valor_unit.Text, txt_quantidade.Text);

                id++;
                txt_id_venda.Text = id.ToString();
                quantidade = quantidade + int.Parse(txt_quantidade.Text);
                total =  total + ( int.Parse(txt_quantidade.Text) * int.Parse(txt_valor_unit.Text) );

                lbl_nota.Text = $"{quantidade} ITENS | {total.ToString("C")}";
            }
        }
    }
}
