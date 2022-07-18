using C = Composite.Components;

C.Component root = new C.Composite("Root");
C.Component leaf = new C.Leaf("Leaf");
C.Component subtree = new C.Composite("Subtree");

root.Add(leaf);
root.Add(subtree);
root.Display();