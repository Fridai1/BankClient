using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BankClient
{
    public partial class Form1 : Form
    {
        //Connection conn = new Connection();
        public Form1()
        {
            InitializeComponent();
            var ClientRaw = File.ReadAllText("C:\\Users\\nikol\\Documents\\Code\\BankClient\\BankClient\\Clients.txt");
            List<Customer> Clients = (List<Customer>) JsonConvert.DeserializeObject<IList<Customer>>(ClientRaw);
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            foreach (var c in Clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = c.Name; 
                item.Tag = c;
                listView1.Items.Add(item);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            double amount = 0;
            Connection conn = new Connection();
            if (e.IsSelected)
            {
               Customer c =(Customer) listView1.SelectedItems[0].Tag;
               if (textBox1.Text != "")
               {
                   amount = Double.Parse(textBox1.Text);
                }

               NameValue.Text = c.Name;
               conn.StartConnection(c.Id, amount);
            }
        }
        

        
    }
}
