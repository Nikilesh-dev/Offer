using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Printing;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Offer_letter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        String Gender1 = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String Name  = txtName.Text;    
            String Address = txtAddress.Text;   
            String Qualification = txtQualification.Text;
            String JobPosition = txtPosition.Text;
            String Gender2 = "";
            if(Gender1 == "Male")
            {
                Gender2 = "Mr ";
            }
            else
            {
                Gender2 = "Ms ";
            }
            if (Name == "" || Address == "" || Qualification == "" || JobPosition == "")
            {
                MessageBoxResult result = MessageBox.Show("Please Fill all the Required details", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    Name = "";
                    Address = "";
                    Qualification = "";
                    JobPosition = "";
                }

            }
            else
            {
                String intro = "Dear, " + Gender2 + " " + Name + System.Environment.NewLine;
                String Template =
                "We are pleased to offer you the full - time position of " + JobPosition + " with a start date of July 15th, 2023, contingent upon a background check." + System.Environment.NewLine + System.Environment.NewLine +
                "manager at Banglore will be your primary contact and manager on site." + System.Environment.NewLine + System.Environment.NewLine + "It is in our opinion that your abilities and experience will be the perfect fit for our company." + System.Environment.NewLine + System.Environment.NewLine +

                "In this role, you will be required to take full ownership over the product life cycle, " + System.Environment.NewLine +
               "understand customer needs through research and market data and own and shape the backlog," + System.Environment.NewLine + "roadmap and vision of one cross - functional product team." + System.Environment.NewLine +

                "The starting annual salary for this position is $75, 000 to be paid on a semi - monthly basis by direct deposit starting on August 1st, 2023." + System.Environment.NewLine + System.Environment.NewLine + "This salary also includes stock options." + System.Environment.NewLine + System.Environment.NewLine +
                 "By signing and returning this letter you will confirm your acceptance of  the offer. Please respond no later than July 1st, 2023." + System.Environment.NewLine + "We look forward to having you on our team!" +
                 "If you have any questions, please feel free to reach out at your earliest convenience" + System.Environment.NewLine +
                 System.Environment.NewLine + "Sincerely," + System.Environment.NewLine  + System.Environment.NewLine+ "Human Resources" + System.Environment.NewLine + "NK Private Limited";

                Text Letter = new Text();
                Letter.lblIntro.Content = intro;
                Letter.lblAdd.Content = Address;
                Letter.lblFormat.Content = Template;
                Letter.Show();
            }
            
        }

        private void Male_Checked(object sender, RoutedEventArgs e)
        {
            Gender1 = "Male";
        }

       

        private void Female_Checked_1(object sender, RoutedEventArgs e)
        {
            Gender1 = "Female";
        }
    }
}
