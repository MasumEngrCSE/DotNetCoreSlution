#region Observer Pattern

/*
 
The Observer Pattern is a behavioral pattern that defines a one-to-many dependency between objects,
where one object (the subject) maintains a list of its dependents (observers) and notifies them of state changes. 
This pattern is useful when you have objects that need to be updated automatically when the state of another object changes, 
while avoiding tight coupling between them.

Here's an example of the Observer Pattern:

Suppose we're building a weather monitoring system where multiple weather stations report temperature changes.
We want weather stations to notify observers (displays) when the temperature changes.

 
 */

#endregion

using System;
using System.Collections.Generic;

// Subject (Observable)
public class WeatherStation
{
    private float temperature;
    private List<IDisplay> displays = new List<IDisplay>();

    public float Temperature
    {
        get { return temperature; }
        set
        {
            temperature = value;
            NotifyObservers();
        }
    }

    public void AddObserver(IDisplay display)
    {
        displays.Add(display);
    }

    public void RemoveObserver(IDisplay display)
    {
        displays.Remove(display);
    }

    private void NotifyObservers()
    {
        foreach (var display in displays)
        {
            display.Update(temperature);
        }
    }
}

// Observer
public interface IDisplay
{
    void Update(float temperature);
}

// Concrete Observers
public class TemperatureDisplay : IDisplay
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Temperature Display: Temperature is {temperature}°C");
    }
}

public class Fan : IDisplay
{
    public void Update(float temperature)
    {
        if (temperature > 30)
        {
            Console.WriteLine("Fan: It's too hot! Turning on the fan.");
        }
        else
        {
            Console.WriteLine("Fan: Temperature is normal. Turning off the fan.");
        }
    }
}




#region In this example

/*
 In this example, the WeatherStation class acts as the subject (observable) and maintains a list of observers (displays) that implement the IDisplay interface.
When the temperature changes, it notifies all registered observers.

 Now, let's see how you can use these classes:


class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        // Register observers
        IDisplay temperatureDisplay = new TemperatureDisplay();
        IDisplay fan = new Fan();

        weatherStation.AddObserver(temperatureDisplay);
        weatherStation.AddObserver(fan);

        // Simulate temperature changes
        weatherStation.Temperature = 25.5f;  // Notify Temperature Display
        weatherStation.Temperature = 32.0f;  // Notify Temperature Display and Fan
    }
}


 */



#endregion


#region Why Observer Pattern is Necessary:

/*
 
Decoupling: The Observer Pattern is necessary when you want to achieve loose coupling between objects. Observers don't need to know about the inner workings of the subject, and the subject doesn't need to know about its observers.

Event Handling: It's suitable when you need to implement event handling mechanisms where multiple objects need to respond to changes in the state of another object.

Dynamic Updates: Observers are essential when you want objects to be updated automatically when the state of another object changes, without requiring manual intervention.

Maintainability: The pattern makes it easier to maintain and extend the system. You can add or remove observers without modifying the subject.

Flexibility: It allows you to create systems where objects can be easily reused and composed to achieve various functionalities.

Real-time Updates: Useful for real-time systems where changes in one part of the system need to be reflected immediately in other parts.

In summary, the Observer Pattern is necessary when you want to establish a one-to-many dependency between objects,
allowing multiple objects to be notified and updated when the state of another object changes. It promotes decoupling, maintainability, and flexibility in your software design.

 */


#endregion