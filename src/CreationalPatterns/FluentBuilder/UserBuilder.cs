namespace FluentBuilder;

internal class UserBuilder
{
      private readonly User _user = new();

      internal UserBuilder SetName(string name)
      {
            _user.Name = name;
            return this;
      }

      internal UserBuilder SetCompany(string company)
      {
            _user.Company = company;
            return this;
      }

      internal UserBuilder SetAge(int age)
      {
            _user.Age = age > 0 ? age : 0;
            return this;
      }

      internal UserBuilder IsMarried
      {
            get
            {
                  _user.IsMarried = true;
                  return this;
            }
      }

      internal User Build() => _user;
}
