using Data.Entities;
using Data.Repositories;

namespace FirstWinFormApp;

public partial class UserInfoForm : Form
{
    private readonly IUserRepository _userRepository;
    private User _user;


    public UserInfoForm(IUserRepository userRepository, int userId)
    {
        InitializeComponent();

        _userRepository = userRepository;

        _user = _userRepository.GetById(userId) ?? 
            throw new ArgumentException($"Не удалось найти пользователя с Id = {userId}");

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
