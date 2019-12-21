using OnlineStore.CartSystem;
using OnlineStore.CartSystem.Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles
{
    public partial class Cart : Form
    {
        ShoppingCartController cartController;
        public Cart(ShoppingCartController cartController)
        {
            InitializeComponent();
            this.cartController = cartController;
        }
        

        private void Cart_Load(object sender, EventArgs e)
        {
            List<CartItem> ListItem;
            ListItem=cartController.viewCart();
       
            foreach (CartItem item in ListItem)
            {
                String tpStr = "";
                
                    tpStr += item.GetName() + ","+item.GetPrice()+","+item.GetAmount()+ ",";
               
                checkedListBox1.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double price = cartController.calcTotalPrice("NormalUser");
            MessageBox.Show(price.ToString());
        }
    }
}
