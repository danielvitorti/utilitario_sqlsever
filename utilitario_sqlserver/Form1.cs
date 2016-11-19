using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilitario_sqlserver.classes;

namespace utilitario_sqlserver
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SQLServerUtils sqlServerUtils = new SQLServerUtils();

            string connection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master";
            try
            {
                sqlServerUtils.backup(connection,lstPrincipal.SelectedItem.ToString(), "C:\\projetos\\TesteSQLServerBackup.bak");
                MessageBox.Show("BACKUP DO BANCO DE DADOS " + lstPrincipal.SelectedItem + " FEITO COM SUCESSO !");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            SQLServerUtils sqlServerUtils = new SQLServerUtils();

            string connection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master";

            try
            {
                sqlServerUtils.restore(connection,lstPrincipal.SelectedItem.ToString(), "C:\\projetos\\TesteSQLServerBackup.bak");

                MessageBox.Show("RESTAURACAO DO BANCO DE DADOS "+lstPrincipal.SelectedItem+" EFETUADA COM SUCESSO!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnListagemBanco_Click(object sender, EventArgs e)
        {
       
            string connection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Master";

            SQLServerUtils sqlServerUtils = new SQLServerUtils();

            string[] databases = sqlServerUtils.getDatabase(connection);

            string dataBasesList;


            foreach (string listaDB_loop in databases)
            {
                dataBasesList = listaDB_loop;
                lstPrincipal.Items.Add(dataBasesList);

            }
        }
    }
}
