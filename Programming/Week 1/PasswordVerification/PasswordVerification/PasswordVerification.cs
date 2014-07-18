using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordVerification {

  class PasswordVerification {

    private string name;
    private string password;
    private int minimumLength;


    public PasswordVerification(string name, string password) {
      this.name = name;
      this.password = password;
    }

    public bool IsPasswordCorrect(string name, string password) {
      return (
        String.Compare(this.password, password) +
        String.Compare(this.name, name)
        == 0
      );
    }

    public void ChangePassword(string oldPassword, string newPassword) {
      if (this.IsPasswordCorrect(this.name, oldPassword)) {
        this.password = newPassword;
      }
    }

    public int MinimumLength {
      get { return this.minimumLength; }
      set { this.minimumLength = value; }
    }

    public string Name {
      get { return this.name; }
      set { this.name = value; }
    }

  }

}