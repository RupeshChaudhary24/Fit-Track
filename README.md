# FitTrack

FitTrack is a C# Windows Forms application developed for ITS203 Object-Oriented Design and Programming. It helps users create fitness goals and track their progress.

# Features

- Create Weight Loss, Fat Loss, Strength and Endurance goals.
- Record dated progress entries.
- Automatically calculate progress percentages and completion status.
- Filter goals by All, Active or Completed.
- Delete goals and clear input fields.
- Save and reload goals using JSON.

# How to Run

- Use Windows with Visual Studio, the .NET desktop development workload and .NET 8 SDK.
- Download or clone this repository.
- Open FitTrackSolution/FitTrackSolution.slnx in Visual Studio.
- If the solution file is unsupported, open FitTrackSolution/FitTrack/FitTrack.csproj.
- Build the project and press F5.

# How to Use

- Select a goal type, enter its details and click Add Goal.
- Select a goal row and click Log Progress to record a date and current value.
- Use Show goals to switch between All, Active and Completed.
- Select a goal and click Delete Goal to remove it.

# Project Structure

- Forms: MainForm and LogProgressForm, built using the Visual Studio Form Designer.
- Models: FitnessGoal, four goal subclasses and ProgressEntry.
- Storage: GoalStorage handles JSON saving and loading.
- TESTING.md: Manual testing records.

Data is stored in goals.json beside the running executable and reloaded when the application starts.


# Tools and References

- Visual Studio and .NET 8 for development and debugging.
- Microsoft C# documentation: https://learn.microsoft.com/en-us/dotnet/csharp/
- Windows Forms documentation: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/
- JSON documentation: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/overview
- Git and GitHub for version control.


# Author

Rupesh Chaudhary
ITS203 Object-Oriented Design and Programming
