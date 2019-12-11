# Signals ❇

![UPM Screenshot](https://repository-images.githubusercontent.com/196998874/5b81aa00-0794-11ea-804b-4acc77a1ce2e)

### A typesafe, lightweight messaging lib for Unity.
---

## Installation

### Simple Download
[Latest Unity Packages](../../releases/latest)

### Unity Package Manager (UPM)

> You will need to have git installed and set in your system PATH.

Find `Packages/manifest.json` in your project and add the following:
```json
{
  "dependencies": {
    "com.supyrb.signals": "https://github.com/supyrb/signals.git#0.2.1",
    "...": "..."
  }
}
```

## Features

* Signal Hub as a global Registry for everyone to access
* Signal with up to three parameters
* Signal Listener Order
* Consuming Signals
* Pausing Signals

## Usage

[BasicExample](./Samples~/Basic/Scripts/BasicExampleSignalTest.cs)
```c#

// Get signal
exampleSignal = Signals.Get<BasicExampleSignal>();

// Other way to get a signal
Signals.Get(exampleSignal);

// Subscribe to signal
exampleSignal.AddListener(DefaultListener);

// Subscribe with an earlier order to be called first
exampleSignal.AddListener(FirstListener, -100);

// Dispatch signal
exampleSignal.Dispatch();

```
### Pause & Continue
If you want to pause the further propagation of a signal (wait for a *user input*/*scene that needs to laod*/*network package*) you can easily do that with `signal.Pause()` and `signal.Continue()`.

### Consume Signals
Sometimes only one script should handle a signal or the signal should not reach others. Unity for example does this with keystrokes in the editor, you can decide in the script if the [event is used](https://docs.unity3d.com/ScriptReference/Event.Use.html). Similar to that, you can consume signals with `signal.Consume()`. Always be away of the order of your listeners. Listeners with a lower order value are called first and therefore decide before others if they should get the event as well.

### Credits

* Built on the shoulders of [Signals](https://github.com/yankooliveira/signals) by [Yanko Oliveira](https://github.com/yankooliveira)
* Inspired by [JS-Signas](https://github.com/millermedeiros/js-signals) by [Miller Medeiros](https://github.com/millermedeiros)
* Developed by [Johannes Deml](https://github.com/JohannesDeml) – [public@deml.io](mailto:public@deml.io)

## License
* MIT - see [LICENSE](./LICENSE.md)

*Made by ![💥Supyrb](https://supyrb.com/data/supyrb-inline-logo.svg)*
