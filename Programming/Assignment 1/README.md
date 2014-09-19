# Assignment 1: Clock Program

## ClockView

- This is the client facing app.
- It doesn't have any interesting code.
- It just displays four ClockTimezone instances.

## ClockTimezones

- This is a custom user control that couples a Clockface with a combobox and some
buttons.
- It allows the user to select one of 24 timezones and apply it to the clockface.
- It uses the [NodaTime](http://nodatime.org/) library to take the pain out of
managing timezones.

## ClockControl

- This is another custom control that draws a Clockface using GDI+ libraries.
- It exposes two public properties:
    - `Text` - the text to display on the clockface
    - `TimezoneOffset` - the number of hours from UTC that the timezone is


