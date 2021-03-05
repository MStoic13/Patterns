# Patterns

This is a collection of coding patterns I have dealt with and found useful. I thought I'd gather them in a single place for others to learn from and for my future reference since I can't remember everything ever.

## The Pluggable Model

You can use interfaces to name patterns you use such as Logger and Configuration and define the common methods used in this pattern. And then you can implement these interfaces in several classes which all do the same thing at a high level, but the details differ. For example, if you want to have 2 loggers: one which writes to the console and one which writes to a file, you would have 1 ILogger interface with their common methods and 2 classes which inherit from ILogger but implement the methods differently. FileLogger will write your messages to a file while ConsoleLogger will write them to the console output.

You can use interfaces this way for various patterns and functionalities you may have in a project, allowing for clean readability and easy extension of functionality at a later time.

## Logger pattern 

A Logger is a system that collects your messages in a file and caps out at a certain size at which point it creates a new file to continue writing your logs in and generally appends a number at the end of the file to show the order. These log files usually contain the time and date when the message was written, an id which contains the name of the component or class or method which wrote the log and the message itself. Sometimes, you can separate the exception message in its own column so that it doesn't get mixed with the message itself. The message should always be human readable while the exception contains a stack trace.

I have an interface called an ILogger because I want to keep the generic methods in here and implement their specifics in the Logger classes. The methods all loggers have in common are writing information, debug messages and errors. Then, I implemented 2 loggers: 

FileLogger is a logger which writes my messages to a file. I can also separate my types of logs to different files. I can have a log file with info and errors, a separate file with info, debug and errors and a file just with errors. This separation and duplication of logs helps readability and comprehension of what the program is doing at which time and in which order when the volume of logs is large or when a feature is very convoluted and has many steps. 

ConsoleLogger is a logger which writes my messages to the console output changing colors of the text depending on which of the 3 types the message is: info, debug or error.

## Configuration pattern

You can keep settings and service configurations in configuration files which have the format of property = value grouped together by [SectionHeaders]. These files are useful because you can change the behavior of your program without needing to build. You can use feature flags and make your code execute a feature only if it is enabled in the configuration file. And so when the code is running, if you want to turn this feature off, you change the value of the property in the configuration file instead of having to make changes in the code, build and deploy.

IConfiguration has the methods that are common to parsing and accessing configuration properties in the code. You only parse once to be efficient instead of every time you want to access the property. 

Configuration parses the given config file path in the ctor.

PatternsConfig has a field for each property I care about so that I can access it a lot easier in code than using string for the property names.

## Common Library Pattern

If you have a complex solution with multiple projects which share some functionalities, it's best to extract those functionalities into a library and make them context insensitive. That way it's easy to test these methods. Have a class in your library called Utility or Helper for miscelaneous helper methods which are not complex enough to need their own helper class.

## Unit Tests Pattern 

Unit tests usually sit in their own project for organizational purposes. They not only check that the code you wrote does the right thing and handles corner cases elegantly, but they also ensure that future changes to the projet don't break existing code.

## Mocks

Sometimes, you have a complex class with a bunch of context and you need to test it. The cleanest way to do this is to mock the class and then test its methods in various contexts because it's easy to inject context once you have a mock.
