# 🏭 Logger Factory App

A **dynamic logging system** implemented using the **Factory Method Pattern** in C#. This application allows users to choose different logging methods at runtime and log messages accordingly. 🚀

## 🎯 Features
✅ Implements **Factory Method Pattern** for flexible logging
✅ Supports multiple logging methods:
   - **File Logging** (logs saved to `logs.txt`)
   - **Database Logging** (simulated in the console)
   - **Console Logging** (directly displayed in the terminal)
✅ Interactive **console-based UI** for user selection
✅ Clean and **scalable** architecture

---

## 📂 Project Structure
```
FactoryMethodLogger  
│── FactoryMethodLogger.sln  
│── FactoryMethodLogger/  
│   │── Program.cs  
│   │── Factories/  
│   │   │── ILoggerFactory.cs  
│   │   │── FileLoggerFactory.cs  
│   │   │── DatabaseLoggerFactory.cs  
│   │   │── ConsoleLoggerFactory.cs  
│   │── Loggers/  
│   │   │── ILogger.cs  
│   │   │── FileLogger.cs  
│   │   │── DatabaseLogger.cs  
│   │   │── ConsoleLogger.cs  
│   │── Services/  
│   │   │── LoggerService.cs  
│   │── UI/  
│   │   │── ConsoleMenu.cs  
│   │── README.md  
```

---

## 🛠 How It Works
1️⃣ The user selects a **logging method** from the console menu.
2️⃣ A **factory** creates the corresponding logger instance.
3️⃣ The user enters a message, which is logged using the selected method.

---

## 🎮 Usage
Run the application and interact with the menu:
```plaintext
📌 Select Logging Method:
1️⃣ File Logger
2️⃣ Database Logger
3️⃣ Console Logger
0️⃣ Exit
👉 Choose an option: _
```

Example log outputs:
```
[Console] User login successful.
[Database] Log stored: Payment processed.
Log saved to file.
```

---

## 🚀 Getting Started
### Prerequisites
- .NET 9.0+ installed

### Run the Project
```sh
# Clone the repository
git clone https://github.com/amircliper/FactoryMethodLogger.git
cd FactoryMethodLogger

# Run the project
dotnet run
```

---

## 🏗 Design Pattern: Factory Method
This project demonstrates the **Factory Method Pattern**, which helps in dynamically creating objects without modifying the client code.

### UML Diagram 📊
```plaintext
   ILogger                ILoggerFactory
      ▲                         ▲
      │                         │
 ┌────┴────┐             ┌──────┴──────┐
 │  FileLogger │◄──┐    │ FileLoggerFactory │
 │ DatabaseLogger │◄─┼──▶│ DatabaseLoggerFactory │
 │ ConsoleLogger │◄──┘    │ ConsoleLoggerFactory │
 └──────────────┘             └──────────────────┘
```

---

## 📌 Why Use Factory Method?
✔ **Decouples object creation** → New loggers can be added easily 🛠
✔ **Enhances maintainability** → No need to modify existing code 🚀
✔ **Follows Open-Closed Principle** → Easy expansion without breaking changes 📌

---

## 📝 Future Enhancements
🔹 Add **Cloud Logger** (logging to AWS / Azure / Firebase)
🔹 Implement a **configuration-based logger** (select logging method dynamically from settings)
🔹 Write **unit tests** to validate logger functionality

---