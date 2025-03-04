# Посредник (Mediator)
Паттерн Посредник (Mediator) представляет такой шаблон проектирования, который обеспечивает взаимодействие множества объектов без необходимости ссылаться друг на друга. Тем самым достигается слабосвязанность взаимодействующих объектов.

## Реальный пример
Система создания программных продуктов включает ряд акторов: заказчики, программисты, тестировщики и так далее. Но нередко все эти акторы взаимодействуют между собой не непосредственно, а опосредованно через менеджера проектов. То есть менеджер проектов выполняет роль посредника.

## Когда надо применять паттерн Посредник?

- Когда имеется множество взаимосвязаных объектов, связи между которыми сложны и запутаны.
- Когда необходимо повторно использовать объект, однако повторное использование затруднено в силу сильных связей с другими объектами.

## UML диаграмма

![UML](https://metanit.com/sharp/patterns/pics/mediator.png)

## Участники

- **Mediator**: представляет интерфейс для взаимодействия с объектами *Colleague*.
- **Colleague**: представляет интерфейс для взаимодействия с объектом *Mediator*.
- **ConcreteColleague1** и **ConcreteColleague2**: конкретные классы коллег, которые обмениваются друг с другом через объект *Mediator*.
- **ConcreteMediator**: конкретный посредник, реализующий интерфейс типа *Mediator*.

## Формальное определение

```csharp
abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}
 
abstract class Colleague
{
    protected Mediator mediator;
 
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}
 
class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator)
        : base(mediator)
    { }
  
    public void Send(string message)
    {
        mediator.Send(message, this);
    }
  
    public void Notify(string message)
    { }
}
 
class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator)
        : base(mediator)
    { }
  
    public void Send(string message)
    {
        mediator.Send(message, this);
    }
  
    public void Notify(string message)
    { }
}
 
class ConcreteMediator : Mediator
{
    public ConcreteColleague1 Colleague1 { get; set; }
    public ConcreteColleague2 Colleague2 { get; set; }
    public override void Send(string msg, Colleague colleague)
    {
        if (Colleague1 == colleague)
            Colleague2.Notify(msg);
        else
            Colleague1.Notify(msg);
    }
}
```