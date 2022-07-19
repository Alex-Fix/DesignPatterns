using FluentBuilder;

User tom = new UserBuilder()
      .SetName("Tom")
      .SetCompany("Apple")
      .SetAge(21)
      .IsMarried
      .Build();