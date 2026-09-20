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

## Result

The tested goal creation, progress calculation, completion tracking, JSON persistence, input clearing, selection handling and deletion workflows behaved as expected during manual testing.
