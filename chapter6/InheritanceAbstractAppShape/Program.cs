using ShapeLibInheritanceAbstract;

Circle circle = new()
{
    R = 5.5
};
Rectangle rectangle = new()
{
    Width=12,
    Height=3
};

Shape shape = new Circle();
shape.CalculateArea();

Shape shape2 = new Rectangle();
shape2.CalculateArea();