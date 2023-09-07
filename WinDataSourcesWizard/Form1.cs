using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataSourcesWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void контактыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.контактыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.основные_фондыDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "основные_фондыDataSet.Контакты". При необходимости она может быть перемещена или удалена.
            this.контактыTableAdapter.Fill(this.основные_фондыDataSet.Контакты);

        }
    }
}
