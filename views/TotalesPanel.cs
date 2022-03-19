using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiendaSystem.views {
    public partial class TotalesPanel : UserControl {

        public TotalesPanel() {
            InitializeComponent();
            this.clear();
        }

        public void setTotal(double total) {
            this.txtTotal.Text = total.ToString("0.00");
        }

        public void clear() {
            this.txtTotal.Text = "0.00";
        }

        private void txtTotal_TextChanged(object sender, EventArgs e) {
            this.txtSubTotal.Text = (Convert.ToDouble(this.txtTotal.Text) / 1.18).ToString("0.00");
            this.txtIgv.Text = (Convert.ToDouble(this.txtSubTotal.Text) * 0.18).ToString("0.00");
        }
    }
}
