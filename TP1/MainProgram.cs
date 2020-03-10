using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class MainProgram : Form
    {
        Items[] items = new Items[5];
        public MainProgram()
        {
            InitializeComponent();

            items[0] = new Items("Adapter Ethernet Gigabit", 1000000, "Elektronik");
            items[1] = new Items("Caviar Boba", 100000, "Makanan");
            items[2] = new Items("Hazmat Suit", 300000, "Baju");
            items[3] = new Items("Webcam", 850000, "Elektronik");
            items[4] = new Items("Mouse Gaming", 1000000, "Elektronik");

            displayItems();
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBox.Show("Please log out to exit the program.");
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen LS = new LoginScreen();
            LS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button newBtn = new Button();
            // flowLayoutPanel1.Controls.Add(newBtn);

            /*
            for (int i = 0; i < 6; i++)
            {
                FlowLayoutPanel newPnl = new FlowLayoutPanel();
                newPnl.Size = new System.Drawing.Size(110, 150);
                newPnl.BackColor = Color.WhiteSmoke;

                PictureBox newPB = new PictureBox();
                newPB.Size = new System.Drawing.Size(104, 80);
                newPB.Anchor = AnchorStyles.None;

                Button newBtn = new Button();
                newBtn.Size = new System.Drawing.Size(104, 20);
                newBtn.Text = "TEST";
                newBtn.Anchor = AnchorStyles.None;

                newPnl.Controls.Add(newPB);
                newPnl.Controls.Add(newBtn);

                flowLayoutPanel1.Controls.Add(newPnl);
            }
            */

            
            FlowLayoutPanel newPnl = new FlowLayoutPanel();
            newPnl.Size = new System.Drawing.Size(110, 150);
            newPnl.BackColor = Color.WhiteSmoke;

            PictureBox newPB = new PictureBox();
            newPB.Size = new System.Drawing.Size(104, 80);
            newPB.Anchor = AnchorStyles.None;

            Button newBtn = new Button();
            newBtn.Size = new System.Drawing.Size(104, 20);
            newBtn.Text = "TEST";
            newBtn.Anchor = AnchorStyles.None;

            newPnl.Controls.Add(newPB);
            newPnl.Controls.Add(newBtn);

            flowLayoutPanel1.Controls.Add(newPnl);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lazada.co.id");
        }

        public void displayItems()
        {
            foreach(var item in items)
            {
                FlowLayoutPanel newPnl = new FlowLayoutPanel();
                newPnl.Size = new System.Drawing.Size(110, 150);
                newPnl.BackColor = Color.WhiteSmoke;

                PictureBox newPB = new PictureBox();
                newPB.Size = new System.Drawing.Size(104, 80);
                newPB.Anchor = AnchorStyles.None;

                Label newLB = new Label();
                newLB.Size = new System.Drawing.Size(104, 30);
                newPB.Anchor = AnchorStyles.None;
                newLB.Text = item.ItemName;
                newLB.ForeColor = Color.Black;

                Button newBtn = new Button();
                newBtn.Size = new System.Drawing.Size(104, 20);
                newBtn.Text = "Beli";
                newBtn.Anchor = AnchorStyles.None;

                newPnl.Controls.Add(newPB);
                newPnl.Controls.Add(newLB);
                newPnl.Controls.Add(newBtn);

                flowLayoutPanel1.Controls.Add(newPnl);
            }
        }
    }
}
