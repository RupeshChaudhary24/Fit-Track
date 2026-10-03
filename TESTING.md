# FitTrack Manual Testing

These tests were completed manually in the Windows Forms application.

| Test | Steps and test data | Expected result | Actual result | Status |
|---|---|---|---|---|
| Create goal types | Create Weight Loss, Fat Loss, Strength and Endurance goals | Each valid goal appears in the dashboard | All four goal types appeared in the DataGridView | Pass |
| Weight-loss progress | Use start value 80 and target value 75, then log current value 79 | Current value becomes 79 and progress becomes 20% | The dashboard displayed 79 and 20% | Pass |
| Goal completion | Log current value 75 for the same weight-loss goal | Progress becomes 100% and the goal is marked complete | The dashboard displayed 100% and selected IsCompleted | Pass |
| Strength progress | Use start value 50 and target value 100, then log current value 75 | Current value becomes 75 and progress becomes 50% | The dashboard displayed 75 and 50% | Pass |
| Save and reload | Close the application after saving goals and progress, then run it again | Saved goals and progress remain available | The saved information loaded correctly | Pass |
| Clear input fields | Enter goal details and select Clear | Goal type, name and numeric fields reset | The input controls reset correctly | Pass |
| Missing goal selection | Select no goal and click Log Progress | A message asks the user to select a goal and the app continues running | The selection message appeared and the app remained usable | Pass |
| Delete goal | Select a goal, click Delete Goal and confirm | The goal is removed and remains deleted after saving | The selected goal was removed correctly | Pass |
| Progress history | Select a goal and click View History | The history window opens for the selected goal | The correct history window opened | Pass |
| No history | Open history for a goal with no progress | A no-history message appears | The message appeared correctly | Pass |
| History order | Add several progress entries and open history | Entries appear in date order | Entries appeared from oldest to newest | Pass |
| History values | Check the dates and recorded values | Correct dates and values are displayed | All details displayed correctly | Pass |
| Close history | Click Close or press Escape | The history window closes | The window closed correctly | Pass |
| Edit goal | Select a goal, change its name and target, then click Save | The updated details appear in the dashboard | The new name and target appeared | Pass |
| Cancel edit | Open Edit Goal, change a value, then click Cancel | The original details stay the same | The original details stayed the same | Pass |
| Reload edited goal | Save an edit, close FitTrack and open it again | The edited details remain saved | The edited details loaded again | Pass |
| History after edit | Edit a goal with progress entries, then open View History | Earlier progress entries remain available | The earlier entries were still there | Pass |
| JSON backup | Save a goal and check the app folder | A backup file is created | goals.json.bak appeared in the folder | Pass |
| Damaged JSON | Replace goals.json with invalid text and start FitTrack | An error appears and the goal window does not open | The startup error appeared and FitTrack did not load an empty goal list | Pass |
| Restore saved goals | Replace the damaged file with the good copy and start FitTrack | Saved goals appear again | The goals loaded correctly | Pass |

## Result
The tested goal creation, progress calculation, completion tracking, JSON persistence, input clearing, selection handling and deletion workflows behaved as expected during manual testing.
All tested features worked correctly. Goal creation, progress updates, filtering, saving, deletion and progress history passed the  tests.
Editing a goal updated its details, Cancel kept the original details, the saved edit remained after restarting FitTrack, and its progress history was still available
The damaged JSON test showed a startup error without opening an empty goal list. After I restored the original file, my saved goals loaded correctly.
