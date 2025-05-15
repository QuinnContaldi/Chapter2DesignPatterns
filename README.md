# Chapter Two Observer Design Pattern

---

## A Behavioral Design Pattern

> Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.
> This is amongst one of the most important design patterns, especially for game development. Most game developers using unity engine have at one point utilized this design pattern
> without even realizing it. Event based programming is a prime example of the observable design pattern. Does subscribing to functions sound familiar?

### The Two Key Components Of The Subject Observer Design Pattern

> **Subject:** Is the object *that is being observed*. This is the one in the one and many relationship. The `Subject` is the object that is notifying the observers of its change. The subject
> is the one pushing its changes to the `Observers`
> <br>
> 
> **Observer:**
> Is the object that *is observing the subject*. This is the many in the one-to-many relationship. The `Observer` is the object that is waiting to be notified that a change has occured in the
> subject. 
> <br>
> 
> **Subscribing / Unsubscribing:**
> This is simply the method in which Observers will request to add themselves to the information sharing of the subject. The inverse of this, is of course asking to be removed from the subjects
> information sharing. Hence `Subscribing / Unsubscribing`

### Attributes 

#### Push VS Polling

> **Polling:** Is the act of constantly requesting information over a specified interval. `HAVE YOUR STATE CHANGED?` Since, I am a game developer we will use a game development example. Imagine we want to
> control our character. A primitive implementation could be constructing a giant if statement function called `Player Controller` which is invoked in the update loop. For every possible
> control our game will constantly ask if each button has been activated by the player. For example **IF** the joystick has been moved right, move right. Executing 16 or more if statements
> is not only tedious, but unoptimized.
> <br> 
> 
> **Push:** Instead of requesting information constantly, lets receive information that's pushed to our game. `I HAVE CHANGED MY STATE`. Let's use our controller example again. Now whenever our controller
> receives input, it will update our character by invoking the proper movement function. So, instead of our game constantly asking if input has been received. The controller notifies us input has
> been detected. This method drastically reduces the number of function calls. 

#### One To Many
> The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.
#### Q & A With North Star

Question: "So instead of us constantly asking, _'Have you changed? Have you changed? Have you changed?'_ every update loop, we instead wait until we're told, _'I have changed!'_" <br>
Answer: "Yes! Exactly! That's why you're the smartest engineering catgirl around, It's so much effort to keep asking over and over if something has changed. It's far easier to just wait and be notified when a change happens

Question: "What about my Instagram feed? Is people following my account an example of a **`one-to-many relationship`**? The many being my followers, and the one being me. _I am she! I am the one!_" <br>
Answer: "Correct again, my clever catgirl friend! Your followers are the **many**, and you are the **one**! This is the heart of our design pattern: effectively managing **one-to-many relationships**. Another
very useful tool in our programming tool belt"

Question: "So, continuing off my Instagram example, my followers are the **`Observers`**, waiting to update their feeds with my posts. That makes me the **`Subject`**, nyahahaha~! Once I post content on my Instagram, my 
followers are updated immediately. And, of course, the follow button is how my followers **`subscribe`** to be notified about my posts in the first place!"<br>
Answer: "Meowtastic, You are doing a great job understanding the Observer design pattern Miss North Star. Now that we have the basics down lets move onto the design"

---
## Design

### Subject Interface

```csharp
public interface ISubject 
{
    public void RegistorObserver(Observer observer);
    public void RemoveObserver(Observer observer);
    public void NotifyObserver();
}   
```
> `RegistorObserver(Observer observer)` Will use a list or an array to keep track of all observers. This way we know who to notify when a state has been changed! <br>
> `RemoveObserver(Observer observer)` Of course, if we register and observer we will need some way of unregistering one! <br>
>  `NotifyObserver()` The crème de la crème of our function! We will iterate through our list of observers calling the update method on each one! This will pass in the necessary information for our observers and update their state.

### Observer Interface

```csharp
public interface IObserver
{
    public void update();    
}
```
> This is the interface that all observers are contracted to implement. This method will be invoked by the subject, on a list of 0 to n `Observers`. It's that simple! Just a single function needs to be implemented in our concrete 
> `Observer` class. The rest of the details of what we do with this updated information from the `Subject` can be defined in this concrete `Observer` class.

---
## Observer Design Pattern in the Code
### Identification of Components in the Code
1. **Subject**:
   The `Commander` class serves as the **Subject**. It maintains a list of observers (`Squad`s or `Unit`s like the `Tank`) and provides methods to:
    - **Register Observers** (`RegistorObserver`)
    - **Notify Observers** (`NotifyObserver`) of changes or actions to take.

> **Subject:** Is the object _that is being observed_. The `Subject` is the object notifying the observers of changes.
>

2. **Observer**:
   Classes such as `Squad` and `Tank` act as **Observers**. These classes register themselves with the `Commander` (the Subject) and implement the behavior on what to do when they are notified through methods like `ExecuteOrders`.

> **Observer:** Is the object that _is observing the subject_. This is the object waiting to be notified of changes.
>

3. **Subscription Mechanism**:
   The `RegistorObserver` method in the `Commander` class allows `Observers` (like `RedSquad`, `BlackSquad`, and `Tank1`) to subscribe to notifications from the subject. When commanders notify their observers, all registered observers receive the updates about the orders, fulfilling the subscription mechanism described in your Markdown:

> **Subscribing:** Observers add themselves to the Subject's notification list to receive updates.


### Outline of Push Mechanism
The **Push** strategy is clearly utilized here. The `Commander` (Subject) pushes information to its observers by calling their `ExecuteOrders` or other relevant methods to notify them of changes.
For instance:
General_Black.NotifyObserver("Take the Bridge!");
RedSquad.ExecuteOrders();**Explanation**:
- The `NotifyObserver` method is invoked on the Subject (`Commander`), passing an order (string) like `"Take the Bridge!"`.
- The observers (`RedSquad` and later `BlackSquad`) receive the notification and take action via their `ExecuteOrders` method, which executes their roles.
