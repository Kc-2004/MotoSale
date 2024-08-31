using MotoShopLibrary;

namespace MotorShopUI.forms
{
    public partial class MainForm : Form
    {
        private MotoManager motoManager;
        public MainForm()
        {
            InitializeComponent();
            motoManager = new MotoManager();

        }

        private void registrerBykeButton_Click(object sender, EventArgs e)
        {

            RegisterBykeForm registerBykeForm1 = new RegisterBykeForm(motoManager);

            registerBykeForm1.ShowDialog();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SalesBykeForm salesBykeForm= new SalesBykeForm(motoManager);
            salesBykeForm.ShowDialog();
        }
    }
}
