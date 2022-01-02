using System.Linq;
using System.Windows.Forms;

namespace ProjectS07group4.StudentPanels
{
    public partial class HomePagePanel : Form
    {
        private User user;
        public HomePagePanel(User user)
        {
            InitializeComponent();
            this.user = user;
            userEmailLbl.Text = this.user.UserEmail;
            for (int i = 0; i < this.user.UserPassword.Count(); i++)
                userPasswordLbl.Text += "*";
            addresLbl.Text = $"Address: {this.user.GetApartment.Address}";
            priceLbl.Text = $"Price: {this.user.GetApartment.Price.ToString()}";
            propertyTLbl.Text = $"Property Type: {this.user.GetApartment.PropertyType}";
            interiorLbl.Text = $"Interior: {user.GetApartment.Interior}";
            peopleInApLbl.Text = $"People in the same apartment: {this.user.GetApartment.RoomsInApartment}";
        }
    }
}
