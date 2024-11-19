using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadInventory
{
	public partial class Form2 : Form
	{
		Bread breadModel = new Bread();
		public Form2()
		{
			InitializeComponent();
		}

		void Clear()
		{
			txtBread.Text = txtExpiration.Text = txtPrice.Text = txtQuantity.Text = txtStatus.Text = "";
			insertBtn.Text = "Save";
			deleteBtn.Enabled = false;
			this.ActiveControl = txtBread;
			editBtn.Enabled = false;
			editBtn.Text = "Edit";
		}
		void LoadData()
		{
			using (BreadInventoryEntities3 db = new BreadInventoryEntities3())
			{
				dgBreadData.DataSource = db.Breads.ToList<Bread>();
			}
		}

		private void clrBtn_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Clear();
			LoadData();
			var loggedInUser = SessionAuthentication.AuthenticatedUser;
			lblName.Text = "Logged in as: " + loggedInUser.name;
		}

		private void insertBtn_Click(object sender, EventArgs e)
		{
			breadModel.bread_name = txtBread.Text.Trim();
			breadModel.quantity = int.Parse(txtQuantity.Text.Trim());
			breadModel.price = decimal.Parse(txtPrice.Text.Trim());
			breadModel.expiration_date = DateTime.Parse(txtExpiration.Text.Trim());
			breadModel.status = txtStatus.Text.Trim();
			breadModel.created_at = DateTime.Now;

			using (BreadInventoryEntities3 db = new BreadInventoryEntities3())
			{
				db.Breads.Add(breadModel);
				db.SaveChanges();
			}
			Clear();
			LoadData();
			MessageBox.Show("Bread added");
		}

		private void dgBreadData_DoubleClick(object sender, EventArgs e)
		{
			if (dgBreadData.CurrentRow.Index != -1)
			{
				breadModel.Id = Convert.ToInt32(dgBreadData.CurrentRow.Cells["dgId"].Value);
				using (BreadInventoryEntities3 db = new BreadInventoryEntities3())
				{
					breadModel = db.Breads.Where(x => x.Id == breadModel.Id).FirstOrDefault();
					txtBread.Text = breadModel.bread_name;
					txtPrice.Text = Convert.ToDouble(breadModel.price).ToString("F2");
					txtExpiration.Text = breadModel.expiration_date.ToString();
					int quantity = Convert.ToInt32(breadModel.quantity);
					txtQuantity.Text = quantity.ToString();
					txtStatus.Text = breadModel.status;
				}
				editBtn.Text = "Update";
				editBtn.Enabled = true;
				deleteBtn.Enabled = true;
			}
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			int id = breadModel.Id;

			using (BreadInventoryEntities3 db = new BreadInventoryEntities3())
			{
				var existingBread = db.Breads.FirstOrDefault(b => b.Id == id);

				if (existingBread != null)
				{
					existingBread.bread_name = txtBread.Text.Trim();
					existingBread.quantity = int.Parse(txtQuantity.Text.Trim());
					existingBread.price = decimal.Parse(txtPrice.Text.Trim());
					existingBread.expiration_date = DateTime.Parse(txtExpiration.Text.Trim());
					existingBread.status = txtStatus.Text.Trim();

					db.SaveChanges();

					MessageBox.Show("Bread updated");
				}
			}
			LoadData();
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				using (BreadInventoryEntities3 db = new BreadInventoryEntities3())
				{
					var entry = db.Entry(breadModel);
					if (entry.State == EntityState.Detached)
					{
						db.Breads.Attach(breadModel);
						db.Breads.Remove(breadModel);
						db.SaveChanges();
						LoadData();
						Clear();
						MessageBox.Show("Record deleted");
					}
				}
			}
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
			SessionAuthentication.Logout();
			MessageBox.Show("You have been logged out.");
			
			this.Close();
		}
	}
}
