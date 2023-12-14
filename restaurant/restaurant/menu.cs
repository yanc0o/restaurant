using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (orderItems.Count > 0)
            {
                string orderSummary = string.Join("\n", orderItems);
                string message = $"Order Summary:\n{orderSummary}\n\nTotal: ${totalOrderAmount:F2}";

                // Display order summary using MessageBox.
                MessageBox.Show(message, "Order Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, you can reset the order after submission.
                orderItems.Clear();
                totalOrderAmount = 0.0;
            }
            else
            {
                MessageBox.Show("Please add items to the order first.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
