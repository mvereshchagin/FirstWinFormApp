namespace FirstWinFormApp;

public partial class UserInfoForm : Form
{
    private User _user = new User()
    {
        FirstName = "Дмитрий",
        SecondName = "Медведем",
        Address = "Москва, кремль"
    };

    public UserInfoForm()
    {
        InitializeComponent();

        UpdateData();
    }

    private void btClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void UpdateData()
    {
        lbFirstNameInfo.Text = _user.FirstName;
        lbSecondNameInfo.Text = _user.SecondName;
        lbAddressInfo.Text = _user.Address;
    }

    private void btEdit_Click(object sender, EventArgs e)
    {
        using var form = new UserEditForm(_user);
        
        if(form.ShowDialog(this) == DialogResult.OK)
        {
            _user = form.User;
            UpdateData();
        }
    }
}
