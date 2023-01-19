public interface ISensor
{
    void InitConfig();
    List<object> ReadData();
    bool SendData(List<object> data);
    void WriteLog(string message);
}
public class TemperatureSensor : ISensor
{
    public void InitConfig()
    {

    }

    //Don’t have ReadData() method.
    public List<object> ReadData()
    {
        return new List<object>();
    }

    public bool SendData(List<object> data)
    {
        return true;
    }
    public void WriteLog(string message)
    {

    }
}
