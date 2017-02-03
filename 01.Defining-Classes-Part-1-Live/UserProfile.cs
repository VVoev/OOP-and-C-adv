public class UserProfile
{
    private int Id;
    private string firstName;
    private string secondName;

    public UserProfile(int id, string firstName, string secondName)
    {
        this.Id = id;
        this.firstName = firstName;
        this.secondName = secondName;
    }

    public override string ToString()
    {
        return string.Format("ID: {0},Firstname:{1},Secondname:{2}", this.Id, this.firstName, this.secondName);
    }
}