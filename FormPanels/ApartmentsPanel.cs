using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectS07group4.AdminManager;
namespace ProjectS07group4.FormPanels
{
    public partial class ApartmentsPanel : Form
    {
        private AdminApartment adminApartment;
        private StudentAuthority studentAuthority;

        public ApartmentsPanel(StudentAuthority studentAuthority)
        {
            InitializeComponent();
            adminApartment = new AdminApartment();
            tableInfo.DataSource = adminApartment.AllApartments;
            this.studentAuthority = studentAuthority;
        }

        private void createApBtn_Click(object sender, EventArgs e)
        {
            createApartmentBtn.Visible = true;
            updateApartmentBtn.Visible = false;
            idTxtBox.Text = "";
            addressAp.Text = "";
            priceNumeric.Value = 100;
            propertyTypeComboBox.Text = "";
            interiorComboBox.Text = "";
            bedroomsComboBox.Text = "";
            roomsQuantity.Text = "";
        }
        private int GetIndex()
        {
            int rc = -1;
            if (this.Visible == true)
                rc = tableInfo.CurrentCell.RowIndex;
            return rc;
        }
        private void UpdateApartmentInfo()
        {
            List<String> copy = adminApartment.ApartmentDataInfo(adminApartment.AllApartments[GetIndex()].ID);
            idTxtBox.Text = copy[0];
            addressAp.Text = copy[1];
            priceNumeric.Value = Decimal.Parse(copy[2]);
            propertyTypeComboBox.Text = copy[3];
            interiorComboBox.Text = copy[4];
            bedroomsComboBox.Text = copy[5];
            roomsQuantity.Text = copy[6];
        }
        private void updateApDataBtn_Click(object sender, EventArgs e)
        {
            createApartmentBtn.Visible = false;
            updateApartmentBtn.Visible = true;
            UpdateApartmentInfo();
        }

     
        private void createApartmentBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(addressAp.Text) && priceNumeric.Value != 0 &&
             !String.IsNullOrEmpty(propertyTypeComboBox.Text) && !String.IsNullOrEmpty(interiorComboBox.Text) &&
             !String.IsNullOrEmpty(bedroomsComboBox.Text) && !String.IsNullOrEmpty(roomsQuantity.Text))
            {
                string address = addressAp.Text;
                double price = Convert.ToDouble(priceNumeric.Value);
                string propertyType = propertyTypeComboBox.Text;
                string interior = interiorComboBox.Text;
                int bedrooms = Convert.ToInt32(bedroomsComboBox.Text);
                int roomsInApartment = Convert.ToInt32(roomsQuantity.Value);
                adminApartment.AddApartmentData(address, price, propertyType, interior, bedrooms, roomsInApartment);
                tableInfo.DataSource = null;
                tableInfo.DataSource = adminApartment.AllApartments;
                MessageBox.Show("Succesfully added");
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error some field are empty");
            }
        }
        private void AreYouSure()
        {
            int quantityOfRooms = adminApartment.QuantityOfRooms(adminApartment.AllApartments[GetIndex()], studentAuthority.AllUsersData);
            if (Convert.ToInt32(roomsQuantity.Value) >= quantityOfRooms)
            {
                String[] data = { tableInfo.Rows[GetIndex()].Cells[0].Value.ToString(),
                addressAp.Text,
                priceNumeric.Value.ToString(),
                propertyTypeComboBox.Text,
                interiorComboBox.Text,
                bedroomsComboBox.Text,
                roomsQuantity.Value.ToString()};
                adminApartment.UpdateApartmentData(Convert.ToInt32(data[0]), data[1], Convert.ToDouble(data[2]),
                data[3], data[4], Convert.ToInt32(data[5]), Convert.ToInt32(data[6]));
                tableInfo.DataSource = null;
                tableInfo.DataSource = adminApartment.AllApartments;
                MessageBox.Show("You successfully updated this apartment");
            }
            else
                MessageBox.Show($"The quantity of rooms should be more than {quantityOfRooms - 1}", "Error");
        }
        private void updateApartmentBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(addressAp.Text) && priceNumeric.Value != 0 &&
             !String.IsNullOrEmpty(propertyTypeComboBox.Text) && !String.IsNullOrEmpty(interiorComboBox.Text) &&
             !String.IsNullOrEmpty(bedroomsComboBox.Text) && !String.IsNullOrEmpty(roomsQuantity.Text) && int.TryParse(roomsQuantity.Text, out _) == true)
            {
                AreYouSure();
            }
            else
                MessageBox.Show("Please fill all fields", "Error some field are empty");
        }
        private void deleteApBtn_Click(object sender, EventArgs e)
        {
            if (tableInfo.Rows.Count > 0)
            {
                adminApartment.DeleteApartmentData(Convert.ToInt32(tableInfo.Rows[tableInfo.CurrentRow.Index].Cells[0].Value));
                tableInfo.DataSource = null;
                tableInfo.DataSource = adminApartment.AllApartments;
                MessageBox.Show($"You successfully deleted this apartment");
            }
            else
                MessageBox.Show("There is no data");
        }

        private void OnClick(object sender, EventArgs e)
        {
            UpdateApartmentInfo();

        }

        private void AllUsersInApartment(object sender, DataGridViewCellEventArgs e)
        {
            string info = null;
            foreach (Users x in studentAuthority.AllUsersData)
            {
                if (x.UserApartmentID == Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[0].Value))
                {
                    info = info + $"ID: {x.ID}, Username: {x.UserEmail} " + System.Environment.NewLine;
                }
            }
            if (info != null)
                MessageBox.Show(info, "People that life in this apartment");
            else
                MessageBox.Show("Apartment is empty");
        }

        private void DeleteAllInformationAboutApartment(Apartment apartment)
        {
            foreach (Users x in studentAuthority.AllUsersData)
            {
                if (x.UserApartmentID == apartment.ID)
                {
                    x.UpdateUser(x.UserEmail, x.UserPassword, 0);
                }
                x.userAgreements.Clear();
                x.userSchedule.Clear();
            }
        }
    }
}
