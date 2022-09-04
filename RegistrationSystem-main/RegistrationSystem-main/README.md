# RegistrationSystem
##### A repo for Academic registration system

> Note: Changes in the dev of system will be documented in the **CHANGELOG** file (CHANGELOG.md)

> Please also see [CHANGELOG](https://github.com/MpiloISTN/RegistrationSystem/blob/main/CHANGELOG.md) for updates and changes in the project

# Guidelines
### contributions
- *Contrib guildlines will be discussed soon.*
just make sure the clone or fork of this repo works on your local machine (VS2015)


**Project versioning: *`v-[a.b.c]-a/b`*** (e.g. v-1.7.2-a)
 - **a** - Major changes to the system *(new interfaces and code or major code rewrite)*
 - **b** - Minor changes to the system *(UI and code changes, nothing new really)*
 - **c** - Hot Patch *(bug fixes > e.g. `v-1.0.1` fixes bugs in v-`1.0.0`)*
 - **-a** - Alpha (new features at it early stage, that has not been tested)
 - **-b** - Beta (new features, still in development, that have been tested, but not fully integrated to the system)
 - > if a version has **-a** or **-b** at the end it usually early an stages of **Major version** 
 (e.g. `v-1.0.0-a` is an early stage/version of `v-1.0.0`)
 

> Please note from now on [10/06/2021] **Major versions**  and **-a/-b** versions will have their own git branches, 
this is to allow ease of fallback and less friction between between tested and untested code  
(e.g. `v-1.0.1` will be it own branch same as `v-1.0.0-b` and so on...)
========================

### code
[Quick C# code stadarnds](https://www.geeksforgeeks.org/c-sharp-coding-standards/)

### Controls
- All clickable controls must use button control, including links like controls.
- Labels should be used to display text only (avoid click event handlers)
- Always change the name of control immediately after adding it to avoid having to deal with things like *button1*
- As mention above, when changing Name property, it should be a PascalCase of Text Value (if applicable) and lowercase control name (*<TextValue_controlname>*)
    > *e.g.** A button with Text Value 'View Profile' a name property of it should be `ViewProfile_button`

### Fonts 
- Font name : [SegoeUI](https://docs.microsoft.com/en-us/typography/font-list/segoe-ui)
- Default size : 10
- Default style: regular

### Colors
- Only web colors (not custom or system colors)
- Only the following colors shall be used for styling
  |             | name        | HEX       | RGB               | Contrast text     |
  | ----------- | ----------- |-----------| ------------------|-------------------|
  | Primary     | Dark Orange | `#ff8c00` | `rgb(255,140,0)`  | white             |
  | Secondary   | Black       | `#000000` | `rgb(0, 0, 0)`    | white             |
  | Success     | Lime Green  | `#32cd32` | `rgb(50,205,50)`  | white / dark green|
  | Info        | Dodgerblue  | `#1e90ff` | `rgb(30,144,255)` | white / dark blue |
  | Error       | Red         | `#ff0000` | `rgb(255,0,0)`    | whire / dark red  |
  
  > **NOTE:** `Success` `Info` `Error` colors are used for user feedback or to signify a state change e.g ForeColor or BackColor for Error or success message (keep in mind contrast)

### Buttons
- Filled buttons should have BackColor of `primary` or `secondary` depending on the level of importance and with no border or it color should be the same as BackColor and `MouseDownBackColor` same as BackColor
- Outlined buttons should have BackColor `Transparent` and Border color `primary` or  `secondary` with ForeColor same border
- Link like buttons should have BackColor `Transparent` and ForeColor `primary` or  `secondary` with **No Border**
- All buttons should have *FlatStyle: Flat*
- Button text value should be UPPERCASE 
- Font(SegoeUI, Semibold, 10)

### TextField
- They should have the same BackColor as the parent container
- If there is a label, it should be above the TextField
- placeholders should clearly define expected input, include input pattern if possible (e.g `Enter ID Number (xxxxxx xxxx xx x)`)
