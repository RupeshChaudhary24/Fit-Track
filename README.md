# FitTrack

FitTrack is a C# Windows Forms application developed for ITS203 Object-Oriented Design and Programming. It helps users create fitness goals and track their progress.

# Features

- Create Weight Loss, Fat Loss, Strength and Endurance goals.
- Record dated progress entries and view progress history.
- Automatically calculate progress percentages and completion status.
- Filter goals by All, Active or Completed.
- Edit or delete existing goals.
- Check goal values and dates before saving.
- Display goal IDs by numbers.
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
- Select a goal and click View History to see its progress entries.
- Select a goal and click Edit Goal to change its name, start value, target value or target date.
- Use Show goals to switch between All, Active and Completed.
- Select a goal and click Delete Goal to remove it.
- Click Clear to reset the goal input fields.

# Project Structure

- Forms: MainForm, LogProgressForm, ProgressHistoryForm and EditGoalForm. The controls were created using the Visual Studio Form Designer.
- Models: FitnessGoal, four goal subclasses and ProgressEntry.
- Storage: GoalStorage handles JSON saving, loading, backups and goal IDs.
- TESTING.md:  Testing records.

# Tools and References

- Visual Studio and .NET 8 for development and debugging.
- Microsoft C# documentation: https://learn.microsoft.com/en-us/dotnet/csharp/
- Windows Forms documentation: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/
- JSON documentation: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/overview
- Git and GitHub for version control.

# Author

Rupesh Chaudhary
ITS203 Object-Oriented Design and Programming
