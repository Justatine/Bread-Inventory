using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace BreadInventory
{
	public partial class Form1 : Form
	{
		User userModel = new User();
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		void Clear()
		{
			txtEmail.Text = txtPassword.Text = "";
		}
		private void loginBtn_Click(object sender, EventArgs e)
		{
			userModel.email = txtEmail.Text.Trim();
			userModel.password = txtPassword.Text.Trim();

			using (BreadInventoryEntities db = new BreadInventoryEntities())
			{
				var auth = db.Users.FirstOrDefault(x => x.email == userModel.email && x.password == userModel.password);
                if (auth != null)
                {
					SessionAuthentication.Login(auth);

					MessageBox.Show("Login successfull");
					this.Hide();

					Form2 form2 = new Form2();
					form2.ShowDialog();
					form2 = null;

					Clear();
					
					this.Show();

				}
				else
				{
					MessageBox.Show("Invalid username/password");
				}
			}

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
