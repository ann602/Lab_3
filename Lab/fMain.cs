using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTablet_Click(object sender, EventArgs e)
        {
            Tablet tablet = new Tablet();
            fTablet ft = new fTablet(tablet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTabletsInfo.Text +=
                string.Format("Бренд: {0}. Ціна: {1} грн. Вага: {2} г. Колір: {3}. Діагональ екрана:" +
                " {4:0.0} ''. Частота процесора: {5:0.0} ГГц. {6}  {7} " +
                "Ціна планшета зі знижкою 30%: {8:0.00} грн. Ціна планшета зі знижкою 30% та знижкою постійного клієнта: {9:0.00} грн.\r\n",
                tablet.brand, tablet.price, tablet.weight, tablet.color, tablet.screendiagonal,
                tablet.CPUfrequency, tablet.isthereasimcard ? "Є sim-карта." : "Немає sim-карти.", tablet.isthereamemorycardslot ? "Є слот для карти пам'яті." : "Немає слота для карти пам'яті.", 
                tablet.discountedPrice(), tablet.discountwitharegularcustomercard());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}