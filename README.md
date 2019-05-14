# NLogForDotNetLogging
Use NLog for .NET logging and targets would be files, App Insights 

Step 1: Download NLog from NuGet

Step 2: Download NLog.Config from NuGet or add manually

Step 3: Modify NLog.Config:

Target => Targets are used to display, store, or pass log messages to another destination. There are two kinds of target; 		those that receive and handle the messages, and those that buffer or route the messages to another target. The second group are called 'wrapper' targets.

Rules => The rules section maps loggers to targets and log levels.
