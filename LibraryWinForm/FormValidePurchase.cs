using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinForm
{
    public partial class FormValidePurchase : Form
    {
        private readonly List<Product> cartProducts;

        public FormValidePurchase()
        {
            InitializeComponent();
            cartProducts = new List<Product>();
        }



        // Клас для представлення товару
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }


        private void FormValidePurchase_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Замовлення підтверджено!");
            //Треба код для відправлення замовлення в базу даних 

            // Очистка кошика після підтвердження замовлення
            cartProducts.Clear();
            DisplayCartProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання інформації про вибраний товар
            string productName = textBox1.Text;
            decimal productPrice = numericUpDown1.Value;
            int productQuantity = (int)numericUpDown1.Value;

            // Додавання товару в кошик
            cartProducts.Add(new Product { Name = productName, Price = productPrice, Quantity = productQuantity });

            // Відображення товарів у кошику
            DisplayCartProducts();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Ваш код обробки зміни значення в числовому полі numericUpDown1
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void DisplayCartProducts()
        {
            dataGridView1.Rows.Clear();
            foreach (var product in cartProducts)
            {
                dataGridView1.Rows.Add(product.Name, product.Price, product.Quantity, product.Price * product.Quantity);
            }
        }
    }
}
