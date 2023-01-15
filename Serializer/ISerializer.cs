namespace Shared.Serializer
{
    public interface ISerializer
    {
        byte[] Serialize(string data);
        string Deserialize(byte[] data);
    }
}