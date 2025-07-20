namespace Monostate;

internal class MonostateExample
{
    private static string _prop1;
    
    private static string _prop2;

    internal string Prop1 { get => _prop1; set => _prop1 = value; }
    internal string Prop2 { get => _prop2; set => _prop2 = value; }
}
