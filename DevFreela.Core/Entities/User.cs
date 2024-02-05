namespace DevFreela.Core.Entities;

public class User : BaseEntity
{
    public User(string fullName, string email, DateTime birthdayDate) : base()
    {
        FullName = fullName;
        Email = email;
        BirthdayDate = birthdayDate;
        Skills = new List<UserSkill> ();
        Active = true;

        OwnedProjects  = new List<Project> ();
        FreelancerProjects = new List<Project>();
    }
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthdayDate { get; private set; }
    public bool Active { get; set; }

    public List<UserSkill> Skills { get; private set; }
    public List<Project> OwnedProjects { get; private set; }
    public List<Project> FreelancerProjects { get; private set; }


}
