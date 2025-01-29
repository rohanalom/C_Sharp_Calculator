# C# Windows Forms Calculator

## Overview
This is a simple **Calculator** application built using **C# and Windows Forms**. It supports basic arithmetic operations and features a clean and user-friendly UI.

## Features
- ✅ Perform basic arithmetic operations: **Addition (+), Subtraction (-), Multiplication (*), Division (/)**
- ✅ **Backspace** button to remove the last digit
- ✅ **Clear (C)** button to reset the input
- ✅ **Styled Buttons** with hover effects and different colors for digits & operators
- ✅ **Dynamic button event handling** to minimize redundant code

## Technologies Used
- **C#** – Core programming language
- **Windows Forms (WinForms)** – GUI framework
- **.NET Framework / .NET Core** – Application runtime
- **Visual Studio** – IDE used for development

## Project Structure
```
Calculator
│-- Calculator.cs        # Main application logic
│-- Calculator.Designer.cs # UI design elements (auto-generated)
│-- Program.cs           # Entry point of the application
│-- Resources/           # Any image or resource files (if used)
│-- bin/Debug/Release/   # Compiled executables
```

## How to Run
1. **Clone the Repository** (or download the ZIP file)
   ```sh
   git clone https://github.com/yourusername/CSharp-Calculator.git
   ```
2. **Open the project** in **Visual Studio**
3. **Build and Run** the project:
   - Click on **Debug → Start Debugging (F5)**
   - The calculator will launch


## Functionality Breakdown
### **Event Handlers**
- **`btn_digit_click(object sender, EventArgs e)`**
  - Handles **number button clicks**, appending digits to the display.

- **`btn_operator_click(object sender, EventArgs e)`**
  - Stores **first number (_num1)** and **operator (_operator)** for calculations.

- **`btn_equals_Click(object sender, EventArgs e)`**
  - Performs the selected operation on **_num1** and **_num2** and displays the result.

- **`btn_backspace_Click(object sender, EventArgs e)`**
  - Removes the last entered digit.

- **`btn_clear_Click(object sender, EventArgs e)`**
  - Clears the display.

- **`CustomizeSpecialButtons()`**
  - Customizes the UI by applying styles to buttons.

## 📩 Contact
For any questions or feedback, contact me at:
📧 **iamrohanalom98@gmail.com**
📌 **GitHub:** [rohanalom](https://github.com/rohanalom)

