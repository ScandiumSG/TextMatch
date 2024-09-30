# TextMatch

# How to run
The simplest way is to run using CLI

## Command line run
Run the following commands from the project root

```
cd TextMatch
dotnet run -- "[TEXT]" "[SUBTEXT]"
```

Replacing `[TEXT]` and `[SUBTEXT]` with the relevant strings.

## Visual Studio run

Press the "Run" button (or F5 if default keybinds not changed) , the "TextMatch" project is configured to launch with the specific parameters of: 
```
TEXT = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea"
SUBTEXT = "Polly"
```

Changes to this can be done within the `launchSettings.json` file.