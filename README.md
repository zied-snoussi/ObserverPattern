# Real-time Market Data Tracker

## :speech_balloon: Intent
***Real-time Market Data Tracker*** is a sophisticated financial analysis and monitoring system that leverages the Observer design pattern to deliver real-time market data updates to traders, investors, and financial analysts. It is designed to provide a competitive edge in the dynamic world of finance.

![Real-time Market Data Tracker](https://user-images.githubusercontent.com/74665047/210447316-e1817262-9fe2-435d-b9b5-4f13126f95fe.png)

## :frowning_face: Problem
In the realm of financial markets, the ability to access and respond to real-time market data is paramount. Traders and investors require accurate, timely information to make informed decisions. Conventional methods of monitoring market data, such as manual tracking or email alerts, fall short in delivering the speed and precision demanded by the financial industry.

![Problem](https://user-images.githubusercontent.com/74665047/210435947-9bf4e2d7-9b31-4bdb-a57a-66b75464cc1c.png)

## :blush: Solution
The **Real-time Market Data Tracker** relies on the Observer pattern to provide immediate updates on market data. In this pattern, market data serves as the publisher, while analysis modules, user dashboards, and alert systems act as subscribers. This architecture ensures that users receive instant notifications and updates on market changes, enabling them to stay ahead of the curve.

![Solution](https://user-images.githubusercontent.com/74665047/210436135-e271266d-7902-4bad-9315-b1494f5ecbde.png)

## :car: Real-World
![Real-World](https://user-images.githubusercontent.com/74665047/210436320-e07628f6-875c-4b7f-bf47-fe24bcd93731.png)

The Observer pattern finds practical use in the financial industry. Just as subscribers receive magazines directly in their mailboxes after subscribing, financial professionals benefit from real-time market data updates delivered to their devices. Subscribers can easily opt in or out of specific updates, allowing for a tailored experience.

## :trident: Structure
![Structure](https://user-images.githubusercontent.com/74665047/210439969-e38ca98d-c5c5-4c51-b10e-b4b3b0d10e96.png)

1. **Market Data Publisher**: Responsible for issuing events when market data changes. It maintains a subscription infrastructure to manage subscribers.

2. **Subscriber Interface**: Declares the notification interface, often consisting of a single update method. All subscribers implement this interface.

3. **Concrete Subscribers**: Respond to notifications issued by the market data publisher. Each subscriber class must implement the subscriber interface.

4. **Client**: Creates publisher and subscriber objects separately and registers subscribers for market data updates.

## :diamond_shape_with_a_dot_inside: Pseudocode
In this example, the Observer pattern allows the market data publisher to notify various analysis modules and user dashboards about changes in market data.

![Pseudocode](https://user-images.githubusercontent.com/74665047/210440406-00a45146-aadf-48b5-84dc-7bd602ad4b5e.png)

The subscription list is dynamic, enabling objects to join or leave the list as needed, ensuring flexibility and scalability.

```python
# Market data publisher class includes subscription management code and notification methods.
class MarketDataPublisher:
    private field subscribers: hash map of event types and listeners

    method subscribe(eventType, listener) is
        subscribers.add(eventType, listener)

    method unsubscribe(eventType, listener) is
        subscribers.remove(eventType, listener)

    method notify(eventType, data) is
        foreach (listener in subscribers.of(eventType)) do
            listener.update(data)

# Concrete market data publisher contains real business logic of tracking market data changes.
class RealTimeMarketDataPublisher:
    public field events: MarketDataPublisher
    private field marketData: MarketData

    constructor RealTimeMarketDataPublisher() is
        events = new MarketDataPublisher()

    method trackMarketData() is
        # Logic for tracking market data changes
        # ...

# Subscriber interface declares the notification interface.
interface MarketDataSubscriber:
    method update(data)

# Concrete subscribers respond to market data updates.
class AnalysisModule implements MarketDataSubscriber is
    private field analysisData: AnalysisData

    method update(data) is
        analysisData.process(data)

class UserDashboard implements MarketDataSubscriber is
    private field user: User

    method update(data) is
        user.displayData(data)

# Client configures publishers and registers subscribers for market data updates.
class FinancialApplication is
    method configure() is
        marketDataPublisher = new RealTimeMarketDataPublisher()

        analysisModule = new AnalysisModule()
        marketDataPublisher.events.subscribe("marketChange", analysisModule)

        userDashboard = new UserDashboard()
        marketDataPublisher.events.subscribe("marketChange", userDashboard)
```

##  :bulb: Applicability
### Use the Observer pattern when changes to the state of one object must trigger changes in other objects, and the set

 of objects is not known in advance or changes dynamically.

This pattern is highly suitable for graphical user interfaces. For example, when creating custom button classes, you can enable clients to attach custom code to buttons, allowing them to respond to button clicks dynamically.

### Use the pattern when some objects need to observe others, but only for a limited time or in specific cases.

The subscription list is dynamic, allowing subscribers to join or leave as needed.

## :keyboard: How to Implement

1. Analyze your application's business logic to separate the core functionality (the publisher) from other code that will become subscriber classes.

2. Declare the subscriber interface, which should include at least a single update method.

3. Define the publisher interface with methods for adding and removing subscriber objects from the list. Ensure that publishers interact with subscribers solely through this interface.

4. Decide where to place the subscription list and the implementation of subscription methods. Often, this code remains consistent for various publishers, making it suitable for an abstract class derived directly from the publisher interface. Concrete publishers can extend this class to inherit the subscription behavior.

5. If applying the pattern to an existing class hierarchy, consider a composition-based approach. Create a separate object responsible for subscription logic and have all publishers use it.

6. Develop concrete publisher classes. Whenever a significant event occurs within a publisher, notify all subscribers.

7. Implement update notification methods in concrete subscriber classes. Most subscribers will require contextual information about the event, which can be passed as arguments to the notification method. Alternatively, the publisher can pass itself to allow subscribers to fetch necessary data directly.

8. The client should create all required subscribers and register them for publisher updates.

## :balance_scale: Pros and Cons

:heavy_check_mark: Open/Closed Principle: You can introduce new subscriber classes without modifying the publisher's code (and vice versa if a publisher interface exists).

:heavy_check_mark: Dynamic Relationships: Subscribers can join or leave the list as needed.

:x: Random Notification Order: Subscribers are notified in a random order.

## :arrows_counterclockwise: Relations with Other Patterns

- Chain of Responsibility, Command, Mediator, and Observer all address various methods of connecting senders and receivers of requests:

  - Chain of Responsibility passes a request sequentially along a dynamic chain of potential receivers until one handles it.
  
  - Command establishes unidirectional connections between senders and receivers.
  
  - Mediator eliminates direct connections between senders and receivers, forcing communication through a mediator object.
  
  - Observer enables receivers to dynamically subscribe to and unsubscribe from receiving requests.

- The distinction between Mediator and Observer can sometimes be blurred. In many cases, you can implement either pattern or even both simultaneously. The primary goal of Mediator is to eliminate mutual dependencies among system components, while Observer allows one-way connections between objects. A popular implementation of Mediator uses Observer, where the mediator acts as the publisher, and components are subscribers. In this configuration, Mediator resembles Observer.

  When in doubt, remember that you can implement Mediator in different ways. For instance, you can permanently link all components to the same mediator object. While this implementation doesn't resemble Observer, it remains a form of the Mediator pattern.
