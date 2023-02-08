namespace FirstWinFormApp;

public partial class UserEditForm : Form
{
    public UserEditForm(User user)
    {
        InitializeComponent();

        //var lbName = new Label()
        //{
        //    Text = "Имя",
        //    Location = new Point(100, 100)
        //};
        //this.Controls.Add(lbName);

        edFirstName.Text = user.FirstName;
        edSecondName.Text = user.SecondName;
        edAddress.Text = user.Address;
    }

    #region public properties
    public User User => new User()
    {
        FirstName = edFirstName.Text,
        SecondName = edSecondName.Text,
        Address = edAddress.Text,
    };
    #endregion

    #region event handlers
    private void btOk_Click(object sender, EventArgs e)
    {
        bool validated =
            ValidateFirstName() && ValidateSecondName() && ValidateAddress();

        if (validated)
        {
            errorProvider.Clear();
            this.DialogResult = DialogResult.OK;
        }
        



        //if (String.IsNullOrEmpty(edFirstName.Text) ||
        //    String.IsNullOrEmpty(edSecondName.Text) ||
        //    String.IsNullOrEmpty(edAddress.Text))
        //{
        //    MessageBox.Show("Заполните все поля");
        //    return;
        //}

        //var result = MessageBox.Show(
        //    owner: this,
        //    text: "Тебе больше 18 лет?",
        //    caption: "Действие",
        //    MessageBoxButtons.YesNoCancel,
        //    MessageBoxIcon.Question,
        //    MessageBoxDefaultButton.Button2);

        //if (result == DialogResult.Yes)
        //    MessageBox.Show("You clicked 'Yes'");

        //if (result == DialogResult.No)
        //    MessageBox.Show("You clicked 'Yes'");

        //if (result == DialogResult.Cancel)
        //    MessageBox.Show("You clicked 'Cancel'");
    }

    private void edFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (ValidateFirstName())
            errorProvider.Clear();
    }

    private void edSecondName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (ValidateSecondName())
            errorProvider.Clear();
    }

    private void edAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (ValidateAddress())
            errorProvider.Clear();
    }
    #endregion

    #region private methods
    private bool ValidateFirstName()
    {
        if (String.IsNullOrEmpty(edFirstName.Text))
        {
            errorProvider.SetError(edFirstName, "Не указано имя!");
            return false;
        }

        if (edFirstName.Text.Length < 4)
        {
            errorProvider.SetError(edFirstName, "Слишком короткое имя!");
            return false;
        }

        return true;
    }

    private bool ValidateSecondName()
    {
        if (String.IsNullOrEmpty(edSecondName.Text))
        {
            errorProvider.SetError(edSecondName, "Не указана фималия!");
            return false;
        }

        if (edSecondName.Text.Length < 2)
        {
            errorProvider.SetError(edSecondName, "Слишком короткая фамилия!");
            return false;
        }

        return true;
    }

    private bool ValidateAddress()
    {
        if (String.IsNullOrEmpty(edAddress.Text))
        {
            errorProvider.SetError(edAddress, "Не указан адрес!");
            return false;
        }

        return true;
    }
    #endregion

}
