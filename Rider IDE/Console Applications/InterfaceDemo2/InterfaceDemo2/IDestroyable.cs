namespace InterfaceDemo2;

public interface IDestroyable
{
    string DestructionSound { get; set; }

    void Destroy();
}