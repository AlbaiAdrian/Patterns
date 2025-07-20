// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, World!");


SimpleObject simpleLeaf = new SimpleObject("gigi", "it's broken");

SimpleObject leaf = new SimpleObject("gigi", "it's broken");
SimpleObject leaf1 = new SimpleObject("gigi1", "fix it");

var branch = new CompositeObject("cada");
branch.Add(leaf);
branch.Add(leaf1);

var branch1 = new CompositeObject("robinet");
branch1.Add(leaf);
branch1.Add(leaf1);
branch.Add(branch1);

var branch2 = new CompositeObject("dus");
branch2.Add(leaf);
branch2.Add(leaf1);

branch1.Add(branch2);

Console.WriteLine(simpleLeaf.Operation());
File.WriteAllText("simple.json",simpleLeaf.Operation());
Console.WriteLine(branch.Operation());
File.WriteAllText("composite.json", branch.Operation());