## Changelog
All notable changes to this project will be documented on this file

> Please note Versioning guide has been moved to **README** file

### Versions

**v-[2.4.1]-b**
 - Fixed a bug in the `SubjectRegistrationForm` that caused the system to call validation methods when closing it, which prevented the system from shuttingdown if there were validation errors
 - Changed the Form UI of `SubjectRegistartionForm`, now it uses *BorderStyle=none*

**v-[2.4.0]-b** 🌿
 - Added Front end logic for registration
 - Added `InputFieldErrorEvent` to `UcInputField` that fires when there is a validation error and when that error is resolved, this is done by passing EventArg `IsResolved` (bool). If *true*, means the error is resolved
 - Added New Methods in **SubjectRegistration** Form:
   - `InputFieldError` method listens and consume `InputFieldErrorEvent` and provide visual feedback to user when there is Input Error in a form.
   - `AllFieldsChecked` method returns bool depending on whether all fields in the form are filled. it accepts [ParentControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.parent?view=net-5.0) as arg, this can be Groupbox (which is the container of the form)
   - `IsValidDigits` method checks if ID or Bank card number is valid (implementation of [Luhn Algo](https://en.wikipedia.org/wiki/Luhn_algorithm)) 
   - `Tab_Validating` method ensures that all forms in the tabs are filled, before user can make final submission, if not error is shown and user is redirected to the tab with incomplete form
   - `IsValidIdPassNumber` method checks what kind of input users entered (ID or Passport number) and validate the input base on it (validation steps depends on input)
   - > Please check implementation of these methods for types such as *params* and *returns* used
 - Added events for `SAVE AND CONTINUE` buttons and and partial one `REGISTER` button
--------------------------

**v-[2.3.0]-a**
 - Added input types property for UcInputFiled, which are:
   - `Text` just a normal text input, no validation (default)
   - `Word` an input with nospaces in between (one word input, like First Name )
   - `Email` validate if input is an email (using simple RegEx)
   - `Number` validate if input is numeric (check using *double*)
  - Added method that show an error feedback to user when input is invalid after inputField lose focus
---------------------------

**v-[2.2.0]-a**
 - Created constructors for all Database Tables (/Classes📁)
---------------------------

**v-[2.1.1]-a**
 - Fixed the bug that caused all the payment plan to be displayed as selected (unique identifier missing)
--------------------------

**v-[2.1.0]-a**
 - Changed/Renamed the `ProgramResgistrationForm` to `SubjectRegistrationForm`
 - 
 - Created classes/<constructors> for:
   - Subject
   - PaymentPlan
 - Moved all `UserControls` to their own folder(/UseControls📁)
 - Changed file names for UserControls from camelCase to PascalCase
 - Created Payment (Banking Details Form) UI under `Payment` tab
 - Created Confirmation of Registration UI under `Confrimation` tab (which **for now** list all registered subjects and the payment plan chosen by student)
 - Changed logic for selected payment, the `select icon` is nonw updated after `OnSelectedPaymentChanged` event is consumed (by `SubjectRegistrationForm`) or after the event is Invoked by the paymentUI control
------------------------
 
**v-[2.0.0]-a** 🌿
 - Added user control for subject `ucSubject`
 - Added Forms to capture personal details of student and guardian
 - Added ucSubject events that fires when subject is selected or unselected to update ui 
-------------------------
 
**v-[1.0.0]** 🌿
 - Added a new registration form to capture
   - First Name
   - Last Name
   - Email Address
   - Password
 - Created new events in the LandingPage and LogInForm to trigger registration form
 - LogIn form and registration form now uses `Hide()` method instead of `Close()` when changing between them
 - LogIn form's width has been adjusted (it is now smaller in width) 
------------------------
 
**v-[0.1.0]**

 - Renamed file `InputField.cs`  to `ucInputField.cs` to signify that it's a [UserControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.usercontrol?view=netframework-4.6) (uc) file/Class
 - Changed layout and rendering of **log in form** it now renders as Dialog form
 - The **label control** for InputField/TextBox(`ucInputField)` is now hidden  when there is no Text value and sort of a *placeholder*(dirty trick😉)  thingy  is used instead.
 - Renamed `Form1.cs` to `LandingPage`
