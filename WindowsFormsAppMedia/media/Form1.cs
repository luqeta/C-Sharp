using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Botão para inserir as notas:

            //Calculo da Média
            Decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            Decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            Decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            Decimal media = (nota1 + nota2 + nota3) / 3;
            media = decimal.Round(media, 2);

            //Add no DataGridView

            dgv.Rows.Add();
            dgv.Rows[dgv.Rows.Count - 1].Cells["NOME"].Value = txtNome.Text;
            dgv.Rows[dgv.Rows.Count - 1].Cells["NOTAS1"].Value = nota1;
            dgv.Rows[dgv.Rows.Count - 1].Cells["NOTAS2"].Value = nota2;
            dgv.Rows[dgv.Rows.Count - 1].Cells["NOTAS3"].Value = nota3;
            dgv.Rows[dgv.Rows.Count - 1].Cells["MEDIA"].Value = media;

        }
    }
}
