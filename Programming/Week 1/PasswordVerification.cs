using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordVerification {

  class PasswordVerification {

    private string name;
    private string password;
    private int minimumLength;
    
    public bool IsPasswordCorrect (string password) {
      return String.Compare(this.password, password);
    }

    public void ChangePassword (string oldPassword, string newPassword) {
      if (this.IsPasswordCorrect(oldPassword)) {
        this.password = newPassword;
      }
    }
    
    public int MinimumLength {
      get { return this.minimumLength; }
      set { this.minimumLength = value; }
    }

    public string Name {
      get { return this.name; }
    }

  }

}
