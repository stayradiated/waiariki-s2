/*
 * References:
 * NodaTime. (2014). Nodatime | date and time api for .net.
 * Retrieved from: http://nodatime.org/.
 *
 * "Noda Time is an alternative date and time API for .NET."
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NodaTime;

namespace ClockTimezones {

  /*
   * ClockTimezones
   * ==============
   *
   * Displays a clockface and a combobox to select a timezone.
   */

  public partial class ClockTimezones : UserControl {

    /*
     * Constants
     * =========
     */

    private static Dictionary<string, string> TIMEZONES = new Dictionary<string, string> {
      /* -12 */  {"Dateline Standard Time",          "UTC-12 International Date Line West"},
      /* -11 */  {"Samoa Standard Time",             "UTC-11 Samoa"},
      /* -10 */  {"Hawaiian Standard Time",          "UTC-10 Hawaii"},
      /* -09 */  {"Alaskan Standard Time",           "UTC-09 Alaska"},
      /* -08 */  {"Pacific Standard Time",           "UTC-08 Pacific"},
      /* -07 */  {"Mountain Standard Time",          "UTC-07 Mountain"},
      /* -06 */  {"Central Standard Time",           "UTC-06 Central America"},
      /* -05 */  {"Eastern Standard Time",           "UTC-05 Eastern Time"},
      /* -04 */  {"Atlantic Standard Time",          "UTC-04 Atlantic Time"},
      /* -03 */  {"E. South America Standard Time",  "UTC-03 South America"},
      /* -02 */  {"Mid-Atlantic Standard Time",      "UTC-02 Mid-Atlantic"},
      /* -01 */  {"Cape Verde Standard Time",        "UTC-01 Cape Verde Is."},
      /* +00 */  {"UTC",                             "UTC+00 UTC"},
      /* +01 */  {"Central Europe Standard Time",    "UTC+01 Central Europe"},
      /* +02 */  {"E. Europe Standard Time",         "UTC+02 E. Europe"},
      /* +03 */  {"Arabic Standard Time",            "UTC+03 Arabia"},
      /* +04 */  {"Russian Standard Time",           "UTC+04 Russia"},
      /* +05 */  {"West Asia Standard Time",         "UTC+05 West Asia"},
      /* +06 */  {"Central Asia Standard Time",      "UTC+06 Central Asia"},
      /* +07 */  {"SE Asia Standard Time",           "UTC+07 North Asia"},
      /* +08 */  {"China Standard Time",             "UTC+08 China"},
      /* +09 */  {"Tokyo Standard Time",             "UTC+09 Tokyo"},
      /* +10 */  {"AUS Eastern Standard Time",       "UTC+10 East Australia"},
      /* +11 */  {"Central Pacific Standard Time",   "UTC+11 Cental Pacific"},
      /* +12 */  {"New Zealand Standard Time",       "UTC+12 New Zealand"},
      /* +13 */  {"Tonga Standard Time",             "UTC+13 Tonga"}
    };


    /*
     * Private Variables
     * =================
     *
     * Stores private information about the currently selected timezone.
     */

    private string timezoneId;

    /*
     * Constructor
     * ===========
     *
     * Create a new instance of the ClockTimezones.
     */

    public ClockTimezones() {
      InitializeComponent();

      // detect current timezone
      this.timezoneId = DateTimeZoneProviders.Bcl.GetSystemDefault().Id;
    }

    private void clockControl1_Load(object sender, EventArgs e) {
      // set clock text to current timezone name
      this.setClockText(this.timezoneId);
      this.setClockTime(this.timezoneId);

      // bind TIMEZONES dictionary to the combobox
      this.comboBox.DataSource = new BindingSource(TIMEZONES, null);
      this.comboBox.ValueMember = "Key";
      this.comboBox.DisplayMember = "Value";
      this.comboBox.SelectedValue = this.timezoneId;
    }

    private void btn_apply_Click(object sender, EventArgs e) {
      // get current timezoneId from combobox
      this.timezoneId = ((KeyValuePair<string, string>)this.comboBox.SelectedItem).Key;
      this.setClockText(this.timezoneId);
      this.setClockTime(this.timezoneId);
    }

    private void btn_cancel_Click(object sender, EventArgs e) {
      this.comboBox.SelectedValue = this.timezoneId;
    }

    private void setClockText(string timezoneId) {
      string text;

      // if the timezone exists in our dictionary,
      // then trim the UTC+00 part off and use that
      if (TIMEZONES.ContainsKey(timezoneId)) {
        text = TIMEZONES[timezoneId];
        int space = text.IndexOf(' ');
        text = text.Substring(space);
      }
      // else just use the timezone name verbatim
      else {
        text = timezoneId;
      }

      // set clockface text
      this.clock.Text = text;
    }

    private void setClockTime(string timezoneId) {
      // Get the actual timezone based on its ID
      DateTimeZone timezone = DateTimeZoneProviders.Bcl.GetZoneOrNull(timezoneId);

      // exception handling: make sure that the timezoneId is valid
      if (timezone == null) {
        MessageBox.Show(
          "Timezone ID is invalid: \"" + timezoneId + "\"",
          "Invalid Timezone",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
        );
        return;
      }

      // Calculate the UTC offset for this time of year
      Offset offset = timezone.GetUtcOffset(SystemClock.Instance.Now);

      // Convert the offset into an int that we can use
      this.clock.TimeZoneOffset = Int32.Parse(offset.ToString());
    }

  }
}
