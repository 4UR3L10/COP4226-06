using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6_Draft
{
    
    public partial class PromotionForm : Form
    {
        public string piece = "";

        public PromotionForm()
        {
            InitializeComponent();
            comboBoxPromotion.SelectedItem = comboBoxPromotion.Items[0];
            piece = comboBoxPromotion.Items[0].ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            piece = comboBoxPromotion.SelectedItem.ToString();
        }
    }
}
