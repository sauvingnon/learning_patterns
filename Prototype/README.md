# Prototype (Прототип)
Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов. То есть по сути данный паттерн предлагает технику клонирования объектов.

## Когда надо применять паттерн Прототип?

- Когда конкретный тип создаваемого объекта должен определяться динамически во время выполнения.
- Когда нежелательно создание отдельной иерархии классов фабрик для создания объектов-продуктов из параллельной иерархии классов (как это делается, например, при использовании паттерна Абстрактная фабрика).
- Когда клонирование объекта является более предпочтительным вариантом нежели его создание и инициализация с помощью конструктора. Особенно когда известно, что объект может принимать небольшое ограниченное число возможных состояний.

## UML диаграмма

![UML](https://metanit.com/sharp/patterns/pics/prototype.png)

## Участники

- **Prototype**: определяет интерфейс для клонирования самого себя, который, как правило, представляет метод *Clone()*.
- **ConcretePrototype1** и **ConcretePrototype2**: конкретные реализации прототипа. Реализуют метод *Clone()*.
- **Client**: создает объекты прототипов с помощью метода *Clone()*.

## Формальное определение

```csharp
class Client
{
    void Operation()
    {
        Prototype prototype = new ConcretePrototype1(1);
        Prototype clone = prototype.Clone();
        prototype = new ConcretePrototype2(2);
        clone = prototype.Clone();
    }
}
 
abstract class Prototype
{
    public int Id { get; private set; }
    public Prototype(int id)
    {
        this.Id = id;
    }
    public abstract Prototype Clone();
}
 
class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(int id)
        : base(id)
    { }
    public override Prototype Clone()
    {
        return new ConcretePrototype1(Id);
    }
}
 
class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(int id)
        : base(id)
    { }
    public override Prototype Clone()
    {
        return new ConcretePrototype2(Id);
    }
}
```