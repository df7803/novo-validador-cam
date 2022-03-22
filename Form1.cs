using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string caminho  = @"Y:\004 - ENGENHARIA\06 - CAM";          // CAMINHO PARA IR DIRETO A PASTA DE CAM
        private string excel = "planilha Excel files (*.excel) |*.xls";      //SELECIONA O EXCELL
        private string geo = "trumph-GEO files (*.GEO) | *.GEO";
        private string lst = "trumph-LST files (*.LST) | *.LST";
        private string dxf = "trumph-DXF files (*.DXF) | *.DXF";
        private string gmt = "trumph-GMT files (*.GMT) | *.GMT";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog planilha = new OpenFileDialog();
            planilha.InitialDirectory = caminho;
            planilha.Filter = excel;

            /*ctrl + K + c*/
            if (planilha.ShowDialog() == DialogResult.OK)
            {
                //System.Diagnostics.Process.Start(openFileDialog.FileName);
                label1.Text = planilha.SafeFileName;
                label1.BackColor = Color.Yellow;
                // MessageBox.Show("arquivo existe");
                //System.Diagnostics.Process.Start(openFileDialog.FileName);  //abre o arquivo selecionado
                
            }
            else
            {
                label1.BackColor = Color.Green;
                button1.BackColor = Color.Crimson;
                button2.BackColor = Color.Cyan;
                button3.BackColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = MessageBox.Show("pre requisitos- Planilha OSFA  ".ToUpper() + "\n" +
           " 1_ o nome  do arquivo OSFA precisa ser igual ao nome" +
           "do programa normalmente  e so remover o terceiro digito (-)" + "\n" + "\n" +
           " Remover a coluna tipo.".ToUpper() + "\n" + "2_ Remover  o L antes do material usando somente na laser" + "\n" +
              "\n" + "\n" +
           "LEGENDA DE CORES" + "\n" + "3_ Vermelho = Revisão diferente ou não existe no programa/ peça" + "\n" +
           "azul Quantidade diferente").ToString();
        }

        private void checkDXF_CheckedChanged(object sender, EventArgs e)
        {
            checkDXF.Select();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folder = new FolderBrowserDialog();
           
            DialogResult result = folder.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                label4.Text = folder.SelectedPath;
            }
        }

        private void checkGEO_CheckedChanged(object sender, EventArgs e)
        {
           checkGEO.Select();
            
        }
    }
}
