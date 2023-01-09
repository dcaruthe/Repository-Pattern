# Repository Pattern
This is a simple example of the Repository Design Pattern written in C# for topic of the week by Juniper Song's .NET Cohort
## How to use the project.
The project writes blocks of text to the data layer given a file_name and text input
1. Clone project
```bash
git clone https://github.com/dcaruthe/Repository-Pattern.git
```
2. change to project directory
```bash
cd Repository-Pattern
```
3. Build program
```bash
dotnet publish src -o build 
```
4. Run program
```bash
dotnet build/Launcher.dll
```
### Inside the program
#### 1. When the program starts the first thing you will see is
```
File Name: 
```
Enter the filename you want to save the text input to
#### 2. Next you will get another prompt 
```
Enter text, On UNIX use Ctrl+d to stop on Windows use Ctrl+z:
```
On the next lines you can enter what you want saved. Ctrl+z and Ctrl+d give the EOF signal on the respective platforms.
