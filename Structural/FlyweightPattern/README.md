# The Flyweight Design Pattern

## Introduction

The Flyweight design pattern is a structural pattern that aims to reduce the memory usage of an application by sharing common data between multiple objects. This pattern is particularly useful when an application needs to work with a large number of similar objects, such as in the case of a map application displaying thousands of points on a map.

In a map application, each point on the map can be represented by a `Point` object, which typically includes properties such as the x and y coordinates, the type of point (e.g., cafe, restaurant, hospital), and the icon to be displayed for that point. However, if the application has a large number of points, the memory consumption can quickly become a problem, as each `Point` object would need to store its own copy of the icon data.

The Flyweight pattern solves this problem by separating the intrinsic (unchangeable) state of an object from its extrinsic (changeable) state. In the case of the `Point` class, the x and y coordinates are the intrinsic state, while the type and icon are the extrinsic state. The Flyweight pattern stores the extrinsic state in a separate object, called a `PointIcon`, and shares this object among multiple `Point` instances.

## Code Example

Let's consider the example classes you provided:

```csharp
public class Point
{
    private readonly int _x;
    private readonly int _y;
    private readonly PointIcon _icon;

    public Point(int x, int y, PointIcon icon)
    {
        _x = x;
        _y = y;
        _icon = icon;
    }
    public void Draw()
    {
        UiSkelton.WriteIndentedText3($"Drawing X:{_x} Y:{_y} Type:{_icon.Type}");
    }
}

public class PointIcon
{
    public readonly PointType Type;
    private readonly byte[] _icon;

    public PointIcon(PointType type, byte[] icon)
    {
        _icon = icon;
        Type = type;
    }
}

public enum PointType
{
    CAFE = 1,
    RESTAURANT = 2,
    HOSPITAL = 3
}

public class PointIconFactory
{
    private readonly Dictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();
    public PointIcon GetPointIcon(PointType type)
    {
        if (!_icons.ContainsKey(type))
        {
            var icon = new PointIcon(type, null);
            _icons.Add(type, icon);
        }
        return _icons[type];
    }
}

public class PointService
{
    private PointIconFactory IconFactory { get; set; }

    public PointService(PointIconFactory iconFactory)
    {
        IconFactory = iconFactory;
    }
    public List<Point> GetPoints()
    {
        return [new Point(x: 1, y: 2, icon: IconFactory.GetPointIcon(PointType.CAFE))];
    }
}
```

In this example, the `Point` class represents a point on the map, and the `PointIcon` class represents the icon to be displayed for that point. The `PointIconFactory` is responsible for managing the `PointIcon` instances and ensuring that each unique type of point has only one `PointIcon` instance.

Without the Flyweight pattern, each `Point` object would need to store its own copy of the icon data, which could quickly lead to high memory consumption, especially if the application has a large number of points. By using the Flyweight pattern, the `Point` objects only store a reference to the `PointIcon` instance, which is shared among all `Point` objects of the same type.

## Usage Examples

Here's an example of how you might use the `PointService` class to create a list of `Point` objects:

```csharp
var iconFactory = new PointIconFactory();
var pointService = new PointService(iconFactory);
var points = pointService.GetPoints();
foreach (var point in points)
{
    point.Draw();
}
```

In this example, the `PointService` class is responsible for creating the `Point` objects and obtaining the appropriate `PointIcon` instances from the `PointIconFactory`. The `Point` objects are then used to draw the points on the map.

## Benefits of Composition over Inheritance

In this case, the Flyweight pattern favors composition over inheritance. Instead of having the `Point` class inherit from a base `PointBase` class that includes the icon data, the `Point` class is composed of a `PointIcon` instance. This allows for more flexibility and easier maintenance, as the `PointIcon` class can be easily modified or extended without affecting the `Point` class.

Additionally, composition can make the code more testable, as the `Point` class can be tested independently of the `PointIcon` class, and vice versa. This can lead to more reliable and maintainable code.

## When to Use and When Not to Use the Flyweight Pattern

The Flyweight pattern is particularly useful when:

- Your application needs to work with a large number of similar objects.
- The objects contain a significant amount of repetitive or redundant data.
- The repetitive data can be extracted and shared among the objects.

However, the Flyweight pattern may not be the best choice if:

- The overhead of managing the shared data (e.g., the `PointIconFactory`) outweighs the memory savings.
- The application does not have a large number of similar objects, and the memory usage is not a significant concern.
- The objects have a significant amount of unique data that cannot be shared.

## Best Practices

When using the Flyweight pattern, consider the following best practices:

1. **Identify the Intrinsic and Extrinsic State**: Carefully analyze the state of your objects and determine which parts are intrinsic (unchangeable) and which are extrinsic (changeable). This will help you identify the data that can be shared using the Flyweight pattern.
2. **Optimize the Shared State**: Ensure that the shared state (the `PointIcon` class in the example) is as efficient as possible, both in terms of memory usage and access speed.
3. **Avoid Over-optimization**: Don't try to apply the Flyweight pattern to every possible object in your application. Only use it where it provides a significant benefit in terms of memory usage or performance.
4. **Ensure Thread Safety**: If your application is multithreaded, make sure that the shared state (the `PointIconFactory` in the example) is thread-safe to avoid race conditions and other concurrency issues.
5. **Consider Performance Tradeoffs**: Introducing the Flyweight pattern can add some overhead in terms of object creation and lookup, so be sure to measure the impact on performance and make sure the benefits outweigh the costs.

## Conclusion

The Flyweight design pattern is a powerful tool for reducing memory consumption in applications that work with a large number of similar objects. By separating the intrinsic and extrinsic state of an object and sharing the extrinsic state among multiple instances, the Flyweight pattern can significantly reduce the memory footprint of your application.

In the case of the map application example, the Flyweight pattern allows the application to display a large number of points on the map without consuming an excessive amount of memory. By using the `PointIconFactory` to manage the `PointIcon` instances, the application can ensure that each unique type of point has only one `PointIcon` instance, reducing the overall memory usage.

Overall, the Flyweight pattern is a valuable tool in the software architect's toolbox, and understanding its principles and best practices can help you design more efficient and scalable applications.