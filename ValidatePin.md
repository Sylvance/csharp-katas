# Regex validate PIN code
## ValidatePin
ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

If the function is passed a valid PIN string, return true, else return false.

eg:
```cs
ValidatePin("1234") => true
ValidatePin("12345") => false
ValidatePin("a234") => false
```
